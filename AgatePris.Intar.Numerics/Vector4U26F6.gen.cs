using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U26F6 : IEquatable<Vector4U26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;
        public U26F6 Z;
        public U26F6 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, U26F6 z, U26F6 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, Vector2U26F6 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector3U26F6 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, Vector2U26F6 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector4U26F6 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector2U26F6 yz, U26F6 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector3U26F6 xyz, U26F6 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, U26F6 z, U26F6 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero);
        }
        public static Vector4U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One);
        }
        public static Vector4U26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One, U26F6.Zero, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.One, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.One, U26F6.Zero);
        }
        public static Vector4U26F6 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.Zero, U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator +(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator -(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U26F6 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, X); }
        public readonly Vector2U26F6 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Y); }
        public readonly Vector2U26F6 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Z); }
        public readonly Vector2U26F6 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, W); }
        public readonly Vector2U26F6 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, X); }
        public readonly Vector2U26F6 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Y); }
        public readonly Vector2U26F6 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Z); }
        public readonly Vector2U26F6 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, W); }
        public readonly Vector2U26F6 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, X); }
        public readonly Vector2U26F6 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Y); }
        public readonly Vector2U26F6 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Z); }
        public readonly Vector2U26F6 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, W); }
        public readonly Vector2U26F6 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, X); }
        public readonly Vector2U26F6 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, Y); }
        public readonly Vector2U26F6 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, Z); }
        public readonly Vector2U26F6 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(W, W); }
        public readonly Vector3U26F6 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, X); }
        public readonly Vector3U26F6 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Y); }
        public readonly Vector3U26F6 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Z); }
        public readonly Vector3U26F6 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, W); }
        public readonly Vector3U26F6 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, X); }
        public readonly Vector3U26F6 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Y); }
        public readonly Vector3U26F6 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Z); }
        public readonly Vector3U26F6 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, W); }
        public readonly Vector3U26F6 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, X); }
        public readonly Vector3U26F6 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Y); }
        public readonly Vector3U26F6 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Z); }
        public readonly Vector3U26F6 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, W); }
        public readonly Vector3U26F6 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, X); }
        public readonly Vector3U26F6 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, Y); }
        public readonly Vector3U26F6 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, Z); }
        public readonly Vector3U26F6 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, W, W); }
        public readonly Vector3U26F6 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, X); }
        public readonly Vector3U26F6 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Y); }
        public readonly Vector3U26F6 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Z); }
        public readonly Vector3U26F6 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, W); }
        public readonly Vector3U26F6 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, X); }
        public readonly Vector3U26F6 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Y); }
        public readonly Vector3U26F6 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Z); }
        public readonly Vector3U26F6 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, W); }
        public readonly Vector3U26F6 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, X); }
        public readonly Vector3U26F6 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Y); }
        public readonly Vector3U26F6 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Z); }
        public readonly Vector3U26F6 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, W); }
        public readonly Vector3U26F6 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, X); }
        public readonly Vector3U26F6 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, Y); }
        public readonly Vector3U26F6 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, Z); }
        public readonly Vector3U26F6 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, W, W); }
        public readonly Vector3U26F6 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, X); }
        public readonly Vector3U26F6 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Y); }
        public readonly Vector3U26F6 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Z); }
        public readonly Vector3U26F6 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, W); }
        public readonly Vector3U26F6 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, X); }
        public readonly Vector3U26F6 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Y); }
        public readonly Vector3U26F6 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Z); }
        public readonly Vector3U26F6 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, W); }
        public readonly Vector3U26F6 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, X); }
        public readonly Vector3U26F6 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Y); }
        public readonly Vector3U26F6 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Z); }
        public readonly Vector3U26F6 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, W); }
        public readonly Vector3U26F6 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, X); }
        public readonly Vector3U26F6 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, Y); }
        public readonly Vector3U26F6 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, Z); }
        public readonly Vector3U26F6 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, W, W); }
        public readonly Vector3U26F6 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, X); }
        public readonly Vector3U26F6 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, Y); }
        public readonly Vector3U26F6 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, Z); }
        public readonly Vector3U26F6 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, X, W); }
        public readonly Vector3U26F6 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, X); }
        public readonly Vector3U26F6 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, Y); }
        public readonly Vector3U26F6 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, Z); }
        public readonly Vector3U26F6 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Y, W); }
        public readonly Vector3U26F6 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, X); }
        public readonly Vector3U26F6 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, Y); }
        public readonly Vector3U26F6 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, Z); }
        public readonly Vector3U26F6 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, Z, W); }
        public readonly Vector3U26F6 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, X); }
        public readonly Vector3U26F6 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, Y); }
        public readonly Vector3U26F6 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, Z); }
        public readonly Vector3U26F6 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(W, W, W); }
        public readonly Vector4U26F6 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, X); }
        public readonly Vector4U26F6 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Y); }
        public readonly Vector4U26F6 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Z); }
        public readonly Vector4U26F6 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, W); }
        public readonly Vector4U26F6 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, X); }
        public readonly Vector4U26F6 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Y); }
        public readonly Vector4U26F6 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Z); }
        public readonly Vector4U26F6 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, W); }
        public readonly Vector4U26F6 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, X); }
        public readonly Vector4U26F6 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Y); }
        public readonly Vector4U26F6 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Z); }
        public readonly Vector4U26F6 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, W); }
        public readonly Vector4U26F6 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, X); }
        public readonly Vector4U26F6 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, Y); }
        public readonly Vector4U26F6 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, Z); }
        public readonly Vector4U26F6 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, W, W); }
        public readonly Vector4U26F6 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, X); }
        public readonly Vector4U26F6 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Y); }
        public readonly Vector4U26F6 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Z); }
        public readonly Vector4U26F6 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, W); }
        public readonly Vector4U26F6 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, X); }
        public readonly Vector4U26F6 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Y); }
        public readonly Vector4U26F6 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Z); }
        public readonly Vector4U26F6 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, W); }
        public readonly Vector4U26F6 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, X); }
        public readonly Vector4U26F6 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Y); }
        public readonly Vector4U26F6 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Z); }
        public readonly Vector4U26F6 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, W); }
        public readonly Vector4U26F6 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, X); }
        public readonly Vector4U26F6 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, Y); }
        public readonly Vector4U26F6 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, Z); }
        public readonly Vector4U26F6 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, W, W); }
        public readonly Vector4U26F6 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, X); }
        public readonly Vector4U26F6 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Y); }
        public readonly Vector4U26F6 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Z); }
        public readonly Vector4U26F6 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, W); }
        public readonly Vector4U26F6 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, X); }
        public readonly Vector4U26F6 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Y); }
        public readonly Vector4U26F6 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Z); }
        public readonly Vector4U26F6 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, W); }
        public readonly Vector4U26F6 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, X); }
        public readonly Vector4U26F6 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Y); }
        public readonly Vector4U26F6 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Z); }
        public readonly Vector4U26F6 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, W); }
        public readonly Vector4U26F6 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, X); }
        public readonly Vector4U26F6 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, Y); }
        public readonly Vector4U26F6 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, Z); }
        public readonly Vector4U26F6 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, W, W); }
        public readonly Vector4U26F6 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, X); }
        public readonly Vector4U26F6 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, Y); }
        public readonly Vector4U26F6 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, Z); }
        public readonly Vector4U26F6 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, X, W); }
        public readonly Vector4U26F6 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, X); }
        public readonly Vector4U26F6 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, Y); }
        public readonly Vector4U26F6 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, Z); }
        public readonly Vector4U26F6 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Y, W); }
        public readonly Vector4U26F6 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, X); }
        public readonly Vector4U26F6 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, Y); }
        public readonly Vector4U26F6 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, Z); }
        public readonly Vector4U26F6 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, Z, W); }
        public readonly Vector4U26F6 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, X); }
        public readonly Vector4U26F6 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, Y); }
        public readonly Vector4U26F6 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, Z); }
        public readonly Vector4U26F6 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, W, W, W); }
        public readonly Vector4U26F6 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, X); }
        public readonly Vector4U26F6 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Y); }
        public readonly Vector4U26F6 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Z); }
        public readonly Vector4U26F6 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, W); }
        public readonly Vector4U26F6 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, X); }
        public readonly Vector4U26F6 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Y); }
        public readonly Vector4U26F6 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Z); }
        public readonly Vector4U26F6 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, W); }
        public readonly Vector4U26F6 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, X); }
        public readonly Vector4U26F6 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Y); }
        public readonly Vector4U26F6 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Z); }
        public readonly Vector4U26F6 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, W); }
        public readonly Vector4U26F6 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, X); }
        public readonly Vector4U26F6 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, Y); }
        public readonly Vector4U26F6 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, Z); }
        public readonly Vector4U26F6 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, W, W); }
        public readonly Vector4U26F6 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, X); }
        public readonly Vector4U26F6 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Y); }
        public readonly Vector4U26F6 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Z); }
        public readonly Vector4U26F6 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, W); }
        public readonly Vector4U26F6 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, X); }
        public readonly Vector4U26F6 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Y); }
        public readonly Vector4U26F6 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Z); }
        public readonly Vector4U26F6 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, W); }
        public readonly Vector4U26F6 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, X); }
        public readonly Vector4U26F6 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Y); }
        public readonly Vector4U26F6 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Z); }
        public readonly Vector4U26F6 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, W); }
        public readonly Vector4U26F6 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, X); }
        public readonly Vector4U26F6 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, Y); }
        public readonly Vector4U26F6 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, Z); }
        public readonly Vector4U26F6 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, W, W); }
        public readonly Vector4U26F6 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, X); }
        public readonly Vector4U26F6 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Y); }
        public readonly Vector4U26F6 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Z); }
        public readonly Vector4U26F6 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, W); }
        public readonly Vector4U26F6 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, X); }
        public readonly Vector4U26F6 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Y); }
        public readonly Vector4U26F6 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Z); }
        public readonly Vector4U26F6 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, W); }
        public readonly Vector4U26F6 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, X); }
        public readonly Vector4U26F6 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Y); }
        public readonly Vector4U26F6 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Z); }
        public readonly Vector4U26F6 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, W); }
        public readonly Vector4U26F6 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, X); }
        public readonly Vector4U26F6 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, Y); }
        public readonly Vector4U26F6 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, Z); }
        public readonly Vector4U26F6 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, W, W); }
        public readonly Vector4U26F6 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, X); }
        public readonly Vector4U26F6 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, Y); }
        public readonly Vector4U26F6 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, Z); }
        public readonly Vector4U26F6 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, X, W); }
        public readonly Vector4U26F6 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, X); }
        public readonly Vector4U26F6 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, Y); }
        public readonly Vector4U26F6 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, Z); }
        public readonly Vector4U26F6 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Y, W); }
        public readonly Vector4U26F6 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, X); }
        public readonly Vector4U26F6 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, Y); }
        public readonly Vector4U26F6 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, Z); }
        public readonly Vector4U26F6 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, Z, W); }
        public readonly Vector4U26F6 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, X); }
        public readonly Vector4U26F6 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, Y); }
        public readonly Vector4U26F6 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, Z); }
        public readonly Vector4U26F6 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, W, W, W); }
        public readonly Vector4U26F6 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, X); }
        public readonly Vector4U26F6 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Y); }
        public readonly Vector4U26F6 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Z); }
        public readonly Vector4U26F6 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, W); }
        public readonly Vector4U26F6 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, X); }
        public readonly Vector4U26F6 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Y); }
        public readonly Vector4U26F6 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Z); }
        public readonly Vector4U26F6 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, W); }
        public readonly Vector4U26F6 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, X); }
        public readonly Vector4U26F6 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Y); }
        public readonly Vector4U26F6 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Z); }
        public readonly Vector4U26F6 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, W); }
        public readonly Vector4U26F6 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, X); }
        public readonly Vector4U26F6 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, Y); }
        public readonly Vector4U26F6 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, Z); }
        public readonly Vector4U26F6 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, W, W); }
        public readonly Vector4U26F6 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, X); }
        public readonly Vector4U26F6 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Y); }
        public readonly Vector4U26F6 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Z); }
        public readonly Vector4U26F6 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, W); }
        public readonly Vector4U26F6 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, X); }
        public readonly Vector4U26F6 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Y); }
        public readonly Vector4U26F6 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Z); }
        public readonly Vector4U26F6 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, W); }
        public readonly Vector4U26F6 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, X); }
        public readonly Vector4U26F6 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Y); }
        public readonly Vector4U26F6 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Z); }
        public readonly Vector4U26F6 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, W); }
        public readonly Vector4U26F6 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, X); }
        public readonly Vector4U26F6 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, Y); }
        public readonly Vector4U26F6 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, Z); }
        public readonly Vector4U26F6 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, W, W); }
        public readonly Vector4U26F6 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, X); }
        public readonly Vector4U26F6 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Y); }
        public readonly Vector4U26F6 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Z); }
        public readonly Vector4U26F6 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, W); }
        public readonly Vector4U26F6 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, X); }
        public readonly Vector4U26F6 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Y); }
        public readonly Vector4U26F6 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Z); }
        public readonly Vector4U26F6 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, W); }
        public readonly Vector4U26F6 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, X); }
        public readonly Vector4U26F6 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Y); }
        public readonly Vector4U26F6 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Z); }
        public readonly Vector4U26F6 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, W); }
        public readonly Vector4U26F6 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, X); }
        public readonly Vector4U26F6 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, Y); }
        public readonly Vector4U26F6 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, Z); }
        public readonly Vector4U26F6 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, W, W); }
        public readonly Vector4U26F6 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, X); }
        public readonly Vector4U26F6 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, Y); }
        public readonly Vector4U26F6 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, Z); }
        public readonly Vector4U26F6 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, X, W); }
        public readonly Vector4U26F6 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, X); }
        public readonly Vector4U26F6 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, Y); }
        public readonly Vector4U26F6 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, Z); }
        public readonly Vector4U26F6 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Y, W); }
        public readonly Vector4U26F6 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, X); }
        public readonly Vector4U26F6 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, Y); }
        public readonly Vector4U26F6 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, Z); }
        public readonly Vector4U26F6 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, Z, W); }
        public readonly Vector4U26F6 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, X); }
        public readonly Vector4U26F6 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, Y); }
        public readonly Vector4U26F6 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, Z); }
        public readonly Vector4U26F6 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, W, W, W); }
        public readonly Vector4U26F6 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, X); }
        public readonly Vector4U26F6 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, Y); }
        public readonly Vector4U26F6 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, Z); }
        public readonly Vector4U26F6 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, X, W); }
        public readonly Vector4U26F6 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, X); }
        public readonly Vector4U26F6 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, Y); }
        public readonly Vector4U26F6 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, Z); }
        public readonly Vector4U26F6 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Y, W); }
        public readonly Vector4U26F6 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, X); }
        public readonly Vector4U26F6 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, Y); }
        public readonly Vector4U26F6 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, Z); }
        public readonly Vector4U26F6 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, Z, W); }
        public readonly Vector4U26F6 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, X); }
        public readonly Vector4U26F6 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, Y); }
        public readonly Vector4U26F6 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, Z); }
        public readonly Vector4U26F6 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, X, W, W); }
        public readonly Vector4U26F6 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, X); }
        public readonly Vector4U26F6 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, Y); }
        public readonly Vector4U26F6 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, Z); }
        public readonly Vector4U26F6 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, X, W); }
        public readonly Vector4U26F6 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, X); }
        public readonly Vector4U26F6 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, Y); }
        public readonly Vector4U26F6 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, Z); }
        public readonly Vector4U26F6 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Y, W); }
        public readonly Vector4U26F6 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, X); }
        public readonly Vector4U26F6 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, Y); }
        public readonly Vector4U26F6 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, Z); }
        public readonly Vector4U26F6 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, Z, W); }
        public readonly Vector4U26F6 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, X); }
        public readonly Vector4U26F6 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, Y); }
        public readonly Vector4U26F6 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, Z); }
        public readonly Vector4U26F6 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Y, W, W); }
        public readonly Vector4U26F6 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, X); }
        public readonly Vector4U26F6 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, Y); }
        public readonly Vector4U26F6 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, Z); }
        public readonly Vector4U26F6 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, X, W); }
        public readonly Vector4U26F6 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, X); }
        public readonly Vector4U26F6 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, Y); }
        public readonly Vector4U26F6 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, Z); }
        public readonly Vector4U26F6 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Y, W); }
        public readonly Vector4U26F6 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, X); }
        public readonly Vector4U26F6 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, Y); }
        public readonly Vector4U26F6 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, Z); }
        public readonly Vector4U26F6 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, Z, W); }
        public readonly Vector4U26F6 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, X); }
        public readonly Vector4U26F6 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, Y); }
        public readonly Vector4U26F6 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, Z); }
        public readonly Vector4U26F6 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, Z, W, W); }
        public readonly Vector4U26F6 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, X); }
        public readonly Vector4U26F6 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, Y); }
        public readonly Vector4U26F6 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, Z); }
        public readonly Vector4U26F6 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, X, W); }
        public readonly Vector4U26F6 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, X); }
        public readonly Vector4U26F6 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, Y); }
        public readonly Vector4U26F6 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, Z); }
        public readonly Vector4U26F6 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Y, W); }
        public readonly Vector4U26F6 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, X); }
        public readonly Vector4U26F6 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, Y); }
        public readonly Vector4U26F6 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, Z); }
        public readonly Vector4U26F6 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, Z, W); }
        public readonly Vector4U26F6 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, X); }
        public readonly Vector4U26F6 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, Y); }
        public readonly Vector4U26F6 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, Z); }
        public readonly Vector4U26F6 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(W, W, W, W); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U26F6 lhs, Vector4U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U26F6 lhs, Vector4U26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector4U26F6({X}, {Y}, {Z}, {W})";

        // IEquatable<Vector4U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U26F6 other)
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
            return $"Vector4U26F6({x}, {y}, {z}, {w})";
        }
    }
}
