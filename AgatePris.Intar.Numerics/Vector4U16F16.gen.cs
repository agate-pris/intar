using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U16F16 : IEquatable<Vector4U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U16F16 X;
        public U16F16 Y;
        public U16F16 Z;
        public U16F16 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, U16F16 z, U16F16 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, Vector2U16F16 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector3U16F16 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, Vector2U16F16 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector4U16F16 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector2U16F16 yz, U16F16 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector3U16F16 xyz, U16F16 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, U16F16 z, U16F16 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero);
        }
        public static Vector4U16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.One);
        }
        public static Vector4U16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.One, U16F16.Zero, U16F16.Zero, U16F16.Zero);
        }
        public static Vector4U16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.One, U16F16.Zero, U16F16.Zero);
        }
        public static Vector4U16F16 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.Zero, U16F16.One, U16F16.Zero);
        }
        public static Vector4U16F16 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.Zero, U16F16.Zero, U16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator +(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator -(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U16F16 lhs, Vector4U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U16F16 lhs, Vector4U16F16 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U16F16 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, X); }
        public readonly Vector2U16F16 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Y); }
        public readonly Vector2U16F16 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Z); }
        public readonly Vector2U16F16 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, W); }
        public readonly Vector2U16F16 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, X); }
        public readonly Vector2U16F16 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Y); }
        public readonly Vector2U16F16 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Z); }
        public readonly Vector2U16F16 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, W); }
        public readonly Vector2U16F16 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, X); }
        public readonly Vector2U16F16 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Y); }
        public readonly Vector2U16F16 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, Z); }
        public readonly Vector2U16F16 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Z, W); }
        public readonly Vector2U16F16 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, X); }
        public readonly Vector2U16F16 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, Y); }
        public readonly Vector2U16F16 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, Z); }
        public readonly Vector2U16F16 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(W, W); }
        public readonly Vector3U16F16 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, X); }
        public readonly Vector3U16F16 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Y); }
        public readonly Vector3U16F16 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Z); }
        public readonly Vector3U16F16 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, W); }
        public readonly Vector3U16F16 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, X); }
        public readonly Vector3U16F16 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Y); }
        public readonly Vector3U16F16 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Z); }
        public readonly Vector3U16F16 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, W); }
        public readonly Vector3U16F16 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, X); }
        public readonly Vector3U16F16 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Y); }
        public readonly Vector3U16F16 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, Z); }
        public readonly Vector3U16F16 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Z, W); }
        public readonly Vector3U16F16 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, X); }
        public readonly Vector3U16F16 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, Y); }
        public readonly Vector3U16F16 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, Z); }
        public readonly Vector3U16F16 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, W, W); }
        public readonly Vector3U16F16 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, X); }
        public readonly Vector3U16F16 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Y); }
        public readonly Vector3U16F16 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Z); }
        public readonly Vector3U16F16 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, W); }
        public readonly Vector3U16F16 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, X); }
        public readonly Vector3U16F16 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Y); }
        public readonly Vector3U16F16 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Z); }
        public readonly Vector3U16F16 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, W); }
        public readonly Vector3U16F16 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, X); }
        public readonly Vector3U16F16 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Y); }
        public readonly Vector3U16F16 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, Z); }
        public readonly Vector3U16F16 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Z, W); }
        public readonly Vector3U16F16 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, X); }
        public readonly Vector3U16F16 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, Y); }
        public readonly Vector3U16F16 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, Z); }
        public readonly Vector3U16F16 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, W, W); }
        public readonly Vector3U16F16 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, X); }
        public readonly Vector3U16F16 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Y); }
        public readonly Vector3U16F16 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, Z); }
        public readonly Vector3U16F16 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, X, W); }
        public readonly Vector3U16F16 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, X); }
        public readonly Vector3U16F16 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Y); }
        public readonly Vector3U16F16 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, Z); }
        public readonly Vector3U16F16 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Y, W); }
        public readonly Vector3U16F16 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, X); }
        public readonly Vector3U16F16 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Y); }
        public readonly Vector3U16F16 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, Z); }
        public readonly Vector3U16F16 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, Z, W); }
        public readonly Vector3U16F16 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, X); }
        public readonly Vector3U16F16 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, Y); }
        public readonly Vector3U16F16 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, Z); }
        public readonly Vector3U16F16 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Z, W, W); }
        public readonly Vector3U16F16 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, X); }
        public readonly Vector3U16F16 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, Y); }
        public readonly Vector3U16F16 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, Z); }
        public readonly Vector3U16F16 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, X, W); }
        public readonly Vector3U16F16 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, X); }
        public readonly Vector3U16F16 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, Y); }
        public readonly Vector3U16F16 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, Z); }
        public readonly Vector3U16F16 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Y, W); }
        public readonly Vector3U16F16 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, X); }
        public readonly Vector3U16F16 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, Y); }
        public readonly Vector3U16F16 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, Z); }
        public readonly Vector3U16F16 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, Z, W); }
        public readonly Vector3U16F16 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, X); }
        public readonly Vector3U16F16 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, Y); }
        public readonly Vector3U16F16 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, Z); }
        public readonly Vector3U16F16 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(W, W, W); }
        public readonly Vector4U16F16 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, X); }
        public readonly Vector4U16F16 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Y); }
        public readonly Vector4U16F16 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Z); }
        public readonly Vector4U16F16 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, W); }
        public readonly Vector4U16F16 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, X); }
        public readonly Vector4U16F16 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Y); }
        public readonly Vector4U16F16 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Z); }
        public readonly Vector4U16F16 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, W); }
        public readonly Vector4U16F16 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, X); }
        public readonly Vector4U16F16 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Y); }
        public readonly Vector4U16F16 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, Z); }
        public readonly Vector4U16F16 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Z, W); }
        public readonly Vector4U16F16 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, X); }
        public readonly Vector4U16F16 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, Y); }
        public readonly Vector4U16F16 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, Z); }
        public readonly Vector4U16F16 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, W, W); }
        public readonly Vector4U16F16 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, X); }
        public readonly Vector4U16F16 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Y); }
        public readonly Vector4U16F16 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Z); }
        public readonly Vector4U16F16 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, W); }
        public readonly Vector4U16F16 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, X); }
        public readonly Vector4U16F16 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Y); }
        public readonly Vector4U16F16 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Z); }
        public readonly Vector4U16F16 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, W); }
        public readonly Vector4U16F16 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, X); }
        public readonly Vector4U16F16 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Y); }
        public readonly Vector4U16F16 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, Z); }
        public readonly Vector4U16F16 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Z, W); }
        public readonly Vector4U16F16 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, X); }
        public readonly Vector4U16F16 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, Y); }
        public readonly Vector4U16F16 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, Z); }
        public readonly Vector4U16F16 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, W, W); }
        public readonly Vector4U16F16 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, X); }
        public readonly Vector4U16F16 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Y); }
        public readonly Vector4U16F16 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, Z); }
        public readonly Vector4U16F16 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, X, W); }
        public readonly Vector4U16F16 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, X); }
        public readonly Vector4U16F16 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Y); }
        public readonly Vector4U16F16 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, Z); }
        public readonly Vector4U16F16 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Y, W); }
        public readonly Vector4U16F16 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, X); }
        public readonly Vector4U16F16 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Y); }
        public readonly Vector4U16F16 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, Z); }
        public readonly Vector4U16F16 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, Z, W); }
        public readonly Vector4U16F16 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, X); }
        public readonly Vector4U16F16 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, Y); }
        public readonly Vector4U16F16 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, Z); }
        public readonly Vector4U16F16 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Z, W, W); }
        public readonly Vector4U16F16 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, X); }
        public readonly Vector4U16F16 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, Y); }
        public readonly Vector4U16F16 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, Z); }
        public readonly Vector4U16F16 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, X, W); }
        public readonly Vector4U16F16 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, X); }
        public readonly Vector4U16F16 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, Y); }
        public readonly Vector4U16F16 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, Z); }
        public readonly Vector4U16F16 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Y, W); }
        public readonly Vector4U16F16 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, X); }
        public readonly Vector4U16F16 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, Y); }
        public readonly Vector4U16F16 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, Z); }
        public readonly Vector4U16F16 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, Z, W); }
        public readonly Vector4U16F16 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, X); }
        public readonly Vector4U16F16 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, Y); }
        public readonly Vector4U16F16 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, Z); }
        public readonly Vector4U16F16 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, W, W, W); }
        public readonly Vector4U16F16 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, X); }
        public readonly Vector4U16F16 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Y); }
        public readonly Vector4U16F16 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Z); }
        public readonly Vector4U16F16 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, W); }
        public readonly Vector4U16F16 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, X); }
        public readonly Vector4U16F16 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Y); }
        public readonly Vector4U16F16 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Z); }
        public readonly Vector4U16F16 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, W); }
        public readonly Vector4U16F16 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, X); }
        public readonly Vector4U16F16 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Y); }
        public readonly Vector4U16F16 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, Z); }
        public readonly Vector4U16F16 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Z, W); }
        public readonly Vector4U16F16 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, X); }
        public readonly Vector4U16F16 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, Y); }
        public readonly Vector4U16F16 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, Z); }
        public readonly Vector4U16F16 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, W, W); }
        public readonly Vector4U16F16 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, X); }
        public readonly Vector4U16F16 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Y); }
        public readonly Vector4U16F16 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Z); }
        public readonly Vector4U16F16 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, W); }
        public readonly Vector4U16F16 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, X); }
        public readonly Vector4U16F16 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Y); }
        public readonly Vector4U16F16 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Z); }
        public readonly Vector4U16F16 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, W); }
        public readonly Vector4U16F16 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, X); }
        public readonly Vector4U16F16 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Y); }
        public readonly Vector4U16F16 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, Z); }
        public readonly Vector4U16F16 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Z, W); }
        public readonly Vector4U16F16 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, X); }
        public readonly Vector4U16F16 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, Y); }
        public readonly Vector4U16F16 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, Z); }
        public readonly Vector4U16F16 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, W, W); }
        public readonly Vector4U16F16 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, X); }
        public readonly Vector4U16F16 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Y); }
        public readonly Vector4U16F16 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, Z); }
        public readonly Vector4U16F16 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, X, W); }
        public readonly Vector4U16F16 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, X); }
        public readonly Vector4U16F16 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Y); }
        public readonly Vector4U16F16 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, Z); }
        public readonly Vector4U16F16 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Y, W); }
        public readonly Vector4U16F16 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, X); }
        public readonly Vector4U16F16 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Y); }
        public readonly Vector4U16F16 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, Z); }
        public readonly Vector4U16F16 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, Z, W); }
        public readonly Vector4U16F16 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, X); }
        public readonly Vector4U16F16 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, Y); }
        public readonly Vector4U16F16 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, Z); }
        public readonly Vector4U16F16 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Z, W, W); }
        public readonly Vector4U16F16 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, X); }
        public readonly Vector4U16F16 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, Y); }
        public readonly Vector4U16F16 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, Z); }
        public readonly Vector4U16F16 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, X, W); }
        public readonly Vector4U16F16 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, X); }
        public readonly Vector4U16F16 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, Y); }
        public readonly Vector4U16F16 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, Z); }
        public readonly Vector4U16F16 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Y, W); }
        public readonly Vector4U16F16 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, X); }
        public readonly Vector4U16F16 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, Y); }
        public readonly Vector4U16F16 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, Z); }
        public readonly Vector4U16F16 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, Z, W); }
        public readonly Vector4U16F16 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, X); }
        public readonly Vector4U16F16 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, Y); }
        public readonly Vector4U16F16 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, Z); }
        public readonly Vector4U16F16 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, W, W, W); }
        public readonly Vector4U16F16 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, X); }
        public readonly Vector4U16F16 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Y); }
        public readonly Vector4U16F16 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, Z); }
        public readonly Vector4U16F16 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, X, W); }
        public readonly Vector4U16F16 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, X); }
        public readonly Vector4U16F16 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Y); }
        public readonly Vector4U16F16 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, Z); }
        public readonly Vector4U16F16 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Y, W); }
        public readonly Vector4U16F16 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, X); }
        public readonly Vector4U16F16 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Y); }
        public readonly Vector4U16F16 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, Z); }
        public readonly Vector4U16F16 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, Z, W); }
        public readonly Vector4U16F16 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, X); }
        public readonly Vector4U16F16 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, Y); }
        public readonly Vector4U16F16 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, Z); }
        public readonly Vector4U16F16 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, X, W, W); }
        public readonly Vector4U16F16 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, X); }
        public readonly Vector4U16F16 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Y); }
        public readonly Vector4U16F16 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, Z); }
        public readonly Vector4U16F16 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, X, W); }
        public readonly Vector4U16F16 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, X); }
        public readonly Vector4U16F16 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Y); }
        public readonly Vector4U16F16 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, Z); }
        public readonly Vector4U16F16 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Y, W); }
        public readonly Vector4U16F16 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, X); }
        public readonly Vector4U16F16 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Y); }
        public readonly Vector4U16F16 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, Z); }
        public readonly Vector4U16F16 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, Z, W); }
        public readonly Vector4U16F16 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, X); }
        public readonly Vector4U16F16 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, Y); }
        public readonly Vector4U16F16 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, Z); }
        public readonly Vector4U16F16 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Y, W, W); }
        public readonly Vector4U16F16 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, X); }
        public readonly Vector4U16F16 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Y); }
        public readonly Vector4U16F16 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, Z); }
        public readonly Vector4U16F16 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, X, W); }
        public readonly Vector4U16F16 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, X); }
        public readonly Vector4U16F16 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Y); }
        public readonly Vector4U16F16 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, Z); }
        public readonly Vector4U16F16 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Y, W); }
        public readonly Vector4U16F16 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, X); }
        public readonly Vector4U16F16 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Y); }
        public readonly Vector4U16F16 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, Z); }
        public readonly Vector4U16F16 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, Z, W); }
        public readonly Vector4U16F16 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, X); }
        public readonly Vector4U16F16 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, Y); }
        public readonly Vector4U16F16 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, Z); }
        public readonly Vector4U16F16 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, Z, W, W); }
        public readonly Vector4U16F16 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, X); }
        public readonly Vector4U16F16 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, Y); }
        public readonly Vector4U16F16 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, Z); }
        public readonly Vector4U16F16 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, X, W); }
        public readonly Vector4U16F16 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, X); }
        public readonly Vector4U16F16 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, Y); }
        public readonly Vector4U16F16 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, Z); }
        public readonly Vector4U16F16 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Y, W); }
        public readonly Vector4U16F16 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, X); }
        public readonly Vector4U16F16 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, Y); }
        public readonly Vector4U16F16 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, Z); }
        public readonly Vector4U16F16 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, Z, W); }
        public readonly Vector4U16F16 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, X); }
        public readonly Vector4U16F16 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, Y); }
        public readonly Vector4U16F16 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, Z); }
        public readonly Vector4U16F16 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Z, W, W, W); }
        public readonly Vector4U16F16 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, X); }
        public readonly Vector4U16F16 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, Y); }
        public readonly Vector4U16F16 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, Z); }
        public readonly Vector4U16F16 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, X, W); }
        public readonly Vector4U16F16 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, X); }
        public readonly Vector4U16F16 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, Y); }
        public readonly Vector4U16F16 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, Z); }
        public readonly Vector4U16F16 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Y, W); }
        public readonly Vector4U16F16 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, X); }
        public readonly Vector4U16F16 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, Y); }
        public readonly Vector4U16F16 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, Z); }
        public readonly Vector4U16F16 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, Z, W); }
        public readonly Vector4U16F16 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, X); }
        public readonly Vector4U16F16 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, Y); }
        public readonly Vector4U16F16 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, Z); }
        public readonly Vector4U16F16 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, X, W, W); }
        public readonly Vector4U16F16 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, X); }
        public readonly Vector4U16F16 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, Y); }
        public readonly Vector4U16F16 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, Z); }
        public readonly Vector4U16F16 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, X, W); }
        public readonly Vector4U16F16 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, X); }
        public readonly Vector4U16F16 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, Y); }
        public readonly Vector4U16F16 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, Z); }
        public readonly Vector4U16F16 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Y, W); }
        public readonly Vector4U16F16 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, X); }
        public readonly Vector4U16F16 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, Y); }
        public readonly Vector4U16F16 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, Z); }
        public readonly Vector4U16F16 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, Z, W); }
        public readonly Vector4U16F16 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, X); }
        public readonly Vector4U16F16 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, Y); }
        public readonly Vector4U16F16 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, Z); }
        public readonly Vector4U16F16 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Y, W, W); }
        public readonly Vector4U16F16 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, X); }
        public readonly Vector4U16F16 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, Y); }
        public readonly Vector4U16F16 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, Z); }
        public readonly Vector4U16F16 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, X, W); }
        public readonly Vector4U16F16 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, X); }
        public readonly Vector4U16F16 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, Y); }
        public readonly Vector4U16F16 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, Z); }
        public readonly Vector4U16F16 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Y, W); }
        public readonly Vector4U16F16 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, X); }
        public readonly Vector4U16F16 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, Y); }
        public readonly Vector4U16F16 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, Z); }
        public readonly Vector4U16F16 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, Z, W); }
        public readonly Vector4U16F16 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, X); }
        public readonly Vector4U16F16 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, Y); }
        public readonly Vector4U16F16 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, Z); }
        public readonly Vector4U16F16 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, Z, W, W); }
        public readonly Vector4U16F16 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, X); }
        public readonly Vector4U16F16 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, Y); }
        public readonly Vector4U16F16 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, Z); }
        public readonly Vector4U16F16 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, X, W); }
        public readonly Vector4U16F16 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, X); }
        public readonly Vector4U16F16 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, Y); }
        public readonly Vector4U16F16 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, Z); }
        public readonly Vector4U16F16 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Y, W); }
        public readonly Vector4U16F16 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, X); }
        public readonly Vector4U16F16 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, Y); }
        public readonly Vector4U16F16 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, Z); }
        public readonly Vector4U16F16 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, Z, W); }
        public readonly Vector4U16F16 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, X); }
        public readonly Vector4U16F16 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, Y); }
        public readonly Vector4U16F16 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, Z); }
        public readonly Vector4U16F16 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U16F16 other)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Min(Vector4U16F16 other) => new Vector4U16F16(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Max(Vector4U16F16 other) => new Vector4U16F16(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Half() => new Vector4U16F16(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Twice() => new Vector4U16F16(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Clamp(U16F16 min, U16F16 max) => new Vector4U16F16(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 Clamp(
            Vector4U16F16 min, Vector4U16F16 max
        ) => new Vector4U16F16(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 SaturatingAdd(Vector4U16F16 other) => new Vector4U16F16(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 SaturatingMul(U16F16 other) => new Vector4U16F16(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector4U16F16 other) {
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
        public readonly U16F16 Dot(Vector4U16F16 other) {
            const ulong k = 1UL << 14;
            return U16F16.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U16F16 SaturatingDot(Vector4U16F16 other) {
            const ulong k = 1UL << 14;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U16F16.MaxValue;
            } else {
                return U16F16.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U34F30 LengthSquared() {
            return U34F30.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U16F16 LengthHalf() => U16F16.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U17F15 Length() => U17F15.FromBits(LengthInternal());

    }

    partial struct U16F16 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U16F16 SaturatingMul(Vector4U16F16 other) => other.SaturatingMul(this);
    }
}
