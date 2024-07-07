using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U25F7 : IEquatable<Vector4U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U25F7 X;
        public U25F7 Y;
        public U25F7 Z;
        public U25F7 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, U25F7 z, U25F7 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, U25F7 y, Vector2U25F7 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector3U25F7 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, Vector2U25F7 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector4U25F7 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(U25F7 x, Vector2U25F7 yz, U25F7 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector3U25F7 xyz, U25F7 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7(Vector2U25F7 xy, U25F7 z, U25F7 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.Zero);
        }
        public static Vector4U25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.One);
        }
        public static Vector4U25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.One, U25F7.Zero, U25F7.Zero, U25F7.Zero);
        }
        public static Vector4U25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.Zero, U25F7.One, U25F7.Zero, U25F7.Zero);
        }
        public static Vector4U25F7 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.Zero, U25F7.Zero, U25F7.One, U25F7.Zero);
        }
        public static Vector4U25F7 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U25F7(U25F7.Zero, U25F7.Zero, U25F7.Zero, U25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator +(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator -(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator *(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(Vector4U25F7 a, U25F7 b) => new Vector4U25F7(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 operator /(U25F7 a, Vector4U25F7 b) => new Vector4U25F7(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U25F7 lhs, Vector4U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U25F7 lhs, Vector4U25F7 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U25F7 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, X); }
        public readonly Vector2U25F7 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Y); }
        public readonly Vector2U25F7 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Z); }
        public readonly Vector2U25F7 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, W); }
        public readonly Vector2U25F7 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, X); }
        public readonly Vector2U25F7 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Y); }
        public readonly Vector2U25F7 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Z); }
        public readonly Vector2U25F7 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, W); }
        public readonly Vector2U25F7 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, X); }
        public readonly Vector2U25F7 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Y); }
        public readonly Vector2U25F7 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, Z); }
        public readonly Vector2U25F7 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Z, W); }
        public readonly Vector2U25F7 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, X); }
        public readonly Vector2U25F7 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, Y); }
        public readonly Vector2U25F7 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, Z); }
        public readonly Vector2U25F7 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(W, W); }
        public readonly Vector3U25F7 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, X); }
        public readonly Vector3U25F7 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Y); }
        public readonly Vector3U25F7 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Z); }
        public readonly Vector3U25F7 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, W); }
        public readonly Vector3U25F7 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, X); }
        public readonly Vector3U25F7 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Y); }
        public readonly Vector3U25F7 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Z); }
        public readonly Vector3U25F7 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, W); }
        public readonly Vector3U25F7 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, X); }
        public readonly Vector3U25F7 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Y); }
        public readonly Vector3U25F7 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, Z); }
        public readonly Vector3U25F7 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Z, W); }
        public readonly Vector3U25F7 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, X); }
        public readonly Vector3U25F7 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, Y); }
        public readonly Vector3U25F7 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, Z); }
        public readonly Vector3U25F7 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, W, W); }
        public readonly Vector3U25F7 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, X); }
        public readonly Vector3U25F7 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Y); }
        public readonly Vector3U25F7 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Z); }
        public readonly Vector3U25F7 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, W); }
        public readonly Vector3U25F7 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, X); }
        public readonly Vector3U25F7 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Y); }
        public readonly Vector3U25F7 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Z); }
        public readonly Vector3U25F7 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, W); }
        public readonly Vector3U25F7 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, X); }
        public readonly Vector3U25F7 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Y); }
        public readonly Vector3U25F7 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, Z); }
        public readonly Vector3U25F7 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Z, W); }
        public readonly Vector3U25F7 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, X); }
        public readonly Vector3U25F7 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, Y); }
        public readonly Vector3U25F7 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, Z); }
        public readonly Vector3U25F7 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, W, W); }
        public readonly Vector3U25F7 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, X); }
        public readonly Vector3U25F7 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Y); }
        public readonly Vector3U25F7 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, Z); }
        public readonly Vector3U25F7 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, X, W); }
        public readonly Vector3U25F7 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, X); }
        public readonly Vector3U25F7 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Y); }
        public readonly Vector3U25F7 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, Z); }
        public readonly Vector3U25F7 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Y, W); }
        public readonly Vector3U25F7 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, X); }
        public readonly Vector3U25F7 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Y); }
        public readonly Vector3U25F7 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, Z); }
        public readonly Vector3U25F7 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, Z, W); }
        public readonly Vector3U25F7 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, X); }
        public readonly Vector3U25F7 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, Y); }
        public readonly Vector3U25F7 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, Z); }
        public readonly Vector3U25F7 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Z, W, W); }
        public readonly Vector3U25F7 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, X); }
        public readonly Vector3U25F7 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, Y); }
        public readonly Vector3U25F7 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, Z); }
        public readonly Vector3U25F7 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, X, W); }
        public readonly Vector3U25F7 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, X); }
        public readonly Vector3U25F7 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, Y); }
        public readonly Vector3U25F7 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, Z); }
        public readonly Vector3U25F7 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Y, W); }
        public readonly Vector3U25F7 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, X); }
        public readonly Vector3U25F7 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, Y); }
        public readonly Vector3U25F7 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, Z); }
        public readonly Vector3U25F7 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, Z, W); }
        public readonly Vector3U25F7 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, X); }
        public readonly Vector3U25F7 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, Y); }
        public readonly Vector3U25F7 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, Z); }
        public readonly Vector3U25F7 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(W, W, W); }
        public readonly Vector4U25F7 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, X); }
        public readonly Vector4U25F7 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Y); }
        public readonly Vector4U25F7 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Z); }
        public readonly Vector4U25F7 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, W); }
        public readonly Vector4U25F7 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, X); }
        public readonly Vector4U25F7 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Y); }
        public readonly Vector4U25F7 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Z); }
        public readonly Vector4U25F7 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, W); }
        public readonly Vector4U25F7 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, X); }
        public readonly Vector4U25F7 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Y); }
        public readonly Vector4U25F7 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, Z); }
        public readonly Vector4U25F7 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Z, W); }
        public readonly Vector4U25F7 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, X); }
        public readonly Vector4U25F7 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, Y); }
        public readonly Vector4U25F7 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, Z); }
        public readonly Vector4U25F7 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, W, W); }
        public readonly Vector4U25F7 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, X); }
        public readonly Vector4U25F7 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Y); }
        public readonly Vector4U25F7 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Z); }
        public readonly Vector4U25F7 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, W); }
        public readonly Vector4U25F7 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, X); }
        public readonly Vector4U25F7 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Y); }
        public readonly Vector4U25F7 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Z); }
        public readonly Vector4U25F7 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, W); }
        public readonly Vector4U25F7 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, X); }
        public readonly Vector4U25F7 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Y); }
        public readonly Vector4U25F7 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, Z); }
        public readonly Vector4U25F7 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Z, W); }
        public readonly Vector4U25F7 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, X); }
        public readonly Vector4U25F7 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, Y); }
        public readonly Vector4U25F7 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, Z); }
        public readonly Vector4U25F7 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, W, W); }
        public readonly Vector4U25F7 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, X); }
        public readonly Vector4U25F7 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Y); }
        public readonly Vector4U25F7 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, Z); }
        public readonly Vector4U25F7 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, X, W); }
        public readonly Vector4U25F7 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, X); }
        public readonly Vector4U25F7 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Y); }
        public readonly Vector4U25F7 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, Z); }
        public readonly Vector4U25F7 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Y, W); }
        public readonly Vector4U25F7 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, X); }
        public readonly Vector4U25F7 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Y); }
        public readonly Vector4U25F7 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, Z); }
        public readonly Vector4U25F7 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, Z, W); }
        public readonly Vector4U25F7 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, X); }
        public readonly Vector4U25F7 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, Y); }
        public readonly Vector4U25F7 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, Z); }
        public readonly Vector4U25F7 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Z, W, W); }
        public readonly Vector4U25F7 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, X); }
        public readonly Vector4U25F7 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, Y); }
        public readonly Vector4U25F7 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, Z); }
        public readonly Vector4U25F7 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, X, W); }
        public readonly Vector4U25F7 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, X); }
        public readonly Vector4U25F7 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, Y); }
        public readonly Vector4U25F7 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, Z); }
        public readonly Vector4U25F7 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Y, W); }
        public readonly Vector4U25F7 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, X); }
        public readonly Vector4U25F7 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, Y); }
        public readonly Vector4U25F7 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, Z); }
        public readonly Vector4U25F7 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, Z, W); }
        public readonly Vector4U25F7 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, X); }
        public readonly Vector4U25F7 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, Y); }
        public readonly Vector4U25F7 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, Z); }
        public readonly Vector4U25F7 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, W, W, W); }
        public readonly Vector4U25F7 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, X); }
        public readonly Vector4U25F7 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Y); }
        public readonly Vector4U25F7 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Z); }
        public readonly Vector4U25F7 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, W); }
        public readonly Vector4U25F7 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, X); }
        public readonly Vector4U25F7 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Y); }
        public readonly Vector4U25F7 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Z); }
        public readonly Vector4U25F7 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, W); }
        public readonly Vector4U25F7 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, X); }
        public readonly Vector4U25F7 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Y); }
        public readonly Vector4U25F7 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, Z); }
        public readonly Vector4U25F7 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Z, W); }
        public readonly Vector4U25F7 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, X); }
        public readonly Vector4U25F7 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, Y); }
        public readonly Vector4U25F7 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, Z); }
        public readonly Vector4U25F7 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, W, W); }
        public readonly Vector4U25F7 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, X); }
        public readonly Vector4U25F7 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Y); }
        public readonly Vector4U25F7 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Z); }
        public readonly Vector4U25F7 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, W); }
        public readonly Vector4U25F7 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, X); }
        public readonly Vector4U25F7 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Y); }
        public readonly Vector4U25F7 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Z); }
        public readonly Vector4U25F7 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, W); }
        public readonly Vector4U25F7 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, X); }
        public readonly Vector4U25F7 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Y); }
        public readonly Vector4U25F7 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, Z); }
        public readonly Vector4U25F7 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Z, W); }
        public readonly Vector4U25F7 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, X); }
        public readonly Vector4U25F7 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, Y); }
        public readonly Vector4U25F7 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, Z); }
        public readonly Vector4U25F7 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, W, W); }
        public readonly Vector4U25F7 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, X); }
        public readonly Vector4U25F7 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Y); }
        public readonly Vector4U25F7 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, Z); }
        public readonly Vector4U25F7 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, X, W); }
        public readonly Vector4U25F7 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, X); }
        public readonly Vector4U25F7 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Y); }
        public readonly Vector4U25F7 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, Z); }
        public readonly Vector4U25F7 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Y, W); }
        public readonly Vector4U25F7 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, X); }
        public readonly Vector4U25F7 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Y); }
        public readonly Vector4U25F7 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, Z); }
        public readonly Vector4U25F7 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, Z, W); }
        public readonly Vector4U25F7 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, X); }
        public readonly Vector4U25F7 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, Y); }
        public readonly Vector4U25F7 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, Z); }
        public readonly Vector4U25F7 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Z, W, W); }
        public readonly Vector4U25F7 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, X); }
        public readonly Vector4U25F7 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, Y); }
        public readonly Vector4U25F7 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, Z); }
        public readonly Vector4U25F7 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, X, W); }
        public readonly Vector4U25F7 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, X); }
        public readonly Vector4U25F7 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, Y); }
        public readonly Vector4U25F7 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, Z); }
        public readonly Vector4U25F7 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Y, W); }
        public readonly Vector4U25F7 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, X); }
        public readonly Vector4U25F7 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, Y); }
        public readonly Vector4U25F7 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, Z); }
        public readonly Vector4U25F7 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, Z, W); }
        public readonly Vector4U25F7 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, X); }
        public readonly Vector4U25F7 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, Y); }
        public readonly Vector4U25F7 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, Z); }
        public readonly Vector4U25F7 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, W, W, W); }
        public readonly Vector4U25F7 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, X); }
        public readonly Vector4U25F7 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Y); }
        public readonly Vector4U25F7 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, Z); }
        public readonly Vector4U25F7 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, X, W); }
        public readonly Vector4U25F7 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, X); }
        public readonly Vector4U25F7 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Y); }
        public readonly Vector4U25F7 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, Z); }
        public readonly Vector4U25F7 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Y, W); }
        public readonly Vector4U25F7 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, X); }
        public readonly Vector4U25F7 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Y); }
        public readonly Vector4U25F7 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, Z); }
        public readonly Vector4U25F7 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, Z, W); }
        public readonly Vector4U25F7 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, X); }
        public readonly Vector4U25F7 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, Y); }
        public readonly Vector4U25F7 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, Z); }
        public readonly Vector4U25F7 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, X, W, W); }
        public readonly Vector4U25F7 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, X); }
        public readonly Vector4U25F7 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Y); }
        public readonly Vector4U25F7 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, Z); }
        public readonly Vector4U25F7 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, X, W); }
        public readonly Vector4U25F7 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, X); }
        public readonly Vector4U25F7 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Y); }
        public readonly Vector4U25F7 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, Z); }
        public readonly Vector4U25F7 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Y, W); }
        public readonly Vector4U25F7 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, X); }
        public readonly Vector4U25F7 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Y); }
        public readonly Vector4U25F7 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, Z); }
        public readonly Vector4U25F7 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, Z, W); }
        public readonly Vector4U25F7 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, X); }
        public readonly Vector4U25F7 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, Y); }
        public readonly Vector4U25F7 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, Z); }
        public readonly Vector4U25F7 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Y, W, W); }
        public readonly Vector4U25F7 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, X); }
        public readonly Vector4U25F7 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Y); }
        public readonly Vector4U25F7 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, Z); }
        public readonly Vector4U25F7 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, X, W); }
        public readonly Vector4U25F7 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, X); }
        public readonly Vector4U25F7 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Y); }
        public readonly Vector4U25F7 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, Z); }
        public readonly Vector4U25F7 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Y, W); }
        public readonly Vector4U25F7 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, X); }
        public readonly Vector4U25F7 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Y); }
        public readonly Vector4U25F7 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, Z); }
        public readonly Vector4U25F7 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, Z, W); }
        public readonly Vector4U25F7 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, X); }
        public readonly Vector4U25F7 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, Y); }
        public readonly Vector4U25F7 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, Z); }
        public readonly Vector4U25F7 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, Z, W, W); }
        public readonly Vector4U25F7 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, X); }
        public readonly Vector4U25F7 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, Y); }
        public readonly Vector4U25F7 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, Z); }
        public readonly Vector4U25F7 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, X, W); }
        public readonly Vector4U25F7 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, X); }
        public readonly Vector4U25F7 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, Y); }
        public readonly Vector4U25F7 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, Z); }
        public readonly Vector4U25F7 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Y, W); }
        public readonly Vector4U25F7 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, X); }
        public readonly Vector4U25F7 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, Y); }
        public readonly Vector4U25F7 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, Z); }
        public readonly Vector4U25F7 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, Z, W); }
        public readonly Vector4U25F7 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, X); }
        public readonly Vector4U25F7 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, Y); }
        public readonly Vector4U25F7 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, Z); }
        public readonly Vector4U25F7 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Z, W, W, W); }
        public readonly Vector4U25F7 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, X); }
        public readonly Vector4U25F7 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, Y); }
        public readonly Vector4U25F7 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, Z); }
        public readonly Vector4U25F7 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, X, W); }
        public readonly Vector4U25F7 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, X); }
        public readonly Vector4U25F7 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, Y); }
        public readonly Vector4U25F7 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, Z); }
        public readonly Vector4U25F7 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Y, W); }
        public readonly Vector4U25F7 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, X); }
        public readonly Vector4U25F7 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, Y); }
        public readonly Vector4U25F7 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, Z); }
        public readonly Vector4U25F7 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, Z, W); }
        public readonly Vector4U25F7 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, X); }
        public readonly Vector4U25F7 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, Y); }
        public readonly Vector4U25F7 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, Z); }
        public readonly Vector4U25F7 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, X, W, W); }
        public readonly Vector4U25F7 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, X); }
        public readonly Vector4U25F7 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, Y); }
        public readonly Vector4U25F7 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, Z); }
        public readonly Vector4U25F7 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, X, W); }
        public readonly Vector4U25F7 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, X); }
        public readonly Vector4U25F7 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, Y); }
        public readonly Vector4U25F7 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, Z); }
        public readonly Vector4U25F7 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Y, W); }
        public readonly Vector4U25F7 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, X); }
        public readonly Vector4U25F7 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, Y); }
        public readonly Vector4U25F7 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, Z); }
        public readonly Vector4U25F7 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, Z, W); }
        public readonly Vector4U25F7 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, X); }
        public readonly Vector4U25F7 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, Y); }
        public readonly Vector4U25F7 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, Z); }
        public readonly Vector4U25F7 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Y, W, W); }
        public readonly Vector4U25F7 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, X); }
        public readonly Vector4U25F7 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, Y); }
        public readonly Vector4U25F7 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, Z); }
        public readonly Vector4U25F7 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, X, W); }
        public readonly Vector4U25F7 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, X); }
        public readonly Vector4U25F7 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, Y); }
        public readonly Vector4U25F7 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, Z); }
        public readonly Vector4U25F7 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Y, W); }
        public readonly Vector4U25F7 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, X); }
        public readonly Vector4U25F7 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, Y); }
        public readonly Vector4U25F7 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, Z); }
        public readonly Vector4U25F7 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, Z, W); }
        public readonly Vector4U25F7 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, X); }
        public readonly Vector4U25F7 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, Y); }
        public readonly Vector4U25F7 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, Z); }
        public readonly Vector4U25F7 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, Z, W, W); }
        public readonly Vector4U25F7 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, X); }
        public readonly Vector4U25F7 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, Y); }
        public readonly Vector4U25F7 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, Z); }
        public readonly Vector4U25F7 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, X, W); }
        public readonly Vector4U25F7 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, X); }
        public readonly Vector4U25F7 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, Y); }
        public readonly Vector4U25F7 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, Z); }
        public readonly Vector4U25F7 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Y, W); }
        public readonly Vector4U25F7 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, X); }
        public readonly Vector4U25F7 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, Y); }
        public readonly Vector4U25F7 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, Z); }
        public readonly Vector4U25F7 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, Z, W); }
        public readonly Vector4U25F7 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, X); }
        public readonly Vector4U25F7 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, Y); }
        public readonly Vector4U25F7 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, Z); }
        public readonly Vector4U25F7 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U25F7 other)
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

        public readonly Vector4U25F7 Half() => new Vector4U25F7(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4U25F7 Twice() => new Vector4U25F7(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4U25F7 Clamp(U25F7 min, U25F7 max) => new Vector4U25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4U25F7 Clamp(
            Vector4U25F7 min, Vector4U25F7 max
        ) => new Vector4U25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U25F7 SaturatingAdd(Vector4U25F7 other) => new Vector4U25F7(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U25F7 SaturatingMul(U25F7 other) => new Vector4U25F7(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U52F12 Dot(Vector4U25F7 other) {
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
            return U52F12.FromBits(bits);
        }

    }

    partial struct U25F7 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U25F7 SaturatingMul(Vector4U25F7 other) => other.SaturatingMul(this);
    }
}
