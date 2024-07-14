using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I6F26 : IEquatable<Vector4I6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I6F26 X;
        public I6F26 Y;
        public I6F26 Z;
        public I6F26 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, I6F26 z, I6F26 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, I6F26 y, Vector2I6F26 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector3I6F26 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, Vector2I6F26 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector4I6F26 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(I6F26 x, Vector2I6F26 yz, I6F26 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector3I6F26 xyz, I6F26 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26(Vector2I6F26 xy, I6F26 z, I6F26 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.Zero);
        }
        public static Vector4I6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.One);
        }
        public static Vector4I6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.One, I6F26.Zero, I6F26.Zero, I6F26.Zero);
        }
        public static Vector4I6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.Zero, I6F26.One, I6F26.Zero, I6F26.Zero);
        }
        public static Vector4I6F26 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.Zero, I6F26.Zero, I6F26.One, I6F26.Zero);
        }
        public static Vector4I6F26 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I6F26(I6F26.Zero, I6F26.Zero, I6F26.Zero, I6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator +(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator -(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator *(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(Vector4I6F26 a, I6F26 b) => new Vector4I6F26(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 operator /(I6F26 a, Vector4I6F26 b) => new Vector4I6F26(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I6F26 lhs, Vector4I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I6F26 lhs, Vector4I6F26 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I6F26 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, X); }
        public Vector2I6F26 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, Y); }
        public Vector2I6F26 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, Z); }
        public Vector2I6F26 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, W); }
        public Vector2I6F26 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, X); }
        public Vector2I6F26 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, Y); }
        public Vector2I6F26 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, Z); }
        public Vector2I6F26 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, W); }
        public Vector2I6F26 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, X); }
        public Vector2I6F26 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, Y); }
        public Vector2I6F26 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, Z); }
        public Vector2I6F26 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Z, W); }
        public Vector2I6F26 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, X); }
        public Vector2I6F26 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, Y); }
        public Vector2I6F26 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, Z); }
        public Vector2I6F26 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(W, W); }
        public Vector3I6F26 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, X); }
        public Vector3I6F26 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, Y); }
        public Vector3I6F26 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, Z); }
        public Vector3I6F26 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, W); }
        public Vector3I6F26 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, X); }
        public Vector3I6F26 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, Y); }
        public Vector3I6F26 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, Z); }
        public Vector3I6F26 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, W); }
        public Vector3I6F26 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, X); }
        public Vector3I6F26 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, Y); }
        public Vector3I6F26 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, Z); }
        public Vector3I6F26 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Z, W); }
        public Vector3I6F26 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, X); }
        public Vector3I6F26 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, Y); }
        public Vector3I6F26 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, Z); }
        public Vector3I6F26 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, W, W); }
        public Vector3I6F26 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, X); }
        public Vector3I6F26 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, Y); }
        public Vector3I6F26 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, Z); }
        public Vector3I6F26 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, W); }
        public Vector3I6F26 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, X); }
        public Vector3I6F26 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, Y); }
        public Vector3I6F26 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, Z); }
        public Vector3I6F26 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, W); }
        public Vector3I6F26 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, X); }
        public Vector3I6F26 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, Y); }
        public Vector3I6F26 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, Z); }
        public Vector3I6F26 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Z, W); }
        public Vector3I6F26 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, X); }
        public Vector3I6F26 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, Y); }
        public Vector3I6F26 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, Z); }
        public Vector3I6F26 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, W, W); }
        public Vector3I6F26 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, X); }
        public Vector3I6F26 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, Y); }
        public Vector3I6F26 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, Z); }
        public Vector3I6F26 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, X, W); }
        public Vector3I6F26 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, X); }
        public Vector3I6F26 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, Y); }
        public Vector3I6F26 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, Z); }
        public Vector3I6F26 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Y, W); }
        public Vector3I6F26 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, X); }
        public Vector3I6F26 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, Y); }
        public Vector3I6F26 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, Z); }
        public Vector3I6F26 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, Z, W); }
        public Vector3I6F26 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, X); }
        public Vector3I6F26 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, Y); }
        public Vector3I6F26 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, Z); }
        public Vector3I6F26 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Z, W, W); }
        public Vector3I6F26 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, X); }
        public Vector3I6F26 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, Y); }
        public Vector3I6F26 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, Z); }
        public Vector3I6F26 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, X, W); }
        public Vector3I6F26 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, X); }
        public Vector3I6F26 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, Y); }
        public Vector3I6F26 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, Z); }
        public Vector3I6F26 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Y, W); }
        public Vector3I6F26 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, X); }
        public Vector3I6F26 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, Y); }
        public Vector3I6F26 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, Z); }
        public Vector3I6F26 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, Z, W); }
        public Vector3I6F26 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, X); }
        public Vector3I6F26 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, Y); }
        public Vector3I6F26 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, Z); }
        public Vector3I6F26 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(W, W, W); }
        public Vector4I6F26 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, X); }
        public Vector4I6F26 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, Y); }
        public Vector4I6F26 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, Z); }
        public Vector4I6F26 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, W); }
        public Vector4I6F26 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, X); }
        public Vector4I6F26 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, Y); }
        public Vector4I6F26 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, Z); }
        public Vector4I6F26 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, W); }
        public Vector4I6F26 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, X); }
        public Vector4I6F26 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, Y); }
        public Vector4I6F26 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, Z); }
        public Vector4I6F26 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Z, W); }
        public Vector4I6F26 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, X); }
        public Vector4I6F26 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, Y); }
        public Vector4I6F26 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, Z); }
        public Vector4I6F26 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, W, W); }
        public Vector4I6F26 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, X); }
        public Vector4I6F26 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, Y); }
        public Vector4I6F26 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, Z); }
        public Vector4I6F26 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, W); }
        public Vector4I6F26 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, X); }
        public Vector4I6F26 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, Y); }
        public Vector4I6F26 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, Z); }
        public Vector4I6F26 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, W); }
        public Vector4I6F26 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, X); }
        public Vector4I6F26 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, Y); }
        public Vector4I6F26 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, Z); }
        public Vector4I6F26 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Z, W); }
        public Vector4I6F26 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, X); }
        public Vector4I6F26 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, Y); }
        public Vector4I6F26 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, Z); }
        public Vector4I6F26 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, W, W); }
        public Vector4I6F26 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, X); }
        public Vector4I6F26 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, Y); }
        public Vector4I6F26 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, Z); }
        public Vector4I6F26 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, X, W); }
        public Vector4I6F26 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, X); }
        public Vector4I6F26 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, Y); }
        public Vector4I6F26 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, Z); }
        public Vector4I6F26 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Y, W); }
        public Vector4I6F26 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, X); }
        public Vector4I6F26 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, Y); }
        public Vector4I6F26 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, Z); }
        public Vector4I6F26 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, Z, W); }
        public Vector4I6F26 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, X); }
        public Vector4I6F26 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, Y); }
        public Vector4I6F26 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, Z); }
        public Vector4I6F26 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Z, W, W); }
        public Vector4I6F26 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, X); }
        public Vector4I6F26 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, Y); }
        public Vector4I6F26 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, Z); }
        public Vector4I6F26 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, X, W); }
        public Vector4I6F26 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, X); }
        public Vector4I6F26 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, Y); }
        public Vector4I6F26 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, Z); }
        public Vector4I6F26 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Y, W); }
        public Vector4I6F26 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, X); }
        public Vector4I6F26 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, Y); }
        public Vector4I6F26 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, Z); }
        public Vector4I6F26 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, Z, W); }
        public Vector4I6F26 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, X); }
        public Vector4I6F26 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, Y); }
        public Vector4I6F26 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, Z); }
        public Vector4I6F26 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, W, W, W); }
        public Vector4I6F26 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, X); }
        public Vector4I6F26 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, Y); }
        public Vector4I6F26 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, Z); }
        public Vector4I6F26 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, W); }
        public Vector4I6F26 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, X); }
        public Vector4I6F26 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, Y); }
        public Vector4I6F26 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, Z); }
        public Vector4I6F26 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, W); }
        public Vector4I6F26 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, X); }
        public Vector4I6F26 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, Y); }
        public Vector4I6F26 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, Z); }
        public Vector4I6F26 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Z, W); }
        public Vector4I6F26 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, X); }
        public Vector4I6F26 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, Y); }
        public Vector4I6F26 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, Z); }
        public Vector4I6F26 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, W, W); }
        public Vector4I6F26 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, X); }
        public Vector4I6F26 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, Y); }
        public Vector4I6F26 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, Z); }
        public Vector4I6F26 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, W); }
        public Vector4I6F26 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, X); }
        public Vector4I6F26 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, Y); }
        public Vector4I6F26 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, Z); }
        public Vector4I6F26 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, W); }
        public Vector4I6F26 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, X); }
        public Vector4I6F26 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, Y); }
        public Vector4I6F26 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, Z); }
        public Vector4I6F26 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Z, W); }
        public Vector4I6F26 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, X); }
        public Vector4I6F26 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, Y); }
        public Vector4I6F26 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, Z); }
        public Vector4I6F26 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, W, W); }
        public Vector4I6F26 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, X); }
        public Vector4I6F26 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, Y); }
        public Vector4I6F26 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, Z); }
        public Vector4I6F26 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, X, W); }
        public Vector4I6F26 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, X); }
        public Vector4I6F26 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, Y); }
        public Vector4I6F26 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, Z); }
        public Vector4I6F26 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Y, W); }
        public Vector4I6F26 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, X); }
        public Vector4I6F26 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, Y); }
        public Vector4I6F26 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, Z); }
        public Vector4I6F26 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, Z, W); }
        public Vector4I6F26 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, X); }
        public Vector4I6F26 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, Y); }
        public Vector4I6F26 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, Z); }
        public Vector4I6F26 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Z, W, W); }
        public Vector4I6F26 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, X); }
        public Vector4I6F26 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, Y); }
        public Vector4I6F26 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, Z); }
        public Vector4I6F26 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, X, W); }
        public Vector4I6F26 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, X); }
        public Vector4I6F26 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, Y); }
        public Vector4I6F26 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, Z); }
        public Vector4I6F26 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Y, W); }
        public Vector4I6F26 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, X); }
        public Vector4I6F26 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, Y); }
        public Vector4I6F26 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, Z); }
        public Vector4I6F26 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, Z, W); }
        public Vector4I6F26 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, X); }
        public Vector4I6F26 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, Y); }
        public Vector4I6F26 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, Z); }
        public Vector4I6F26 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, W, W, W); }
        public Vector4I6F26 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, X); }
        public Vector4I6F26 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, Y); }
        public Vector4I6F26 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, Z); }
        public Vector4I6F26 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, X, W); }
        public Vector4I6F26 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, X); }
        public Vector4I6F26 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, Y); }
        public Vector4I6F26 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, Z); }
        public Vector4I6F26 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Y, W); }
        public Vector4I6F26 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, X); }
        public Vector4I6F26 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, Y); }
        public Vector4I6F26 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, Z); }
        public Vector4I6F26 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, Z, W); }
        public Vector4I6F26 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, X); }
        public Vector4I6F26 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, Y); }
        public Vector4I6F26 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, Z); }
        public Vector4I6F26 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, X, W, W); }
        public Vector4I6F26 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, X); }
        public Vector4I6F26 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, Y); }
        public Vector4I6F26 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, Z); }
        public Vector4I6F26 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, X, W); }
        public Vector4I6F26 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, X); }
        public Vector4I6F26 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, Y); }
        public Vector4I6F26 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, Z); }
        public Vector4I6F26 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Y, W); }
        public Vector4I6F26 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, X); }
        public Vector4I6F26 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, Y); }
        public Vector4I6F26 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, Z); }
        public Vector4I6F26 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, Z, W); }
        public Vector4I6F26 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, X); }
        public Vector4I6F26 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, Y); }
        public Vector4I6F26 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, Z); }
        public Vector4I6F26 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Y, W, W); }
        public Vector4I6F26 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, X); }
        public Vector4I6F26 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, Y); }
        public Vector4I6F26 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, Z); }
        public Vector4I6F26 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, X, W); }
        public Vector4I6F26 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, X); }
        public Vector4I6F26 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, Y); }
        public Vector4I6F26 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, Z); }
        public Vector4I6F26 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Y, W); }
        public Vector4I6F26 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, X); }
        public Vector4I6F26 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, Y); }
        public Vector4I6F26 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, Z); }
        public Vector4I6F26 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, Z, W); }
        public Vector4I6F26 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, X); }
        public Vector4I6F26 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, Y); }
        public Vector4I6F26 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, Z); }
        public Vector4I6F26 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, Z, W, W); }
        public Vector4I6F26 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, X); }
        public Vector4I6F26 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, Y); }
        public Vector4I6F26 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, Z); }
        public Vector4I6F26 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, X, W); }
        public Vector4I6F26 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, X); }
        public Vector4I6F26 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, Y); }
        public Vector4I6F26 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, Z); }
        public Vector4I6F26 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Y, W); }
        public Vector4I6F26 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, X); }
        public Vector4I6F26 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, Y); }
        public Vector4I6F26 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, Z); }
        public Vector4I6F26 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, Z, W); }
        public Vector4I6F26 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, X); }
        public Vector4I6F26 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, Y); }
        public Vector4I6F26 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, Z); }
        public Vector4I6F26 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Z, W, W, W); }
        public Vector4I6F26 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, X); }
        public Vector4I6F26 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, Y); }
        public Vector4I6F26 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, Z); }
        public Vector4I6F26 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, X, W); }
        public Vector4I6F26 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, X); }
        public Vector4I6F26 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, Y); }
        public Vector4I6F26 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, Z); }
        public Vector4I6F26 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Y, W); }
        public Vector4I6F26 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, X); }
        public Vector4I6F26 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, Y); }
        public Vector4I6F26 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, Z); }
        public Vector4I6F26 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, Z, W); }
        public Vector4I6F26 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, X); }
        public Vector4I6F26 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, Y); }
        public Vector4I6F26 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, Z); }
        public Vector4I6F26 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, X, W, W); }
        public Vector4I6F26 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, X); }
        public Vector4I6F26 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, Y); }
        public Vector4I6F26 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, Z); }
        public Vector4I6F26 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, X, W); }
        public Vector4I6F26 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, X); }
        public Vector4I6F26 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, Y); }
        public Vector4I6F26 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, Z); }
        public Vector4I6F26 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Y, W); }
        public Vector4I6F26 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, X); }
        public Vector4I6F26 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, Y); }
        public Vector4I6F26 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, Z); }
        public Vector4I6F26 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, Z, W); }
        public Vector4I6F26 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, X); }
        public Vector4I6F26 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, Y); }
        public Vector4I6F26 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, Z); }
        public Vector4I6F26 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Y, W, W); }
        public Vector4I6F26 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, X); }
        public Vector4I6F26 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, Y); }
        public Vector4I6F26 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, Z); }
        public Vector4I6F26 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, X, W); }
        public Vector4I6F26 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, X); }
        public Vector4I6F26 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, Y); }
        public Vector4I6F26 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, Z); }
        public Vector4I6F26 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Y, W); }
        public Vector4I6F26 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, X); }
        public Vector4I6F26 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, Y); }
        public Vector4I6F26 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, Z); }
        public Vector4I6F26 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, Z, W); }
        public Vector4I6F26 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, X); }
        public Vector4I6F26 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, Y); }
        public Vector4I6F26 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, Z); }
        public Vector4I6F26 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, Z, W, W); }
        public Vector4I6F26 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, X); }
        public Vector4I6F26 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, Y); }
        public Vector4I6F26 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, Z); }
        public Vector4I6F26 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, X, W); }
        public Vector4I6F26 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, X); }
        public Vector4I6F26 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, Y); }
        public Vector4I6F26 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, Z); }
        public Vector4I6F26 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Y, W); }
        public Vector4I6F26 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, X); }
        public Vector4I6F26 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, Y); }
        public Vector4I6F26 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, Z); }
        public Vector4I6F26 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, Z, W); }
        public Vector4I6F26 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, X); }
        public Vector4I6F26 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, Y); }
        public Vector4I6F26 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, Z); }
        public Vector4I6F26 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I6F26 other)
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
        public Vector4I6F26 Min(Vector4I6F26 other) => new Vector4I6F26(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Max(Vector4I6F26 other) => new Vector4I6F26(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Abs() => new Vector4I6F26(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Half() => new Vector4I6F26(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Twice() => new Vector4I6F26(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Clamp(I6F26 min, I6F26 max) => new Vector4I6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 Clamp(
            Vector4I6F26 min, Vector4I6F26 max
        ) => new Vector4I6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 WrappingAdd(Vector4I6F26 other) => new Vector4I6F26(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 WrappingSub(Vector4I6F26 other) => new Vector4I6F26(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 WrappingMul(Vector4I6F26 other) => new Vector4I6F26(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 WrappingAddUnsigned(Vector4U6F26 other) => new Vector4I6F26(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 WrappingSubUnsigned(Vector4U6F26 other) => new Vector4I6F26(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 UnsignedAbs() => new Vector4U6F26(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 SaturatingAdd(Vector4I6F26 other) => new Vector4I6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 SaturatingMul(I6F26 other) => new Vector4I6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I6F26 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;
            var w = ((long)W.Bits) * other.W.Bits;

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
        public I6F26 Dot(Vector4I6F26 other) {
            const long k = 1L << 24;
            return I6F26.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F26 SaturatingDot(Vector4I6F26 other) {
            const long k = 1L << 24;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I6F26.MaxValue;
            } else if (bits < int.MinValue) {
                return I6F26.MinValue;
            } else {
                return I6F26.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

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
        public I14F50 LengthSquared() {
            return I14F50.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F26 LengthHalfUnsigned() => U6F26.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F26 LengthHalf() => I6F26.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="Length">Length</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="Length">Length</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="Length"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 LengthUnsigned() => U7F25.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I7F25 Length() => I7F25.FromBits(checked((int)LengthInternal()));

    }

    partial struct I6F26 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I6F26 SaturatingMul(Vector4I6F26 other) => other.SaturatingMul(this);
    }
}
