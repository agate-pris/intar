using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U17F15 : IEquatable<Vector4U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;
        public U17F15 Z;
        public U17F15 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, U17F15 y, U17F15 z, U17F15 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, U17F15 y, Vector2U17F15 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, Vector3U17F15 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector2U17F15 xy, Vector2U17F15 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector4U17F15 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(U17F15 x, Vector2U17F15 yz, U17F15 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector3U17F15 xyz, U17F15 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15(Vector2U17F15 xy, U17F15 z, U17F15 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.Zero);
        }
        public static Vector4U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.One);
        }
        public static Vector4U17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.One, U17F15.Zero, U17F15.Zero, U17F15.Zero);
        }
        public static Vector4U17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.Zero, U17F15.One, U17F15.Zero, U17F15.Zero);
        }
        public static Vector4U17F15 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.Zero, U17F15.Zero, U17F15.One, U17F15.Zero);
        }
        public static Vector4U17F15 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U17F15(U17F15.Zero, U17F15.Zero, U17F15.Zero, U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator +(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator -(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(Vector4U17F15 a, U17F15 b) => new Vector4U17F15(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator *(U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(Vector4U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(Vector4U17F15 a, U17F15 b) => new Vector4U17F15(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 operator /(U17F15 a, Vector4U17F15 b) => new Vector4U17F15(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U17F15 lhs, Vector4U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U17F15 lhs, Vector4U17F15 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public readonly Vector2U17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public readonly Vector2U17F15 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Z); }
        public readonly Vector2U17F15 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, W); }
        public readonly Vector2U17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public readonly Vector2U17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public readonly Vector2U17F15 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Z); }
        public readonly Vector2U17F15 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, W); }
        public readonly Vector2U17F15 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, X); }
        public readonly Vector2U17F15 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Y); }
        public readonly Vector2U17F15 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, Z); }
        public readonly Vector2U17F15 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Z, W); }
        public readonly Vector2U17F15 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(W, X); }
        public readonly Vector2U17F15 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(W, Y); }
        public readonly Vector2U17F15 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(W, Z); }
        public readonly Vector2U17F15 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(W, W); }
        public readonly Vector3U17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public readonly Vector3U17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public readonly Vector3U17F15 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Z); }
        public readonly Vector3U17F15 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, W); }
        public readonly Vector3U17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public readonly Vector3U17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public readonly Vector3U17F15 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Z); }
        public readonly Vector3U17F15 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, W); }
        public readonly Vector3U17F15 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, X); }
        public readonly Vector3U17F15 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Y); }
        public readonly Vector3U17F15 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, Z); }
        public readonly Vector3U17F15 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Z, W); }
        public readonly Vector3U17F15 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, W, X); }
        public readonly Vector3U17F15 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, W, Y); }
        public readonly Vector3U17F15 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, W, Z); }
        public readonly Vector3U17F15 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, W, W); }
        public readonly Vector3U17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public readonly Vector3U17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public readonly Vector3U17F15 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Z); }
        public readonly Vector3U17F15 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, W); }
        public readonly Vector3U17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public readonly Vector3U17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public readonly Vector3U17F15 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Z); }
        public readonly Vector3U17F15 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, W); }
        public readonly Vector3U17F15 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, X); }
        public readonly Vector3U17F15 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Y); }
        public readonly Vector3U17F15 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, Z); }
        public readonly Vector3U17F15 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Z, W); }
        public readonly Vector3U17F15 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, W, X); }
        public readonly Vector3U17F15 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, W, Y); }
        public readonly Vector3U17F15 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, W, Z); }
        public readonly Vector3U17F15 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, W, W); }
        public readonly Vector3U17F15 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, X); }
        public readonly Vector3U17F15 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Y); }
        public readonly Vector3U17F15 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, Z); }
        public readonly Vector3U17F15 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, X, W); }
        public readonly Vector3U17F15 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, X); }
        public readonly Vector3U17F15 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Y); }
        public readonly Vector3U17F15 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, Z); }
        public readonly Vector3U17F15 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Y, W); }
        public readonly Vector3U17F15 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, X); }
        public readonly Vector3U17F15 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Y); }
        public readonly Vector3U17F15 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, Z); }
        public readonly Vector3U17F15 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, Z, W); }
        public readonly Vector3U17F15 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, W, X); }
        public readonly Vector3U17F15 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, W, Y); }
        public readonly Vector3U17F15 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, W, Z); }
        public readonly Vector3U17F15 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Z, W, W); }
        public readonly Vector3U17F15 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, X, X); }
        public readonly Vector3U17F15 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, X, Y); }
        public readonly Vector3U17F15 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, X, Z); }
        public readonly Vector3U17F15 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, X, W); }
        public readonly Vector3U17F15 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Y, X); }
        public readonly Vector3U17F15 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Y, Y); }
        public readonly Vector3U17F15 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Y, Z); }
        public readonly Vector3U17F15 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Y, W); }
        public readonly Vector3U17F15 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Z, X); }
        public readonly Vector3U17F15 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Z, Y); }
        public readonly Vector3U17F15 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Z, Z); }
        public readonly Vector3U17F15 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, Z, W); }
        public readonly Vector3U17F15 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, W, X); }
        public readonly Vector3U17F15 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, W, Y); }
        public readonly Vector3U17F15 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, W, Z); }
        public readonly Vector3U17F15 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(W, W, W); }
        public readonly Vector4U17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public readonly Vector4U17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public readonly Vector4U17F15 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Z); }
        public readonly Vector4U17F15 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, W); }
        public readonly Vector4U17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public readonly Vector4U17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public readonly Vector4U17F15 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Z); }
        public readonly Vector4U17F15 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, W); }
        public readonly Vector4U17F15 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, X); }
        public readonly Vector4U17F15 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Y); }
        public readonly Vector4U17F15 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, Z); }
        public readonly Vector4U17F15 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Z, W); }
        public readonly Vector4U17F15 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, W, X); }
        public readonly Vector4U17F15 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, W, Y); }
        public readonly Vector4U17F15 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, W, Z); }
        public readonly Vector4U17F15 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, W, W); }
        public readonly Vector4U17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public readonly Vector4U17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public readonly Vector4U17F15 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Z); }
        public readonly Vector4U17F15 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, W); }
        public readonly Vector4U17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public readonly Vector4U17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public readonly Vector4U17F15 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Z); }
        public readonly Vector4U17F15 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, W); }
        public readonly Vector4U17F15 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, X); }
        public readonly Vector4U17F15 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Y); }
        public readonly Vector4U17F15 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, Z); }
        public readonly Vector4U17F15 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Z, W); }
        public readonly Vector4U17F15 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, W, X); }
        public readonly Vector4U17F15 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, W, Y); }
        public readonly Vector4U17F15 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, W, Z); }
        public readonly Vector4U17F15 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, W, W); }
        public readonly Vector4U17F15 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, X); }
        public readonly Vector4U17F15 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Y); }
        public readonly Vector4U17F15 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, Z); }
        public readonly Vector4U17F15 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, X, W); }
        public readonly Vector4U17F15 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, X); }
        public readonly Vector4U17F15 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Y); }
        public readonly Vector4U17F15 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, Z); }
        public readonly Vector4U17F15 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Y, W); }
        public readonly Vector4U17F15 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, X); }
        public readonly Vector4U17F15 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Y); }
        public readonly Vector4U17F15 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, Z); }
        public readonly Vector4U17F15 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, Z, W); }
        public readonly Vector4U17F15 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, W, X); }
        public readonly Vector4U17F15 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, W, Y); }
        public readonly Vector4U17F15 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, W, Z); }
        public readonly Vector4U17F15 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Z, W, W); }
        public readonly Vector4U17F15 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, X, X); }
        public readonly Vector4U17F15 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, X, Y); }
        public readonly Vector4U17F15 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, X, Z); }
        public readonly Vector4U17F15 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, X, W); }
        public readonly Vector4U17F15 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Y, X); }
        public readonly Vector4U17F15 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Y, Y); }
        public readonly Vector4U17F15 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Y, Z); }
        public readonly Vector4U17F15 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Y, W); }
        public readonly Vector4U17F15 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Z, X); }
        public readonly Vector4U17F15 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Z, Y); }
        public readonly Vector4U17F15 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Z, Z); }
        public readonly Vector4U17F15 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, Z, W); }
        public readonly Vector4U17F15 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, W, X); }
        public readonly Vector4U17F15 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, W, Y); }
        public readonly Vector4U17F15 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, W, Z); }
        public readonly Vector4U17F15 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, W, W, W); }
        public readonly Vector4U17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public readonly Vector4U17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public readonly Vector4U17F15 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Z); }
        public readonly Vector4U17F15 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, W); }
        public readonly Vector4U17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public readonly Vector4U17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public readonly Vector4U17F15 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Z); }
        public readonly Vector4U17F15 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, W); }
        public readonly Vector4U17F15 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, X); }
        public readonly Vector4U17F15 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Y); }
        public readonly Vector4U17F15 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, Z); }
        public readonly Vector4U17F15 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Z, W); }
        public readonly Vector4U17F15 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, W, X); }
        public readonly Vector4U17F15 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, W, Y); }
        public readonly Vector4U17F15 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, W, Z); }
        public readonly Vector4U17F15 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, W, W); }
        public readonly Vector4U17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public readonly Vector4U17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public readonly Vector4U17F15 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Z); }
        public readonly Vector4U17F15 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, W); }
        public readonly Vector4U17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public readonly Vector4U17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }
        public readonly Vector4U17F15 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Z); }
        public readonly Vector4U17F15 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, W); }
        public readonly Vector4U17F15 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, X); }
        public readonly Vector4U17F15 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Y); }
        public readonly Vector4U17F15 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, Z); }
        public readonly Vector4U17F15 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Z, W); }
        public readonly Vector4U17F15 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, W, X); }
        public readonly Vector4U17F15 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, W, Y); }
        public readonly Vector4U17F15 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, W, Z); }
        public readonly Vector4U17F15 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, W, W); }
        public readonly Vector4U17F15 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, X); }
        public readonly Vector4U17F15 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Y); }
        public readonly Vector4U17F15 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, Z); }
        public readonly Vector4U17F15 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, X, W); }
        public readonly Vector4U17F15 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, X); }
        public readonly Vector4U17F15 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Y); }
        public readonly Vector4U17F15 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, Z); }
        public readonly Vector4U17F15 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Y, W); }
        public readonly Vector4U17F15 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, X); }
        public readonly Vector4U17F15 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Y); }
        public readonly Vector4U17F15 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, Z); }
        public readonly Vector4U17F15 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, Z, W); }
        public readonly Vector4U17F15 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, W, X); }
        public readonly Vector4U17F15 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, W, Y); }
        public readonly Vector4U17F15 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, W, Z); }
        public readonly Vector4U17F15 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Z, W, W); }
        public readonly Vector4U17F15 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, X, X); }
        public readonly Vector4U17F15 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, X, Y); }
        public readonly Vector4U17F15 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, X, Z); }
        public readonly Vector4U17F15 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, X, W); }
        public readonly Vector4U17F15 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Y, X); }
        public readonly Vector4U17F15 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Y, Y); }
        public readonly Vector4U17F15 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Y, Z); }
        public readonly Vector4U17F15 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Y, W); }
        public readonly Vector4U17F15 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Z, X); }
        public readonly Vector4U17F15 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Z, Y); }
        public readonly Vector4U17F15 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Z, Z); }
        public readonly Vector4U17F15 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, Z, W); }
        public readonly Vector4U17F15 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, W, X); }
        public readonly Vector4U17F15 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, W, Y); }
        public readonly Vector4U17F15 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, W, Z); }
        public readonly Vector4U17F15 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, W, W, W); }
        public readonly Vector4U17F15 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, X); }
        public readonly Vector4U17F15 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Y); }
        public readonly Vector4U17F15 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, Z); }
        public readonly Vector4U17F15 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, X, W); }
        public readonly Vector4U17F15 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, X); }
        public readonly Vector4U17F15 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Y); }
        public readonly Vector4U17F15 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, Z); }
        public readonly Vector4U17F15 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Y, W); }
        public readonly Vector4U17F15 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, X); }
        public readonly Vector4U17F15 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Y); }
        public readonly Vector4U17F15 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, Z); }
        public readonly Vector4U17F15 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, Z, W); }
        public readonly Vector4U17F15 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, W, X); }
        public readonly Vector4U17F15 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, W, Y); }
        public readonly Vector4U17F15 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, W, Z); }
        public readonly Vector4U17F15 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, X, W, W); }
        public readonly Vector4U17F15 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, X); }
        public readonly Vector4U17F15 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Y); }
        public readonly Vector4U17F15 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, Z); }
        public readonly Vector4U17F15 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, X, W); }
        public readonly Vector4U17F15 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, X); }
        public readonly Vector4U17F15 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Y); }
        public readonly Vector4U17F15 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, Z); }
        public readonly Vector4U17F15 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Y, W); }
        public readonly Vector4U17F15 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, X); }
        public readonly Vector4U17F15 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Y); }
        public readonly Vector4U17F15 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, Z); }
        public readonly Vector4U17F15 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, Z, W); }
        public readonly Vector4U17F15 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, W, X); }
        public readonly Vector4U17F15 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, W, Y); }
        public readonly Vector4U17F15 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, W, Z); }
        public readonly Vector4U17F15 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Y, W, W); }
        public readonly Vector4U17F15 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, X); }
        public readonly Vector4U17F15 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Y); }
        public readonly Vector4U17F15 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, Z); }
        public readonly Vector4U17F15 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, X, W); }
        public readonly Vector4U17F15 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, X); }
        public readonly Vector4U17F15 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Y); }
        public readonly Vector4U17F15 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, Z); }
        public readonly Vector4U17F15 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Y, W); }
        public readonly Vector4U17F15 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, X); }
        public readonly Vector4U17F15 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Y); }
        public readonly Vector4U17F15 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, Z); }
        public readonly Vector4U17F15 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, Z, W); }
        public readonly Vector4U17F15 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, W, X); }
        public readonly Vector4U17F15 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, W, Y); }
        public readonly Vector4U17F15 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, W, Z); }
        public readonly Vector4U17F15 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, Z, W, W); }
        public readonly Vector4U17F15 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, X, X); }
        public readonly Vector4U17F15 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, X, Y); }
        public readonly Vector4U17F15 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, X, Z); }
        public readonly Vector4U17F15 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, X, W); }
        public readonly Vector4U17F15 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Y, X); }
        public readonly Vector4U17F15 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Y, Y); }
        public readonly Vector4U17F15 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Y, Z); }
        public readonly Vector4U17F15 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Y, W); }
        public readonly Vector4U17F15 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Z, X); }
        public readonly Vector4U17F15 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Z, Y); }
        public readonly Vector4U17F15 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Z, Z); }
        public readonly Vector4U17F15 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, Z, W); }
        public readonly Vector4U17F15 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, W, X); }
        public readonly Vector4U17F15 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, W, Y); }
        public readonly Vector4U17F15 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, W, Z); }
        public readonly Vector4U17F15 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Z, W, W, W); }
        public readonly Vector4U17F15 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, X, X); }
        public readonly Vector4U17F15 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, X, Y); }
        public readonly Vector4U17F15 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, X, Z); }
        public readonly Vector4U17F15 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, X, W); }
        public readonly Vector4U17F15 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Y, X); }
        public readonly Vector4U17F15 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Y, Y); }
        public readonly Vector4U17F15 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Y, Z); }
        public readonly Vector4U17F15 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Y, W); }
        public readonly Vector4U17F15 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Z, X); }
        public readonly Vector4U17F15 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Z, Y); }
        public readonly Vector4U17F15 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Z, Z); }
        public readonly Vector4U17F15 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, Z, W); }
        public readonly Vector4U17F15 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, W, X); }
        public readonly Vector4U17F15 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, W, Y); }
        public readonly Vector4U17F15 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, W, Z); }
        public readonly Vector4U17F15 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, X, W, W); }
        public readonly Vector4U17F15 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, X, X); }
        public readonly Vector4U17F15 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, X, Y); }
        public readonly Vector4U17F15 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, X, Z); }
        public readonly Vector4U17F15 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, X, W); }
        public readonly Vector4U17F15 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Y, X); }
        public readonly Vector4U17F15 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Y, Y); }
        public readonly Vector4U17F15 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Y, Z); }
        public readonly Vector4U17F15 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Y, W); }
        public readonly Vector4U17F15 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Z, X); }
        public readonly Vector4U17F15 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Z, Y); }
        public readonly Vector4U17F15 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Z, Z); }
        public readonly Vector4U17F15 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, Z, W); }
        public readonly Vector4U17F15 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, W, X); }
        public readonly Vector4U17F15 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, W, Y); }
        public readonly Vector4U17F15 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, W, Z); }
        public readonly Vector4U17F15 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Y, W, W); }
        public readonly Vector4U17F15 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, X, X); }
        public readonly Vector4U17F15 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, X, Y); }
        public readonly Vector4U17F15 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, X, Z); }
        public readonly Vector4U17F15 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, X, W); }
        public readonly Vector4U17F15 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Y, X); }
        public readonly Vector4U17F15 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Y, Y); }
        public readonly Vector4U17F15 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Y, Z); }
        public readonly Vector4U17F15 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Y, W); }
        public readonly Vector4U17F15 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Z, X); }
        public readonly Vector4U17F15 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Z, Y); }
        public readonly Vector4U17F15 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Z, Z); }
        public readonly Vector4U17F15 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, Z, W); }
        public readonly Vector4U17F15 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, W, X); }
        public readonly Vector4U17F15 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, W, Y); }
        public readonly Vector4U17F15 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, W, Z); }
        public readonly Vector4U17F15 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, Z, W, W); }
        public readonly Vector4U17F15 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, X, X); }
        public readonly Vector4U17F15 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, X, Y); }
        public readonly Vector4U17F15 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, X, Z); }
        public readonly Vector4U17F15 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, X, W); }
        public readonly Vector4U17F15 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Y, X); }
        public readonly Vector4U17F15 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Y, Y); }
        public readonly Vector4U17F15 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Y, Z); }
        public readonly Vector4U17F15 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Y, W); }
        public readonly Vector4U17F15 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Z, X); }
        public readonly Vector4U17F15 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Z, Y); }
        public readonly Vector4U17F15 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Z, Z); }
        public readonly Vector4U17F15 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, Z, W); }
        public readonly Vector4U17F15 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, W, X); }
        public readonly Vector4U17F15 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, W, Y); }
        public readonly Vector4U17F15 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, W, Z); }
        public readonly Vector4U17F15 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U17F15 other)
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

        public readonly Vector4U17F15 Half() => new Vector4U17F15(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4U17F15 Twice() => new Vector4U17F15(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4U17F15 Clamp(U17F15 min, U17F15 max) => new Vector4U17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4U17F15 Clamp(
            Vector4U17F15 min, Vector4U17F15 max
        ) => new Vector4U17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U17F15 SaturatingAdd(Vector4U17F15 other) => new Vector4U17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U17F15 SaturatingMul(U17F15 other) => new Vector4U17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

    }

    partial struct U17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U17F15 SaturatingMul(Vector4U17F15 other) => other.SaturatingMul(this);
    }
}
