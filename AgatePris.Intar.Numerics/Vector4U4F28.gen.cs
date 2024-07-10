using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U4F28 : IEquatable<Vector4U4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U4F28 X;
        public U4F28 Y;
        public U4F28 Z;
        public U4F28 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, U4F28 y, U4F28 z, U4F28 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, U4F28 y, Vector2U4F28 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, Vector3U4F28 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector2U4F28 xy, Vector2U4F28 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector4U4F28 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, Vector2U4F28 yz, U4F28 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector3U4F28 xyz, U4F28 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector2U4F28 xy, U4F28 z, U4F28 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero);
        }
        public static Vector4U4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.One);
        }
        public static Vector4U4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.One, U4F28.Zero, U4F28.Zero, U4F28.Zero);
        }
        public static Vector4U4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.One, U4F28.Zero, U4F28.Zero);
        }
        public static Vector4U4F28 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.Zero, U4F28.One, U4F28.Zero);
        }
        public static Vector4U4F28 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.Zero, U4F28.Zero, U4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator +(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator -(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(Vector4U4F28 a, U4F28 b) => new Vector4U4F28(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(Vector4U4F28 a, U4F28 b) => new Vector4U4F28(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U4F28 lhs, Vector4U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U4F28 lhs, Vector4U4F28 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U4F28 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, X); }
        public readonly Vector2U4F28 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Y); }
        public readonly Vector2U4F28 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Z); }
        public readonly Vector2U4F28 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, W); }
        public readonly Vector2U4F28 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, X); }
        public readonly Vector2U4F28 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Y); }
        public readonly Vector2U4F28 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Z); }
        public readonly Vector2U4F28 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, W); }
        public readonly Vector2U4F28 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, X); }
        public readonly Vector2U4F28 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, Y); }
        public readonly Vector2U4F28 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, Z); }
        public readonly Vector2U4F28 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Z, W); }
        public readonly Vector2U4F28 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(W, X); }
        public readonly Vector2U4F28 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(W, Y); }
        public readonly Vector2U4F28 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(W, Z); }
        public readonly Vector2U4F28 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(W, W); }
        public readonly Vector3U4F28 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, X); }
        public readonly Vector3U4F28 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Y); }
        public readonly Vector3U4F28 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Z); }
        public readonly Vector3U4F28 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, W); }
        public readonly Vector3U4F28 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, X); }
        public readonly Vector3U4F28 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Y); }
        public readonly Vector3U4F28 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Z); }
        public readonly Vector3U4F28 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, W); }
        public readonly Vector3U4F28 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, X); }
        public readonly Vector3U4F28 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, Y); }
        public readonly Vector3U4F28 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, Z); }
        public readonly Vector3U4F28 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Z, W); }
        public readonly Vector3U4F28 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, W, X); }
        public readonly Vector3U4F28 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, W, Y); }
        public readonly Vector3U4F28 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, W, Z); }
        public readonly Vector3U4F28 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, W, W); }
        public readonly Vector3U4F28 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, X); }
        public readonly Vector3U4F28 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Y); }
        public readonly Vector3U4F28 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Z); }
        public readonly Vector3U4F28 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, W); }
        public readonly Vector3U4F28 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, X); }
        public readonly Vector3U4F28 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Y); }
        public readonly Vector3U4F28 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Z); }
        public readonly Vector3U4F28 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, W); }
        public readonly Vector3U4F28 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, X); }
        public readonly Vector3U4F28 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, Y); }
        public readonly Vector3U4F28 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, Z); }
        public readonly Vector3U4F28 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Z, W); }
        public readonly Vector3U4F28 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, W, X); }
        public readonly Vector3U4F28 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, W, Y); }
        public readonly Vector3U4F28 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, W, Z); }
        public readonly Vector3U4F28 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, W, W); }
        public readonly Vector3U4F28 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, X); }
        public readonly Vector3U4F28 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, Y); }
        public readonly Vector3U4F28 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, Z); }
        public readonly Vector3U4F28 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, X, W); }
        public readonly Vector3U4F28 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, X); }
        public readonly Vector3U4F28 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, Y); }
        public readonly Vector3U4F28 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, Z); }
        public readonly Vector3U4F28 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Y, W); }
        public readonly Vector3U4F28 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, X); }
        public readonly Vector3U4F28 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, Y); }
        public readonly Vector3U4F28 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, Z); }
        public readonly Vector3U4F28 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, Z, W); }
        public readonly Vector3U4F28 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, W, X); }
        public readonly Vector3U4F28 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, W, Y); }
        public readonly Vector3U4F28 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, W, Z); }
        public readonly Vector3U4F28 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Z, W, W); }
        public readonly Vector3U4F28 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, X, X); }
        public readonly Vector3U4F28 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, X, Y); }
        public readonly Vector3U4F28 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, X, Z); }
        public readonly Vector3U4F28 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, X, W); }
        public readonly Vector3U4F28 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Y, X); }
        public readonly Vector3U4F28 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Y, Y); }
        public readonly Vector3U4F28 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Y, Z); }
        public readonly Vector3U4F28 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Y, W); }
        public readonly Vector3U4F28 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Z, X); }
        public readonly Vector3U4F28 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Z, Y); }
        public readonly Vector3U4F28 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Z, Z); }
        public readonly Vector3U4F28 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, Z, W); }
        public readonly Vector3U4F28 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, W, X); }
        public readonly Vector3U4F28 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, W, Y); }
        public readonly Vector3U4F28 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, W, Z); }
        public readonly Vector3U4F28 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(W, W, W); }
        public readonly Vector4U4F28 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, X); }
        public readonly Vector4U4F28 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Y); }
        public readonly Vector4U4F28 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Z); }
        public readonly Vector4U4F28 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, W); }
        public readonly Vector4U4F28 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, X); }
        public readonly Vector4U4F28 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Y); }
        public readonly Vector4U4F28 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Z); }
        public readonly Vector4U4F28 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, W); }
        public readonly Vector4U4F28 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, X); }
        public readonly Vector4U4F28 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, Y); }
        public readonly Vector4U4F28 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, Z); }
        public readonly Vector4U4F28 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Z, W); }
        public readonly Vector4U4F28 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, W, X); }
        public readonly Vector4U4F28 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, W, Y); }
        public readonly Vector4U4F28 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, W, Z); }
        public readonly Vector4U4F28 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, W, W); }
        public readonly Vector4U4F28 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, X); }
        public readonly Vector4U4F28 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Y); }
        public readonly Vector4U4F28 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Z); }
        public readonly Vector4U4F28 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, W); }
        public readonly Vector4U4F28 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, X); }
        public readonly Vector4U4F28 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Y); }
        public readonly Vector4U4F28 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Z); }
        public readonly Vector4U4F28 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, W); }
        public readonly Vector4U4F28 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, X); }
        public readonly Vector4U4F28 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, Y); }
        public readonly Vector4U4F28 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, Z); }
        public readonly Vector4U4F28 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Z, W); }
        public readonly Vector4U4F28 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, W, X); }
        public readonly Vector4U4F28 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, W, Y); }
        public readonly Vector4U4F28 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, W, Z); }
        public readonly Vector4U4F28 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, W, W); }
        public readonly Vector4U4F28 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, X); }
        public readonly Vector4U4F28 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, Y); }
        public readonly Vector4U4F28 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, Z); }
        public readonly Vector4U4F28 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, X, W); }
        public readonly Vector4U4F28 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, X); }
        public readonly Vector4U4F28 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, Y); }
        public readonly Vector4U4F28 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, Z); }
        public readonly Vector4U4F28 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Y, W); }
        public readonly Vector4U4F28 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, X); }
        public readonly Vector4U4F28 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, Y); }
        public readonly Vector4U4F28 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, Z); }
        public readonly Vector4U4F28 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, Z, W); }
        public readonly Vector4U4F28 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, W, X); }
        public readonly Vector4U4F28 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, W, Y); }
        public readonly Vector4U4F28 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, W, Z); }
        public readonly Vector4U4F28 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Z, W, W); }
        public readonly Vector4U4F28 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, X, X); }
        public readonly Vector4U4F28 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, X, Y); }
        public readonly Vector4U4F28 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, X, Z); }
        public readonly Vector4U4F28 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, X, W); }
        public readonly Vector4U4F28 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Y, X); }
        public readonly Vector4U4F28 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Y, Y); }
        public readonly Vector4U4F28 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Y, Z); }
        public readonly Vector4U4F28 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Y, W); }
        public readonly Vector4U4F28 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Z, X); }
        public readonly Vector4U4F28 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Z, Y); }
        public readonly Vector4U4F28 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Z, Z); }
        public readonly Vector4U4F28 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, Z, W); }
        public readonly Vector4U4F28 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, W, X); }
        public readonly Vector4U4F28 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, W, Y); }
        public readonly Vector4U4F28 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, W, Z); }
        public readonly Vector4U4F28 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, W, W, W); }
        public readonly Vector4U4F28 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, X); }
        public readonly Vector4U4F28 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Y); }
        public readonly Vector4U4F28 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Z); }
        public readonly Vector4U4F28 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, W); }
        public readonly Vector4U4F28 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, X); }
        public readonly Vector4U4F28 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Y); }
        public readonly Vector4U4F28 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Z); }
        public readonly Vector4U4F28 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, W); }
        public readonly Vector4U4F28 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, X); }
        public readonly Vector4U4F28 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, Y); }
        public readonly Vector4U4F28 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, Z); }
        public readonly Vector4U4F28 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Z, W); }
        public readonly Vector4U4F28 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, W, X); }
        public readonly Vector4U4F28 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, W, Y); }
        public readonly Vector4U4F28 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, W, Z); }
        public readonly Vector4U4F28 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, W, W); }
        public readonly Vector4U4F28 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, X); }
        public readonly Vector4U4F28 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Y); }
        public readonly Vector4U4F28 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Z); }
        public readonly Vector4U4F28 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, W); }
        public readonly Vector4U4F28 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, X); }
        public readonly Vector4U4F28 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Y); }
        public readonly Vector4U4F28 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Z); }
        public readonly Vector4U4F28 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, W); }
        public readonly Vector4U4F28 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, X); }
        public readonly Vector4U4F28 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, Y); }
        public readonly Vector4U4F28 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, Z); }
        public readonly Vector4U4F28 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Z, W); }
        public readonly Vector4U4F28 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, W, X); }
        public readonly Vector4U4F28 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, W, Y); }
        public readonly Vector4U4F28 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, W, Z); }
        public readonly Vector4U4F28 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, W, W); }
        public readonly Vector4U4F28 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, X); }
        public readonly Vector4U4F28 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, Y); }
        public readonly Vector4U4F28 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, Z); }
        public readonly Vector4U4F28 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, X, W); }
        public readonly Vector4U4F28 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, X); }
        public readonly Vector4U4F28 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, Y); }
        public readonly Vector4U4F28 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, Z); }
        public readonly Vector4U4F28 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Y, W); }
        public readonly Vector4U4F28 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, X); }
        public readonly Vector4U4F28 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, Y); }
        public readonly Vector4U4F28 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, Z); }
        public readonly Vector4U4F28 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, Z, W); }
        public readonly Vector4U4F28 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, W, X); }
        public readonly Vector4U4F28 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, W, Y); }
        public readonly Vector4U4F28 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, W, Z); }
        public readonly Vector4U4F28 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Z, W, W); }
        public readonly Vector4U4F28 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, X, X); }
        public readonly Vector4U4F28 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, X, Y); }
        public readonly Vector4U4F28 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, X, Z); }
        public readonly Vector4U4F28 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, X, W); }
        public readonly Vector4U4F28 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Y, X); }
        public readonly Vector4U4F28 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Y, Y); }
        public readonly Vector4U4F28 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Y, Z); }
        public readonly Vector4U4F28 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Y, W); }
        public readonly Vector4U4F28 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Z, X); }
        public readonly Vector4U4F28 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Z, Y); }
        public readonly Vector4U4F28 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Z, Z); }
        public readonly Vector4U4F28 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, Z, W); }
        public readonly Vector4U4F28 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, W, X); }
        public readonly Vector4U4F28 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, W, Y); }
        public readonly Vector4U4F28 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, W, Z); }
        public readonly Vector4U4F28 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, W, W, W); }
        public readonly Vector4U4F28 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, X); }
        public readonly Vector4U4F28 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, Y); }
        public readonly Vector4U4F28 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, Z); }
        public readonly Vector4U4F28 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, X, W); }
        public readonly Vector4U4F28 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, X); }
        public readonly Vector4U4F28 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, Y); }
        public readonly Vector4U4F28 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, Z); }
        public readonly Vector4U4F28 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Y, W); }
        public readonly Vector4U4F28 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, X); }
        public readonly Vector4U4F28 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, Y); }
        public readonly Vector4U4F28 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, Z); }
        public readonly Vector4U4F28 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, Z, W); }
        public readonly Vector4U4F28 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, W, X); }
        public readonly Vector4U4F28 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, W, Y); }
        public readonly Vector4U4F28 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, W, Z); }
        public readonly Vector4U4F28 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, X, W, W); }
        public readonly Vector4U4F28 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, X); }
        public readonly Vector4U4F28 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, Y); }
        public readonly Vector4U4F28 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, Z); }
        public readonly Vector4U4F28 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, X, W); }
        public readonly Vector4U4F28 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, X); }
        public readonly Vector4U4F28 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, Y); }
        public readonly Vector4U4F28 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, Z); }
        public readonly Vector4U4F28 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Y, W); }
        public readonly Vector4U4F28 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, X); }
        public readonly Vector4U4F28 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, Y); }
        public readonly Vector4U4F28 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, Z); }
        public readonly Vector4U4F28 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, Z, W); }
        public readonly Vector4U4F28 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, W, X); }
        public readonly Vector4U4F28 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, W, Y); }
        public readonly Vector4U4F28 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, W, Z); }
        public readonly Vector4U4F28 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Y, W, W); }
        public readonly Vector4U4F28 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, X); }
        public readonly Vector4U4F28 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, Y); }
        public readonly Vector4U4F28 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, Z); }
        public readonly Vector4U4F28 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, X, W); }
        public readonly Vector4U4F28 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, X); }
        public readonly Vector4U4F28 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, Y); }
        public readonly Vector4U4F28 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, Z); }
        public readonly Vector4U4F28 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Y, W); }
        public readonly Vector4U4F28 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, X); }
        public readonly Vector4U4F28 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, Y); }
        public readonly Vector4U4F28 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, Z); }
        public readonly Vector4U4F28 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, Z, W); }
        public readonly Vector4U4F28 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, W, X); }
        public readonly Vector4U4F28 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, W, Y); }
        public readonly Vector4U4F28 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, W, Z); }
        public readonly Vector4U4F28 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, Z, W, W); }
        public readonly Vector4U4F28 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, X, X); }
        public readonly Vector4U4F28 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, X, Y); }
        public readonly Vector4U4F28 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, X, Z); }
        public readonly Vector4U4F28 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, X, W); }
        public readonly Vector4U4F28 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Y, X); }
        public readonly Vector4U4F28 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Y, Y); }
        public readonly Vector4U4F28 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Y, Z); }
        public readonly Vector4U4F28 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Y, W); }
        public readonly Vector4U4F28 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Z, X); }
        public readonly Vector4U4F28 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Z, Y); }
        public readonly Vector4U4F28 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Z, Z); }
        public readonly Vector4U4F28 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, Z, W); }
        public readonly Vector4U4F28 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, W, X); }
        public readonly Vector4U4F28 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, W, Y); }
        public readonly Vector4U4F28 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, W, Z); }
        public readonly Vector4U4F28 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Z, W, W, W); }
        public readonly Vector4U4F28 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, X, X); }
        public readonly Vector4U4F28 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, X, Y); }
        public readonly Vector4U4F28 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, X, Z); }
        public readonly Vector4U4F28 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, X, W); }
        public readonly Vector4U4F28 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Y, X); }
        public readonly Vector4U4F28 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Y, Y); }
        public readonly Vector4U4F28 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Y, Z); }
        public readonly Vector4U4F28 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Y, W); }
        public readonly Vector4U4F28 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Z, X); }
        public readonly Vector4U4F28 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Z, Y); }
        public readonly Vector4U4F28 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Z, Z); }
        public readonly Vector4U4F28 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, Z, W); }
        public readonly Vector4U4F28 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, W, X); }
        public readonly Vector4U4F28 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, W, Y); }
        public readonly Vector4U4F28 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, W, Z); }
        public readonly Vector4U4F28 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, X, W, W); }
        public readonly Vector4U4F28 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, X, X); }
        public readonly Vector4U4F28 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, X, Y); }
        public readonly Vector4U4F28 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, X, Z); }
        public readonly Vector4U4F28 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, X, W); }
        public readonly Vector4U4F28 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Y, X); }
        public readonly Vector4U4F28 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Y, Y); }
        public readonly Vector4U4F28 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Y, Z); }
        public readonly Vector4U4F28 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Y, W); }
        public readonly Vector4U4F28 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Z, X); }
        public readonly Vector4U4F28 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Z, Y); }
        public readonly Vector4U4F28 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Z, Z); }
        public readonly Vector4U4F28 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, Z, W); }
        public readonly Vector4U4F28 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, W, X); }
        public readonly Vector4U4F28 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, W, Y); }
        public readonly Vector4U4F28 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, W, Z); }
        public readonly Vector4U4F28 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Y, W, W); }
        public readonly Vector4U4F28 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, X, X); }
        public readonly Vector4U4F28 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, X, Y); }
        public readonly Vector4U4F28 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, X, Z); }
        public readonly Vector4U4F28 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, X, W); }
        public readonly Vector4U4F28 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Y, X); }
        public readonly Vector4U4F28 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Y, Y); }
        public readonly Vector4U4F28 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Y, Z); }
        public readonly Vector4U4F28 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Y, W); }
        public readonly Vector4U4F28 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Z, X); }
        public readonly Vector4U4F28 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Z, Y); }
        public readonly Vector4U4F28 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Z, Z); }
        public readonly Vector4U4F28 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, Z, W); }
        public readonly Vector4U4F28 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, W, X); }
        public readonly Vector4U4F28 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, W, Y); }
        public readonly Vector4U4F28 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, W, Z); }
        public readonly Vector4U4F28 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, Z, W, W); }
        public readonly Vector4U4F28 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, X, X); }
        public readonly Vector4U4F28 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, X, Y); }
        public readonly Vector4U4F28 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, X, Z); }
        public readonly Vector4U4F28 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, X, W); }
        public readonly Vector4U4F28 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Y, X); }
        public readonly Vector4U4F28 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Y, Y); }
        public readonly Vector4U4F28 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Y, Z); }
        public readonly Vector4U4F28 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Y, W); }
        public readonly Vector4U4F28 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Z, X); }
        public readonly Vector4U4F28 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Z, Y); }
        public readonly Vector4U4F28 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Z, Z); }
        public readonly Vector4U4F28 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, Z, W); }
        public readonly Vector4U4F28 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, W, X); }
        public readonly Vector4U4F28 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, W, Y); }
        public readonly Vector4U4F28 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, W, Z); }
        public readonly Vector4U4F28 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4U4F28 other)
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
        public readonly Vector4U4F28 Min(Vector4U4F28 other) => new Vector4U4F28(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 Max(Vector4U4F28 other) => new Vector4U4F28(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 Half() => new Vector4U4F28(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 Twice() => new Vector4U4F28(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 Clamp(U4F28 min, U4F28 max) => new Vector4U4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 Clamp(
            Vector4U4F28 min, Vector4U4F28 max
        ) => new Vector4U4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 WrappingAdd(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 WrappingSub(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 WrappingMul(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 WrappingAddSigned(Vector4I4F28 other) => new Vector4U4F28(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 SaturatingAdd(Vector4U4F28 other) => new Vector4U4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 SaturatingMul(U4F28 other) => new Vector4U4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector4U4F28 other) {
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
        public readonly U4F28 Dot(Vector4U4F28 other) {
            const ulong k = 1UL << 26;
            return U4F28.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U4F28 SaturatingDot(Vector4U4F28 other) {
            const ulong k = 1UL << 26;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U4F28.MaxValue;
            } else {
                return U4F28.FromBits((uint)bits);
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
        public readonly U10F54 LengthSquared() {
            return U10F54.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U4F28 LengthHalf() => U4F28.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U5F27 Length() => U5F27.FromBits(LengthInternal());

    }

    partial struct U4F28 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4U4F28 SaturatingMul(Vector4U4F28 other) => other.SaturatingMul(this);
    }
}
