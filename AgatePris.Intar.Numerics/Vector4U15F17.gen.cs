using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U15F17 : IEquatable<Vector4U15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U15F17 X;
        public U15F17 Y;
        public U15F17 Z;
        public U15F17 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, U15F17 y, U15F17 z, U15F17 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, U15F17 y, Vector2U15F17 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, Vector3U15F17 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector2U15F17 xy, Vector2U15F17 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector4U15F17 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, Vector2U15F17 yz, U15F17 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector3U15F17 xyz, U15F17 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector2U15F17 xy, U15F17 z, U15F17 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero);
        }
        public static Vector4U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.One);
        }
        public static Vector4U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.One, U15F17.Zero, U15F17.Zero, U15F17.Zero);
        }
        public static Vector4U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.One, U15F17.Zero, U15F17.Zero);
        }
        public static Vector4U15F17 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.Zero, U15F17.One, U15F17.Zero);
        }
        public static Vector4U15F17 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.Zero, U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator +(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator -(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(Vector4U15F17 a, U15F17 b) => new Vector4U15F17(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(Vector4U15F17 a, U15F17 b) => new Vector4U15F17(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U15F17 lhs, Vector4U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U15F17 lhs, Vector4U15F17 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U15F17 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, X); }
        public Vector2U15F17 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Y); }
        public Vector2U15F17 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Z); }
        public Vector2U15F17 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, W); }
        public Vector2U15F17 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, X); }
        public Vector2U15F17 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Y); }
        public Vector2U15F17 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Z); }
        public Vector2U15F17 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, W); }
        public Vector2U15F17 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, X); }
        public Vector2U15F17 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Y); }
        public Vector2U15F17 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Z); }
        public Vector2U15F17 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, W); }
        public Vector2U15F17 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(W, X); }
        public Vector2U15F17 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(W, Y); }
        public Vector2U15F17 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(W, Z); }
        public Vector2U15F17 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(W, W); }
        public Vector3U15F17 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, X); }
        public Vector3U15F17 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Y); }
        public Vector3U15F17 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Z); }
        public Vector3U15F17 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, W); }
        public Vector3U15F17 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, X); }
        public Vector3U15F17 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Y); }
        public Vector3U15F17 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Z); }
        public Vector3U15F17 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, W); }
        public Vector3U15F17 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, X); }
        public Vector3U15F17 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Y); }
        public Vector3U15F17 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Z); }
        public Vector3U15F17 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, W); }
        public Vector3U15F17 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, W, X); }
        public Vector3U15F17 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, W, Y); }
        public Vector3U15F17 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, W, Z); }
        public Vector3U15F17 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, W, W); }
        public Vector3U15F17 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, X); }
        public Vector3U15F17 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Y); }
        public Vector3U15F17 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Z); }
        public Vector3U15F17 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, W); }
        public Vector3U15F17 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, X); }
        public Vector3U15F17 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Y); }
        public Vector3U15F17 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Z); }
        public Vector3U15F17 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, W); }
        public Vector3U15F17 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, X); }
        public Vector3U15F17 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Y); }
        public Vector3U15F17 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Z); }
        public Vector3U15F17 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, W); }
        public Vector3U15F17 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, W, X); }
        public Vector3U15F17 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, W, Y); }
        public Vector3U15F17 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, W, Z); }
        public Vector3U15F17 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, W, W); }
        public Vector3U15F17 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, X); }
        public Vector3U15F17 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Y); }
        public Vector3U15F17 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Z); }
        public Vector3U15F17 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, W); }
        public Vector3U15F17 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, X); }
        public Vector3U15F17 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Y); }
        public Vector3U15F17 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Z); }
        public Vector3U15F17 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, W); }
        public Vector3U15F17 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, X); }
        public Vector3U15F17 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Y); }
        public Vector3U15F17 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Z); }
        public Vector3U15F17 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, W); }
        public Vector3U15F17 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, W, X); }
        public Vector3U15F17 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, W, Y); }
        public Vector3U15F17 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, W, Z); }
        public Vector3U15F17 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, W, W); }
        public Vector3U15F17 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, X, X); }
        public Vector3U15F17 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, X, Y); }
        public Vector3U15F17 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, X, Z); }
        public Vector3U15F17 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, X, W); }
        public Vector3U15F17 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Y, X); }
        public Vector3U15F17 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Y, Y); }
        public Vector3U15F17 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Y, Z); }
        public Vector3U15F17 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Y, W); }
        public Vector3U15F17 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Z, X); }
        public Vector3U15F17 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Z, Y); }
        public Vector3U15F17 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Z, Z); }
        public Vector3U15F17 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, Z, W); }
        public Vector3U15F17 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, W, X); }
        public Vector3U15F17 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, W, Y); }
        public Vector3U15F17 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, W, Z); }
        public Vector3U15F17 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(W, W, W); }
        public Vector4U15F17 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, X); }
        public Vector4U15F17 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Y); }
        public Vector4U15F17 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Z); }
        public Vector4U15F17 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, W); }
        public Vector4U15F17 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, X); }
        public Vector4U15F17 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Y); }
        public Vector4U15F17 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Z); }
        public Vector4U15F17 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, W); }
        public Vector4U15F17 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, X); }
        public Vector4U15F17 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Y); }
        public Vector4U15F17 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Z); }
        public Vector4U15F17 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, W); }
        public Vector4U15F17 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, W, X); }
        public Vector4U15F17 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, W, Y); }
        public Vector4U15F17 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, W, Z); }
        public Vector4U15F17 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, W, W); }
        public Vector4U15F17 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, X); }
        public Vector4U15F17 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Y); }
        public Vector4U15F17 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Z); }
        public Vector4U15F17 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, W); }
        public Vector4U15F17 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, X); }
        public Vector4U15F17 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Y); }
        public Vector4U15F17 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Z); }
        public Vector4U15F17 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, W); }
        public Vector4U15F17 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, X); }
        public Vector4U15F17 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Y); }
        public Vector4U15F17 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Z); }
        public Vector4U15F17 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, W); }
        public Vector4U15F17 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, W, X); }
        public Vector4U15F17 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, W, Y); }
        public Vector4U15F17 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, W, Z); }
        public Vector4U15F17 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, W, W); }
        public Vector4U15F17 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, X); }
        public Vector4U15F17 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Y); }
        public Vector4U15F17 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Z); }
        public Vector4U15F17 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, W); }
        public Vector4U15F17 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, X); }
        public Vector4U15F17 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Y); }
        public Vector4U15F17 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Z); }
        public Vector4U15F17 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, W); }
        public Vector4U15F17 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, X); }
        public Vector4U15F17 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Y); }
        public Vector4U15F17 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Z); }
        public Vector4U15F17 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, W); }
        public Vector4U15F17 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, W, X); }
        public Vector4U15F17 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, W, Y); }
        public Vector4U15F17 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, W, Z); }
        public Vector4U15F17 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, W, W); }
        public Vector4U15F17 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, X, X); }
        public Vector4U15F17 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, X, Y); }
        public Vector4U15F17 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, X, Z); }
        public Vector4U15F17 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, X, W); }
        public Vector4U15F17 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Y, X); }
        public Vector4U15F17 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Y, Y); }
        public Vector4U15F17 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Y, Z); }
        public Vector4U15F17 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Y, W); }
        public Vector4U15F17 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Z, X); }
        public Vector4U15F17 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Z, Y); }
        public Vector4U15F17 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Z, Z); }
        public Vector4U15F17 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, Z, W); }
        public Vector4U15F17 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, W, X); }
        public Vector4U15F17 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, W, Y); }
        public Vector4U15F17 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, W, Z); }
        public Vector4U15F17 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, W, W, W); }
        public Vector4U15F17 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, X); }
        public Vector4U15F17 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Y); }
        public Vector4U15F17 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Z); }
        public Vector4U15F17 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, W); }
        public Vector4U15F17 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, X); }
        public Vector4U15F17 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Y); }
        public Vector4U15F17 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Z); }
        public Vector4U15F17 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, W); }
        public Vector4U15F17 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, X); }
        public Vector4U15F17 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Y); }
        public Vector4U15F17 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Z); }
        public Vector4U15F17 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, W); }
        public Vector4U15F17 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, W, X); }
        public Vector4U15F17 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, W, Y); }
        public Vector4U15F17 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, W, Z); }
        public Vector4U15F17 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, W, W); }
        public Vector4U15F17 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, X); }
        public Vector4U15F17 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Y); }
        public Vector4U15F17 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Z); }
        public Vector4U15F17 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, W); }
        public Vector4U15F17 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, X); }
        public Vector4U15F17 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Y); }
        public Vector4U15F17 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Z); }
        public Vector4U15F17 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, W); }
        public Vector4U15F17 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, X); }
        public Vector4U15F17 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Y); }
        public Vector4U15F17 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Z); }
        public Vector4U15F17 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, W); }
        public Vector4U15F17 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, W, X); }
        public Vector4U15F17 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, W, Y); }
        public Vector4U15F17 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, W, Z); }
        public Vector4U15F17 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, W, W); }
        public Vector4U15F17 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, X); }
        public Vector4U15F17 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Y); }
        public Vector4U15F17 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Z); }
        public Vector4U15F17 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, W); }
        public Vector4U15F17 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, X); }
        public Vector4U15F17 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Y); }
        public Vector4U15F17 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Z); }
        public Vector4U15F17 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, W); }
        public Vector4U15F17 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, X); }
        public Vector4U15F17 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Y); }
        public Vector4U15F17 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Z); }
        public Vector4U15F17 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, W); }
        public Vector4U15F17 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, W, X); }
        public Vector4U15F17 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, W, Y); }
        public Vector4U15F17 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, W, Z); }
        public Vector4U15F17 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, W, W); }
        public Vector4U15F17 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, X, X); }
        public Vector4U15F17 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, X, Y); }
        public Vector4U15F17 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, X, Z); }
        public Vector4U15F17 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, X, W); }
        public Vector4U15F17 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Y, X); }
        public Vector4U15F17 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Y, Y); }
        public Vector4U15F17 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Y, Z); }
        public Vector4U15F17 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Y, W); }
        public Vector4U15F17 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Z, X); }
        public Vector4U15F17 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Z, Y); }
        public Vector4U15F17 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Z, Z); }
        public Vector4U15F17 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, Z, W); }
        public Vector4U15F17 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, W, X); }
        public Vector4U15F17 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, W, Y); }
        public Vector4U15F17 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, W, Z); }
        public Vector4U15F17 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, W, W, W); }
        public Vector4U15F17 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, X); }
        public Vector4U15F17 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Y); }
        public Vector4U15F17 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Z); }
        public Vector4U15F17 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, W); }
        public Vector4U15F17 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, X); }
        public Vector4U15F17 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Y); }
        public Vector4U15F17 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Z); }
        public Vector4U15F17 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, W); }
        public Vector4U15F17 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, X); }
        public Vector4U15F17 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Y); }
        public Vector4U15F17 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Z); }
        public Vector4U15F17 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, W); }
        public Vector4U15F17 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, W, X); }
        public Vector4U15F17 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, W, Y); }
        public Vector4U15F17 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, W, Z); }
        public Vector4U15F17 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, W, W); }
        public Vector4U15F17 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, X); }
        public Vector4U15F17 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Y); }
        public Vector4U15F17 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Z); }
        public Vector4U15F17 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, W); }
        public Vector4U15F17 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, X); }
        public Vector4U15F17 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Y); }
        public Vector4U15F17 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Z); }
        public Vector4U15F17 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, W); }
        public Vector4U15F17 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, X); }
        public Vector4U15F17 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Y); }
        public Vector4U15F17 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Z); }
        public Vector4U15F17 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, W); }
        public Vector4U15F17 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, W, X); }
        public Vector4U15F17 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, W, Y); }
        public Vector4U15F17 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, W, Z); }
        public Vector4U15F17 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, W, W); }
        public Vector4U15F17 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, X); }
        public Vector4U15F17 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Y); }
        public Vector4U15F17 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Z); }
        public Vector4U15F17 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, W); }
        public Vector4U15F17 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, X); }
        public Vector4U15F17 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Y); }
        public Vector4U15F17 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Z); }
        public Vector4U15F17 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, W); }
        public Vector4U15F17 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, X); }
        public Vector4U15F17 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Y); }
        public Vector4U15F17 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Z); }
        public Vector4U15F17 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, W); }
        public Vector4U15F17 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, W, X); }
        public Vector4U15F17 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, W, Y); }
        public Vector4U15F17 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, W, Z); }
        public Vector4U15F17 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, W, W); }
        public Vector4U15F17 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, X, X); }
        public Vector4U15F17 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, X, Y); }
        public Vector4U15F17 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, X, Z); }
        public Vector4U15F17 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, X, W); }
        public Vector4U15F17 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Y, X); }
        public Vector4U15F17 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Y, Y); }
        public Vector4U15F17 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Y, Z); }
        public Vector4U15F17 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Y, W); }
        public Vector4U15F17 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Z, X); }
        public Vector4U15F17 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Z, Y); }
        public Vector4U15F17 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Z, Z); }
        public Vector4U15F17 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, Z, W); }
        public Vector4U15F17 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, W, X); }
        public Vector4U15F17 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, W, Y); }
        public Vector4U15F17 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, W, Z); }
        public Vector4U15F17 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, W, W, W); }
        public Vector4U15F17 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, X, X); }
        public Vector4U15F17 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, X, Y); }
        public Vector4U15F17 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, X, Z); }
        public Vector4U15F17 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, X, W); }
        public Vector4U15F17 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Y, X); }
        public Vector4U15F17 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Y, Y); }
        public Vector4U15F17 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Y, Z); }
        public Vector4U15F17 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Y, W); }
        public Vector4U15F17 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Z, X); }
        public Vector4U15F17 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Z, Y); }
        public Vector4U15F17 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Z, Z); }
        public Vector4U15F17 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, Z, W); }
        public Vector4U15F17 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, W, X); }
        public Vector4U15F17 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, W, Y); }
        public Vector4U15F17 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, W, Z); }
        public Vector4U15F17 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, X, W, W); }
        public Vector4U15F17 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, X, X); }
        public Vector4U15F17 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, X, Y); }
        public Vector4U15F17 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, X, Z); }
        public Vector4U15F17 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, X, W); }
        public Vector4U15F17 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Y, X); }
        public Vector4U15F17 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Y, Y); }
        public Vector4U15F17 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Y, Z); }
        public Vector4U15F17 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Y, W); }
        public Vector4U15F17 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Z, X); }
        public Vector4U15F17 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Z, Y); }
        public Vector4U15F17 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Z, Z); }
        public Vector4U15F17 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, Z, W); }
        public Vector4U15F17 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, W, X); }
        public Vector4U15F17 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, W, Y); }
        public Vector4U15F17 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, W, Z); }
        public Vector4U15F17 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Y, W, W); }
        public Vector4U15F17 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, X, X); }
        public Vector4U15F17 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, X, Y); }
        public Vector4U15F17 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, X, Z); }
        public Vector4U15F17 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, X, W); }
        public Vector4U15F17 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Y, X); }
        public Vector4U15F17 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Y, Y); }
        public Vector4U15F17 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Y, Z); }
        public Vector4U15F17 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Y, W); }
        public Vector4U15F17 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Z, X); }
        public Vector4U15F17 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Z, Y); }
        public Vector4U15F17 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Z, Z); }
        public Vector4U15F17 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, Z, W); }
        public Vector4U15F17 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, W, X); }
        public Vector4U15F17 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, W, Y); }
        public Vector4U15F17 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, W, Z); }
        public Vector4U15F17 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, Z, W, W); }
        public Vector4U15F17 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, X, X); }
        public Vector4U15F17 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, X, Y); }
        public Vector4U15F17 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, X, Z); }
        public Vector4U15F17 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, X, W); }
        public Vector4U15F17 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Y, X); }
        public Vector4U15F17 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Y, Y); }
        public Vector4U15F17 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Y, Z); }
        public Vector4U15F17 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Y, W); }
        public Vector4U15F17 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Z, X); }
        public Vector4U15F17 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Z, Y); }
        public Vector4U15F17 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Z, Z); }
        public Vector4U15F17 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, Z, W); }
        public Vector4U15F17 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, W, X); }
        public Vector4U15F17 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, W, Y); }
        public Vector4U15F17 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, W, Z); }
        public Vector4U15F17 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U15F17 other)
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
        public Vector4U15F17 Min(Vector4U15F17 other) => new Vector4U15F17(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Max(Vector4U15F17 other) => new Vector4U15F17(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Half() => new Vector4U15F17(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Twice() => new Vector4U15F17(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Clamp(U15F17 min, U15F17 max) => new Vector4U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Clamp(
            Vector4U15F17 min, Vector4U15F17 max
        ) => new Vector4U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingAdd(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingSub(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingMul(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingAddSigned(Vector4I15F17 other) => new Vector4U15F17(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 SaturatingAdd(Vector4U15F17 other) => new Vector4U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 SaturatingMul(U15F17 other) => new Vector4U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U15F17 other) {
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
        public U15F17 Dot(Vector4U15F17 other) {
            const ulong k = 1UL << 15;
            return U15F17.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U15F17 SaturatingDot(Vector4U15F17 other) {
            const ulong k = 1UL << 15;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U15F17.MaxValue;
            } else {
                return U15F17.FromBits((uint)bits);
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
        public U32F32 LengthSquared() {
            return U32F32.FromBits(LengthSquaredInternal());
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
        public U15F17 LengthHalf() => U15F17.FromBits(LengthInternal());

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
        public I15F17 LengthHalfSigned() => I15F17.FromBits(checked((int)LengthInternal()));

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
        public U16F16 Length() => U16F16.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
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
        public I16F16 LengthSigned() => I16F16.FromBits(checked((int)LengthInternal()));

    }

    partial struct U15F17 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 SaturatingMul(Vector4U15F17 other) => other.SaturatingMul(this);
    }
}
