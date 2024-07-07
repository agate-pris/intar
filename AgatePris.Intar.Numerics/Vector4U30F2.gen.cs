using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U30F2 : IEquatable<Vector4U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U30F2 X;
        public U30F2 Y;
        public U30F2 Z;
        public U30F2 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, U30F2 z, U30F2 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, U30F2 y, Vector2U30F2 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector3U30F2 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, Vector2U30F2 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector4U30F2 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(U30F2 x, Vector2U30F2 yz, U30F2 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector3U30F2 xyz, U30F2 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2(Vector2U30F2 xy, U30F2 z, U30F2 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero);
        }
        public static Vector4U30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.One);
        }
        public static Vector4U30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.One, U30F2.Zero, U30F2.Zero, U30F2.Zero);
        }
        public static Vector4U30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.One, U30F2.Zero, U30F2.Zero);
        }
        public static Vector4U30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.Zero, U30F2.One, U30F2.Zero);
        }
        public static Vector4U30F2 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U30F2(U30F2.Zero, U30F2.Zero, U30F2.Zero, U30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator +(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator -(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator *(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(Vector4U30F2 a, U30F2 b) => new Vector4U30F2(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 operator /(U30F2 a, Vector4U30F2 b) => new Vector4U30F2(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U30F2 lhs, Vector4U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U30F2 lhs, Vector4U30F2 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U30F2 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, X); }
        public readonly Vector2U30F2 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Y); }
        public readonly Vector2U30F2 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Z); }
        public readonly Vector2U30F2 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, W); }
        public readonly Vector2U30F2 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, X); }
        public readonly Vector2U30F2 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Y); }
        public readonly Vector2U30F2 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Z); }
        public readonly Vector2U30F2 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, W); }
        public readonly Vector2U30F2 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, X); }
        public readonly Vector2U30F2 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Y); }
        public readonly Vector2U30F2 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, Z); }
        public readonly Vector2U30F2 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Z, W); }
        public readonly Vector2U30F2 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, X); }
        public readonly Vector2U30F2 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, Y); }
        public readonly Vector2U30F2 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, Z); }
        public readonly Vector2U30F2 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(W, W); }
        public readonly Vector3U30F2 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, X); }
        public readonly Vector3U30F2 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Y); }
        public readonly Vector3U30F2 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Z); }
        public readonly Vector3U30F2 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, W); }
        public readonly Vector3U30F2 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, X); }
        public readonly Vector3U30F2 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Y); }
        public readonly Vector3U30F2 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Z); }
        public readonly Vector3U30F2 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, W); }
        public readonly Vector3U30F2 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, X); }
        public readonly Vector3U30F2 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Y); }
        public readonly Vector3U30F2 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, Z); }
        public readonly Vector3U30F2 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Z, W); }
        public readonly Vector3U30F2 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, X); }
        public readonly Vector3U30F2 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, Y); }
        public readonly Vector3U30F2 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, Z); }
        public readonly Vector3U30F2 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, W, W); }
        public readonly Vector3U30F2 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, X); }
        public readonly Vector3U30F2 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Y); }
        public readonly Vector3U30F2 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Z); }
        public readonly Vector3U30F2 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, W); }
        public readonly Vector3U30F2 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, X); }
        public readonly Vector3U30F2 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Y); }
        public readonly Vector3U30F2 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Z); }
        public readonly Vector3U30F2 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, W); }
        public readonly Vector3U30F2 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, X); }
        public readonly Vector3U30F2 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Y); }
        public readonly Vector3U30F2 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, Z); }
        public readonly Vector3U30F2 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Z, W); }
        public readonly Vector3U30F2 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, X); }
        public readonly Vector3U30F2 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, Y); }
        public readonly Vector3U30F2 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, Z); }
        public readonly Vector3U30F2 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, W, W); }
        public readonly Vector3U30F2 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, X); }
        public readonly Vector3U30F2 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Y); }
        public readonly Vector3U30F2 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, Z); }
        public readonly Vector3U30F2 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, X, W); }
        public readonly Vector3U30F2 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, X); }
        public readonly Vector3U30F2 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Y); }
        public readonly Vector3U30F2 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, Z); }
        public readonly Vector3U30F2 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Y, W); }
        public readonly Vector3U30F2 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, X); }
        public readonly Vector3U30F2 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Y); }
        public readonly Vector3U30F2 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, Z); }
        public readonly Vector3U30F2 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, Z, W); }
        public readonly Vector3U30F2 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, X); }
        public readonly Vector3U30F2 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, Y); }
        public readonly Vector3U30F2 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, Z); }
        public readonly Vector3U30F2 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Z, W, W); }
        public readonly Vector3U30F2 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, X); }
        public readonly Vector3U30F2 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, Y); }
        public readonly Vector3U30F2 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, Z); }
        public readonly Vector3U30F2 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, X, W); }
        public readonly Vector3U30F2 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, X); }
        public readonly Vector3U30F2 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, Y); }
        public readonly Vector3U30F2 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, Z); }
        public readonly Vector3U30F2 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Y, W); }
        public readonly Vector3U30F2 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, X); }
        public readonly Vector3U30F2 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, Y); }
        public readonly Vector3U30F2 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, Z); }
        public readonly Vector3U30F2 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, Z, W); }
        public readonly Vector3U30F2 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, X); }
        public readonly Vector3U30F2 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, Y); }
        public readonly Vector3U30F2 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, Z); }
        public readonly Vector3U30F2 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(W, W, W); }
        public readonly Vector4U30F2 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, X); }
        public readonly Vector4U30F2 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Y); }
        public readonly Vector4U30F2 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Z); }
        public readonly Vector4U30F2 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, W); }
        public readonly Vector4U30F2 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, X); }
        public readonly Vector4U30F2 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Y); }
        public readonly Vector4U30F2 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Z); }
        public readonly Vector4U30F2 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, W); }
        public readonly Vector4U30F2 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, X); }
        public readonly Vector4U30F2 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Y); }
        public readonly Vector4U30F2 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, Z); }
        public readonly Vector4U30F2 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Z, W); }
        public readonly Vector4U30F2 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, X); }
        public readonly Vector4U30F2 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, Y); }
        public readonly Vector4U30F2 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, Z); }
        public readonly Vector4U30F2 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, W, W); }
        public readonly Vector4U30F2 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, X); }
        public readonly Vector4U30F2 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Y); }
        public readonly Vector4U30F2 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Z); }
        public readonly Vector4U30F2 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, W); }
        public readonly Vector4U30F2 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, X); }
        public readonly Vector4U30F2 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Y); }
        public readonly Vector4U30F2 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Z); }
        public readonly Vector4U30F2 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, W); }
        public readonly Vector4U30F2 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, X); }
        public readonly Vector4U30F2 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Y); }
        public readonly Vector4U30F2 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, Z); }
        public readonly Vector4U30F2 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Z, W); }
        public readonly Vector4U30F2 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, X); }
        public readonly Vector4U30F2 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, Y); }
        public readonly Vector4U30F2 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, Z); }
        public readonly Vector4U30F2 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, W, W); }
        public readonly Vector4U30F2 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, X); }
        public readonly Vector4U30F2 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Y); }
        public readonly Vector4U30F2 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, Z); }
        public readonly Vector4U30F2 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, X, W); }
        public readonly Vector4U30F2 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, X); }
        public readonly Vector4U30F2 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Y); }
        public readonly Vector4U30F2 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, Z); }
        public readonly Vector4U30F2 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Y, W); }
        public readonly Vector4U30F2 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, X); }
        public readonly Vector4U30F2 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Y); }
        public readonly Vector4U30F2 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, Z); }
        public readonly Vector4U30F2 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, Z, W); }
        public readonly Vector4U30F2 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, X); }
        public readonly Vector4U30F2 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, Y); }
        public readonly Vector4U30F2 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, Z); }
        public readonly Vector4U30F2 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Z, W, W); }
        public readonly Vector4U30F2 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, X); }
        public readonly Vector4U30F2 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, Y); }
        public readonly Vector4U30F2 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, Z); }
        public readonly Vector4U30F2 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, X, W); }
        public readonly Vector4U30F2 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, X); }
        public readonly Vector4U30F2 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, Y); }
        public readonly Vector4U30F2 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, Z); }
        public readonly Vector4U30F2 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Y, W); }
        public readonly Vector4U30F2 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, X); }
        public readonly Vector4U30F2 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, Y); }
        public readonly Vector4U30F2 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, Z); }
        public readonly Vector4U30F2 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, Z, W); }
        public readonly Vector4U30F2 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, X); }
        public readonly Vector4U30F2 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, Y); }
        public readonly Vector4U30F2 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, Z); }
        public readonly Vector4U30F2 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, W, W, W); }
        public readonly Vector4U30F2 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, X); }
        public readonly Vector4U30F2 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Y); }
        public readonly Vector4U30F2 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Z); }
        public readonly Vector4U30F2 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, W); }
        public readonly Vector4U30F2 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, X); }
        public readonly Vector4U30F2 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Y); }
        public readonly Vector4U30F2 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Z); }
        public readonly Vector4U30F2 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, W); }
        public readonly Vector4U30F2 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, X); }
        public readonly Vector4U30F2 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Y); }
        public readonly Vector4U30F2 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, Z); }
        public readonly Vector4U30F2 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Z, W); }
        public readonly Vector4U30F2 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, X); }
        public readonly Vector4U30F2 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, Y); }
        public readonly Vector4U30F2 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, Z); }
        public readonly Vector4U30F2 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, W, W); }
        public readonly Vector4U30F2 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, X); }
        public readonly Vector4U30F2 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Y); }
        public readonly Vector4U30F2 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Z); }
        public readonly Vector4U30F2 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, W); }
        public readonly Vector4U30F2 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, X); }
        public readonly Vector4U30F2 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Y); }
        public readonly Vector4U30F2 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Z); }
        public readonly Vector4U30F2 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, W); }
        public readonly Vector4U30F2 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, X); }
        public readonly Vector4U30F2 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Y); }
        public readonly Vector4U30F2 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, Z); }
        public readonly Vector4U30F2 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Z, W); }
        public readonly Vector4U30F2 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, X); }
        public readonly Vector4U30F2 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, Y); }
        public readonly Vector4U30F2 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, Z); }
        public readonly Vector4U30F2 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, W, W); }
        public readonly Vector4U30F2 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, X); }
        public readonly Vector4U30F2 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Y); }
        public readonly Vector4U30F2 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, Z); }
        public readonly Vector4U30F2 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, X, W); }
        public readonly Vector4U30F2 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, X); }
        public readonly Vector4U30F2 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Y); }
        public readonly Vector4U30F2 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, Z); }
        public readonly Vector4U30F2 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Y, W); }
        public readonly Vector4U30F2 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, X); }
        public readonly Vector4U30F2 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Y); }
        public readonly Vector4U30F2 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, Z); }
        public readonly Vector4U30F2 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, Z, W); }
        public readonly Vector4U30F2 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, X); }
        public readonly Vector4U30F2 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, Y); }
        public readonly Vector4U30F2 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, Z); }
        public readonly Vector4U30F2 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Z, W, W); }
        public readonly Vector4U30F2 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, X); }
        public readonly Vector4U30F2 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, Y); }
        public readonly Vector4U30F2 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, Z); }
        public readonly Vector4U30F2 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, X, W); }
        public readonly Vector4U30F2 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, X); }
        public readonly Vector4U30F2 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, Y); }
        public readonly Vector4U30F2 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, Z); }
        public readonly Vector4U30F2 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Y, W); }
        public readonly Vector4U30F2 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, X); }
        public readonly Vector4U30F2 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, Y); }
        public readonly Vector4U30F2 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, Z); }
        public readonly Vector4U30F2 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, Z, W); }
        public readonly Vector4U30F2 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, X); }
        public readonly Vector4U30F2 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, Y); }
        public readonly Vector4U30F2 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, Z); }
        public readonly Vector4U30F2 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, W, W, W); }
        public readonly Vector4U30F2 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, X); }
        public readonly Vector4U30F2 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Y); }
        public readonly Vector4U30F2 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, Z); }
        public readonly Vector4U30F2 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, X, W); }
        public readonly Vector4U30F2 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, X); }
        public readonly Vector4U30F2 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Y); }
        public readonly Vector4U30F2 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, Z); }
        public readonly Vector4U30F2 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Y, W); }
        public readonly Vector4U30F2 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, X); }
        public readonly Vector4U30F2 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Y); }
        public readonly Vector4U30F2 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, Z); }
        public readonly Vector4U30F2 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, Z, W); }
        public readonly Vector4U30F2 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, X); }
        public readonly Vector4U30F2 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, Y); }
        public readonly Vector4U30F2 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, Z); }
        public readonly Vector4U30F2 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, X, W, W); }
        public readonly Vector4U30F2 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, X); }
        public readonly Vector4U30F2 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Y); }
        public readonly Vector4U30F2 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, Z); }
        public readonly Vector4U30F2 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, X, W); }
        public readonly Vector4U30F2 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, X); }
        public readonly Vector4U30F2 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Y); }
        public readonly Vector4U30F2 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, Z); }
        public readonly Vector4U30F2 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Y, W); }
        public readonly Vector4U30F2 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, X); }
        public readonly Vector4U30F2 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Y); }
        public readonly Vector4U30F2 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, Z); }
        public readonly Vector4U30F2 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, Z, W); }
        public readonly Vector4U30F2 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, X); }
        public readonly Vector4U30F2 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, Y); }
        public readonly Vector4U30F2 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, Z); }
        public readonly Vector4U30F2 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Y, W, W); }
        public readonly Vector4U30F2 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, X); }
        public readonly Vector4U30F2 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Y); }
        public readonly Vector4U30F2 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, Z); }
        public readonly Vector4U30F2 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, X, W); }
        public readonly Vector4U30F2 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, X); }
        public readonly Vector4U30F2 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Y); }
        public readonly Vector4U30F2 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, Z); }
        public readonly Vector4U30F2 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Y, W); }
        public readonly Vector4U30F2 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, X); }
        public readonly Vector4U30F2 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Y); }
        public readonly Vector4U30F2 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, Z); }
        public readonly Vector4U30F2 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, Z, W); }
        public readonly Vector4U30F2 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, X); }
        public readonly Vector4U30F2 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, Y); }
        public readonly Vector4U30F2 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, Z); }
        public readonly Vector4U30F2 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, Z, W, W); }
        public readonly Vector4U30F2 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, X); }
        public readonly Vector4U30F2 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, Y); }
        public readonly Vector4U30F2 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, Z); }
        public readonly Vector4U30F2 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, X, W); }
        public readonly Vector4U30F2 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, X); }
        public readonly Vector4U30F2 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, Y); }
        public readonly Vector4U30F2 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, Z); }
        public readonly Vector4U30F2 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Y, W); }
        public readonly Vector4U30F2 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, X); }
        public readonly Vector4U30F2 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, Y); }
        public readonly Vector4U30F2 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, Z); }
        public readonly Vector4U30F2 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, Z, W); }
        public readonly Vector4U30F2 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, X); }
        public readonly Vector4U30F2 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, Y); }
        public readonly Vector4U30F2 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, Z); }
        public readonly Vector4U30F2 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Z, W, W, W); }
        public readonly Vector4U30F2 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, X); }
        public readonly Vector4U30F2 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, Y); }
        public readonly Vector4U30F2 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, Z); }
        public readonly Vector4U30F2 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, X, W); }
        public readonly Vector4U30F2 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, X); }
        public readonly Vector4U30F2 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, Y); }
        public readonly Vector4U30F2 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, Z); }
        public readonly Vector4U30F2 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Y, W); }
        public readonly Vector4U30F2 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, X); }
        public readonly Vector4U30F2 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, Y); }
        public readonly Vector4U30F2 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, Z); }
        public readonly Vector4U30F2 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, Z, W); }
        public readonly Vector4U30F2 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, X); }
        public readonly Vector4U30F2 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, Y); }
        public readonly Vector4U30F2 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, Z); }
        public readonly Vector4U30F2 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, X, W, W); }
        public readonly Vector4U30F2 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, X); }
        public readonly Vector4U30F2 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, Y); }
        public readonly Vector4U30F2 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, Z); }
        public readonly Vector4U30F2 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, X, W); }
        public readonly Vector4U30F2 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, X); }
        public readonly Vector4U30F2 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, Y); }
        public readonly Vector4U30F2 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, Z); }
        public readonly Vector4U30F2 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Y, W); }
        public readonly Vector4U30F2 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, X); }
        public readonly Vector4U30F2 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, Y); }
        public readonly Vector4U30F2 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, Z); }
        public readonly Vector4U30F2 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, Z, W); }
        public readonly Vector4U30F2 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, X); }
        public readonly Vector4U30F2 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, Y); }
        public readonly Vector4U30F2 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, Z); }
        public readonly Vector4U30F2 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Y, W, W); }
        public readonly Vector4U30F2 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, X); }
        public readonly Vector4U30F2 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, Y); }
        public readonly Vector4U30F2 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, Z); }
        public readonly Vector4U30F2 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, X, W); }
        public readonly Vector4U30F2 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, X); }
        public readonly Vector4U30F2 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, Y); }
        public readonly Vector4U30F2 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, Z); }
        public readonly Vector4U30F2 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Y, W); }
        public readonly Vector4U30F2 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, X); }
        public readonly Vector4U30F2 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, Y); }
        public readonly Vector4U30F2 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, Z); }
        public readonly Vector4U30F2 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, Z, W); }
        public readonly Vector4U30F2 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, X); }
        public readonly Vector4U30F2 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, Y); }
        public readonly Vector4U30F2 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, Z); }
        public readonly Vector4U30F2 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, Z, W, W); }
        public readonly Vector4U30F2 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, X); }
        public readonly Vector4U30F2 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, Y); }
        public readonly Vector4U30F2 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, Z); }
        public readonly Vector4U30F2 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, X, W); }
        public readonly Vector4U30F2 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, X); }
        public readonly Vector4U30F2 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, Y); }
        public readonly Vector4U30F2 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, Z); }
        public readonly Vector4U30F2 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Y, W); }
        public readonly Vector4U30F2 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, X); }
        public readonly Vector4U30F2 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, Y); }
        public readonly Vector4U30F2 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, Z); }
        public readonly Vector4U30F2 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, Z, W); }
        public readonly Vector4U30F2 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, X); }
        public readonly Vector4U30F2 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, Y); }
        public readonly Vector4U30F2 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, Z); }
        public readonly Vector4U30F2 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U30F2 other)
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

        public readonly Vector4U30F2 Half() => new Vector4U30F2(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4U30F2 Twice() => new Vector4U30F2(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4U30F2 Clamp(U30F2 min, U30F2 max) => new Vector4U30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4U30F2 Clamp(
            Vector4U30F2 min, Vector4U30F2 max
        ) => new Vector4U30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U30F2 SaturatingAdd(Vector4U30F2 other) => new Vector4U30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U30F2 SaturatingMul(U30F2 other) => new Vector4U30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U62F2 WideningDot(Vector4U30F2 other) {
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
            return U62F2.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U30F2 Dot(Vector4U30F2 other) => (U30F2)WideningDot(other);

    }

    partial struct U30F2 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U30F2 SaturatingMul(Vector4U30F2 other) => other.SaturatingMul(this);
    }
}
