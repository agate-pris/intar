using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U24F8 : IEquatable<Vector4U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U24F8 X;
        public U24F8 Y;
        public U24F8 Z;
        public U24F8 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, U24F8 z, U24F8 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, U24F8 y, Vector2U24F8 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector3U24F8 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, Vector2U24F8 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector4U24F8 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(U24F8 x, Vector2U24F8 yz, U24F8 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector3U24F8 xyz, U24F8 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8(Vector2U24F8 xy, U24F8 z, U24F8 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.Zero);
        }
        public static Vector4U24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.One);
        }
        public static Vector4U24F8 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.One, U24F8.Zero, U24F8.Zero, U24F8.Zero);
        }
        public static Vector4U24F8 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.Zero, U24F8.One, U24F8.Zero, U24F8.Zero);
        }
        public static Vector4U24F8 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.Zero, U24F8.Zero, U24F8.One, U24F8.Zero);
        }
        public static Vector4U24F8 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U24F8(U24F8.Zero, U24F8.Zero, U24F8.Zero, U24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator +(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator -(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator *(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(Vector4U24F8 a, U24F8 b) => new Vector4U24F8(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 operator /(U24F8 a, Vector4U24F8 b) => new Vector4U24F8(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U24F8 lhs, Vector4U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U24F8 lhs, Vector4U24F8 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U24F8 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, X); }
        public readonly Vector2U24F8 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, Y); }
        public readonly Vector2U24F8 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, Z); }
        public readonly Vector2U24F8 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, W); }
        public readonly Vector2U24F8 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, X); }
        public readonly Vector2U24F8 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, Y); }
        public readonly Vector2U24F8 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, Z); }
        public readonly Vector2U24F8 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, W); }
        public readonly Vector2U24F8 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, X); }
        public readonly Vector2U24F8 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, Y); }
        public readonly Vector2U24F8 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, Z); }
        public readonly Vector2U24F8 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Z, W); }
        public readonly Vector2U24F8 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, X); }
        public readonly Vector2U24F8 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, Y); }
        public readonly Vector2U24F8 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, Z); }
        public readonly Vector2U24F8 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(W, W); }
        public readonly Vector3U24F8 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, X); }
        public readonly Vector3U24F8 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, Y); }
        public readonly Vector3U24F8 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, Z); }
        public readonly Vector3U24F8 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, W); }
        public readonly Vector3U24F8 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, X); }
        public readonly Vector3U24F8 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, Y); }
        public readonly Vector3U24F8 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, Z); }
        public readonly Vector3U24F8 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, W); }
        public readonly Vector3U24F8 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, X); }
        public readonly Vector3U24F8 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, Y); }
        public readonly Vector3U24F8 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, Z); }
        public readonly Vector3U24F8 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Z, W); }
        public readonly Vector3U24F8 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, X); }
        public readonly Vector3U24F8 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, Y); }
        public readonly Vector3U24F8 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, Z); }
        public readonly Vector3U24F8 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, W, W); }
        public readonly Vector3U24F8 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, X); }
        public readonly Vector3U24F8 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, Y); }
        public readonly Vector3U24F8 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, Z); }
        public readonly Vector3U24F8 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, W); }
        public readonly Vector3U24F8 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, X); }
        public readonly Vector3U24F8 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, Y); }
        public readonly Vector3U24F8 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, Z); }
        public readonly Vector3U24F8 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, W); }
        public readonly Vector3U24F8 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, X); }
        public readonly Vector3U24F8 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, Y); }
        public readonly Vector3U24F8 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, Z); }
        public readonly Vector3U24F8 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Z, W); }
        public readonly Vector3U24F8 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, X); }
        public readonly Vector3U24F8 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, Y); }
        public readonly Vector3U24F8 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, Z); }
        public readonly Vector3U24F8 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, W, W); }
        public readonly Vector3U24F8 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, X); }
        public readonly Vector3U24F8 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, Y); }
        public readonly Vector3U24F8 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, Z); }
        public readonly Vector3U24F8 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, X, W); }
        public readonly Vector3U24F8 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, X); }
        public readonly Vector3U24F8 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, Y); }
        public readonly Vector3U24F8 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, Z); }
        public readonly Vector3U24F8 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Y, W); }
        public readonly Vector3U24F8 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, X); }
        public readonly Vector3U24F8 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, Y); }
        public readonly Vector3U24F8 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, Z); }
        public readonly Vector3U24F8 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, Z, W); }
        public readonly Vector3U24F8 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, X); }
        public readonly Vector3U24F8 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, Y); }
        public readonly Vector3U24F8 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, Z); }
        public readonly Vector3U24F8 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Z, W, W); }
        public readonly Vector3U24F8 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, X); }
        public readonly Vector3U24F8 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, Y); }
        public readonly Vector3U24F8 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, Z); }
        public readonly Vector3U24F8 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, X, W); }
        public readonly Vector3U24F8 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, X); }
        public readonly Vector3U24F8 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, Y); }
        public readonly Vector3U24F8 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, Z); }
        public readonly Vector3U24F8 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Y, W); }
        public readonly Vector3U24F8 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, X); }
        public readonly Vector3U24F8 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, Y); }
        public readonly Vector3U24F8 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, Z); }
        public readonly Vector3U24F8 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, Z, W); }
        public readonly Vector3U24F8 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, X); }
        public readonly Vector3U24F8 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, Y); }
        public readonly Vector3U24F8 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, Z); }
        public readonly Vector3U24F8 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(W, W, W); }
        public readonly Vector4U24F8 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, X); }
        public readonly Vector4U24F8 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, Y); }
        public readonly Vector4U24F8 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, Z); }
        public readonly Vector4U24F8 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, W); }
        public readonly Vector4U24F8 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, X); }
        public readonly Vector4U24F8 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, Y); }
        public readonly Vector4U24F8 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, Z); }
        public readonly Vector4U24F8 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, W); }
        public readonly Vector4U24F8 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, X); }
        public readonly Vector4U24F8 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, Y); }
        public readonly Vector4U24F8 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, Z); }
        public readonly Vector4U24F8 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Z, W); }
        public readonly Vector4U24F8 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, X); }
        public readonly Vector4U24F8 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, Y); }
        public readonly Vector4U24F8 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, Z); }
        public readonly Vector4U24F8 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, W, W); }
        public readonly Vector4U24F8 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, X); }
        public readonly Vector4U24F8 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, Y); }
        public readonly Vector4U24F8 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, Z); }
        public readonly Vector4U24F8 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, W); }
        public readonly Vector4U24F8 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, X); }
        public readonly Vector4U24F8 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, Y); }
        public readonly Vector4U24F8 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, Z); }
        public readonly Vector4U24F8 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, W); }
        public readonly Vector4U24F8 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, X); }
        public readonly Vector4U24F8 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, Y); }
        public readonly Vector4U24F8 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, Z); }
        public readonly Vector4U24F8 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Z, W); }
        public readonly Vector4U24F8 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, X); }
        public readonly Vector4U24F8 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, Y); }
        public readonly Vector4U24F8 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, Z); }
        public readonly Vector4U24F8 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, W, W); }
        public readonly Vector4U24F8 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, X); }
        public readonly Vector4U24F8 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, Y); }
        public readonly Vector4U24F8 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, Z); }
        public readonly Vector4U24F8 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, X, W); }
        public readonly Vector4U24F8 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, X); }
        public readonly Vector4U24F8 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, Y); }
        public readonly Vector4U24F8 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, Z); }
        public readonly Vector4U24F8 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Y, W); }
        public readonly Vector4U24F8 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, X); }
        public readonly Vector4U24F8 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, Y); }
        public readonly Vector4U24F8 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, Z); }
        public readonly Vector4U24F8 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, Z, W); }
        public readonly Vector4U24F8 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, X); }
        public readonly Vector4U24F8 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, Y); }
        public readonly Vector4U24F8 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, Z); }
        public readonly Vector4U24F8 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Z, W, W); }
        public readonly Vector4U24F8 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, X); }
        public readonly Vector4U24F8 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, Y); }
        public readonly Vector4U24F8 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, Z); }
        public readonly Vector4U24F8 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, X, W); }
        public readonly Vector4U24F8 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, X); }
        public readonly Vector4U24F8 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, Y); }
        public readonly Vector4U24F8 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, Z); }
        public readonly Vector4U24F8 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Y, W); }
        public readonly Vector4U24F8 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, X); }
        public readonly Vector4U24F8 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, Y); }
        public readonly Vector4U24F8 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, Z); }
        public readonly Vector4U24F8 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, Z, W); }
        public readonly Vector4U24F8 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, X); }
        public readonly Vector4U24F8 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, Y); }
        public readonly Vector4U24F8 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, Z); }
        public readonly Vector4U24F8 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, W, W, W); }
        public readonly Vector4U24F8 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, X); }
        public readonly Vector4U24F8 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, Y); }
        public readonly Vector4U24F8 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, Z); }
        public readonly Vector4U24F8 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, W); }
        public readonly Vector4U24F8 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, X); }
        public readonly Vector4U24F8 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, Y); }
        public readonly Vector4U24F8 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, Z); }
        public readonly Vector4U24F8 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, W); }
        public readonly Vector4U24F8 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, X); }
        public readonly Vector4U24F8 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, Y); }
        public readonly Vector4U24F8 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, Z); }
        public readonly Vector4U24F8 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Z, W); }
        public readonly Vector4U24F8 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, X); }
        public readonly Vector4U24F8 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, Y); }
        public readonly Vector4U24F8 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, Z); }
        public readonly Vector4U24F8 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, W, W); }
        public readonly Vector4U24F8 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, X); }
        public readonly Vector4U24F8 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, Y); }
        public readonly Vector4U24F8 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, Z); }
        public readonly Vector4U24F8 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, W); }
        public readonly Vector4U24F8 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, X); }
        public readonly Vector4U24F8 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, Y); }
        public readonly Vector4U24F8 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, Z); }
        public readonly Vector4U24F8 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, W); }
        public readonly Vector4U24F8 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, X); }
        public readonly Vector4U24F8 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, Y); }
        public readonly Vector4U24F8 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, Z); }
        public readonly Vector4U24F8 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Z, W); }
        public readonly Vector4U24F8 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, X); }
        public readonly Vector4U24F8 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, Y); }
        public readonly Vector4U24F8 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, Z); }
        public readonly Vector4U24F8 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, W, W); }
        public readonly Vector4U24F8 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, X); }
        public readonly Vector4U24F8 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, Y); }
        public readonly Vector4U24F8 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, Z); }
        public readonly Vector4U24F8 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, X, W); }
        public readonly Vector4U24F8 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, X); }
        public readonly Vector4U24F8 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, Y); }
        public readonly Vector4U24F8 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, Z); }
        public readonly Vector4U24F8 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Y, W); }
        public readonly Vector4U24F8 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, X); }
        public readonly Vector4U24F8 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, Y); }
        public readonly Vector4U24F8 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, Z); }
        public readonly Vector4U24F8 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, Z, W); }
        public readonly Vector4U24F8 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, X); }
        public readonly Vector4U24F8 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, Y); }
        public readonly Vector4U24F8 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, Z); }
        public readonly Vector4U24F8 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Z, W, W); }
        public readonly Vector4U24F8 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, X); }
        public readonly Vector4U24F8 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, Y); }
        public readonly Vector4U24F8 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, Z); }
        public readonly Vector4U24F8 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, X, W); }
        public readonly Vector4U24F8 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, X); }
        public readonly Vector4U24F8 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, Y); }
        public readonly Vector4U24F8 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, Z); }
        public readonly Vector4U24F8 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Y, W); }
        public readonly Vector4U24F8 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, X); }
        public readonly Vector4U24F8 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, Y); }
        public readonly Vector4U24F8 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, Z); }
        public readonly Vector4U24F8 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, Z, W); }
        public readonly Vector4U24F8 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, X); }
        public readonly Vector4U24F8 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, Y); }
        public readonly Vector4U24F8 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, Z); }
        public readonly Vector4U24F8 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, W, W, W); }
        public readonly Vector4U24F8 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, X); }
        public readonly Vector4U24F8 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, Y); }
        public readonly Vector4U24F8 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, Z); }
        public readonly Vector4U24F8 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, X, W); }
        public readonly Vector4U24F8 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, X); }
        public readonly Vector4U24F8 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, Y); }
        public readonly Vector4U24F8 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, Z); }
        public readonly Vector4U24F8 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Y, W); }
        public readonly Vector4U24F8 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, X); }
        public readonly Vector4U24F8 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, Y); }
        public readonly Vector4U24F8 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, Z); }
        public readonly Vector4U24F8 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, Z, W); }
        public readonly Vector4U24F8 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, X); }
        public readonly Vector4U24F8 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, Y); }
        public readonly Vector4U24F8 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, Z); }
        public readonly Vector4U24F8 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, X, W, W); }
        public readonly Vector4U24F8 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, X); }
        public readonly Vector4U24F8 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, Y); }
        public readonly Vector4U24F8 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, Z); }
        public readonly Vector4U24F8 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, X, W); }
        public readonly Vector4U24F8 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, X); }
        public readonly Vector4U24F8 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, Y); }
        public readonly Vector4U24F8 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, Z); }
        public readonly Vector4U24F8 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Y, W); }
        public readonly Vector4U24F8 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, X); }
        public readonly Vector4U24F8 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, Y); }
        public readonly Vector4U24F8 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, Z); }
        public readonly Vector4U24F8 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, Z, W); }
        public readonly Vector4U24F8 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, X); }
        public readonly Vector4U24F8 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, Y); }
        public readonly Vector4U24F8 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, Z); }
        public readonly Vector4U24F8 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Y, W, W); }
        public readonly Vector4U24F8 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, X); }
        public readonly Vector4U24F8 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, Y); }
        public readonly Vector4U24F8 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, Z); }
        public readonly Vector4U24F8 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, X, W); }
        public readonly Vector4U24F8 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, X); }
        public readonly Vector4U24F8 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, Y); }
        public readonly Vector4U24F8 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, Z); }
        public readonly Vector4U24F8 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Y, W); }
        public readonly Vector4U24F8 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, X); }
        public readonly Vector4U24F8 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, Y); }
        public readonly Vector4U24F8 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, Z); }
        public readonly Vector4U24F8 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, Z, W); }
        public readonly Vector4U24F8 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, X); }
        public readonly Vector4U24F8 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, Y); }
        public readonly Vector4U24F8 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, Z); }
        public readonly Vector4U24F8 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, Z, W, W); }
        public readonly Vector4U24F8 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, X); }
        public readonly Vector4U24F8 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, Y); }
        public readonly Vector4U24F8 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, Z); }
        public readonly Vector4U24F8 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, X, W); }
        public readonly Vector4U24F8 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, X); }
        public readonly Vector4U24F8 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, Y); }
        public readonly Vector4U24F8 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, Z); }
        public readonly Vector4U24F8 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Y, W); }
        public readonly Vector4U24F8 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, X); }
        public readonly Vector4U24F8 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, Y); }
        public readonly Vector4U24F8 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, Z); }
        public readonly Vector4U24F8 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, Z, W); }
        public readonly Vector4U24F8 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, X); }
        public readonly Vector4U24F8 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, Y); }
        public readonly Vector4U24F8 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, Z); }
        public readonly Vector4U24F8 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Z, W, W, W); }
        public readonly Vector4U24F8 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, X); }
        public readonly Vector4U24F8 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, Y); }
        public readonly Vector4U24F8 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, Z); }
        public readonly Vector4U24F8 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, X, W); }
        public readonly Vector4U24F8 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, X); }
        public readonly Vector4U24F8 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, Y); }
        public readonly Vector4U24F8 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, Z); }
        public readonly Vector4U24F8 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Y, W); }
        public readonly Vector4U24F8 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, X); }
        public readonly Vector4U24F8 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, Y); }
        public readonly Vector4U24F8 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, Z); }
        public readonly Vector4U24F8 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, Z, W); }
        public readonly Vector4U24F8 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, X); }
        public readonly Vector4U24F8 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, Y); }
        public readonly Vector4U24F8 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, Z); }
        public readonly Vector4U24F8 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, X, W, W); }
        public readonly Vector4U24F8 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, X); }
        public readonly Vector4U24F8 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, Y); }
        public readonly Vector4U24F8 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, Z); }
        public readonly Vector4U24F8 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, X, W); }
        public readonly Vector4U24F8 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, X); }
        public readonly Vector4U24F8 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, Y); }
        public readonly Vector4U24F8 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, Z); }
        public readonly Vector4U24F8 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Y, W); }
        public readonly Vector4U24F8 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, X); }
        public readonly Vector4U24F8 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, Y); }
        public readonly Vector4U24F8 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, Z); }
        public readonly Vector4U24F8 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, Z, W); }
        public readonly Vector4U24F8 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, X); }
        public readonly Vector4U24F8 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, Y); }
        public readonly Vector4U24F8 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, Z); }
        public readonly Vector4U24F8 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Y, W, W); }
        public readonly Vector4U24F8 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, X); }
        public readonly Vector4U24F8 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, Y); }
        public readonly Vector4U24F8 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, Z); }
        public readonly Vector4U24F8 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, X, W); }
        public readonly Vector4U24F8 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, X); }
        public readonly Vector4U24F8 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, Y); }
        public readonly Vector4U24F8 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, Z); }
        public readonly Vector4U24F8 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Y, W); }
        public readonly Vector4U24F8 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, X); }
        public readonly Vector4U24F8 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, Y); }
        public readonly Vector4U24F8 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, Z); }
        public readonly Vector4U24F8 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, Z, W); }
        public readonly Vector4U24F8 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, X); }
        public readonly Vector4U24F8 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, Y); }
        public readonly Vector4U24F8 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, Z); }
        public readonly Vector4U24F8 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, Z, W, W); }
        public readonly Vector4U24F8 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, X); }
        public readonly Vector4U24F8 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, Y); }
        public readonly Vector4U24F8 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, Z); }
        public readonly Vector4U24F8 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, X, W); }
        public readonly Vector4U24F8 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, X); }
        public readonly Vector4U24F8 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, Y); }
        public readonly Vector4U24F8 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, Z); }
        public readonly Vector4U24F8 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Y, W); }
        public readonly Vector4U24F8 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, X); }
        public readonly Vector4U24F8 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, Y); }
        public readonly Vector4U24F8 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, Z); }
        public readonly Vector4U24F8 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, Z, W); }
        public readonly Vector4U24F8 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, X); }
        public readonly Vector4U24F8 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, Y); }
        public readonly Vector4U24F8 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, Z); }
        public readonly Vector4U24F8 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U24F8 other)
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

        public readonly Vector4U24F8 Half() => new Vector4U24F8(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4U24F8 Twice() => new Vector4U24F8(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4U24F8 Clamp(U24F8 min, U24F8 max) => new Vector4U24F8(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4U24F8 Clamp(
            Vector4U24F8 min, Vector4U24F8 max
        ) => new Vector4U24F8(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U24F8 SaturatingAdd(Vector4U24F8 other) => new Vector4U24F8(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U24F8 SaturatingMul(U24F8 other) => new Vector4U24F8(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U50F14 Dot(Vector4U24F8 other) {
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
            return U50F14.FromBits(bits);
        }

    }

    partial struct U24F8 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U24F8 SaturatingMul(Vector4U24F8 other) => other.SaturatingMul(this);
    }
}
