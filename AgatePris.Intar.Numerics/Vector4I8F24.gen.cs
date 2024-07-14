using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I8F24 : IEquatable<Vector4I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I8F24 X;
        public I8F24 Y;
        public I8F24 Z;
        public I8F24 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, I8F24 y, I8F24 z, I8F24 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, I8F24 y, Vector2I8F24 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, Vector3I8F24 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector2I8F24 xy, Vector2I8F24 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector4I8F24 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(I8F24 x, Vector2I8F24 yz, I8F24 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector3I8F24 xyz, I8F24 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24(Vector2I8F24 xy, I8F24 z, I8F24 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.Zero);
        }
        public static Vector4I8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.One);
        }
        public static Vector4I8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.One, I8F24.Zero, I8F24.Zero, I8F24.Zero);
        }
        public static Vector4I8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.Zero, I8F24.One, I8F24.Zero, I8F24.Zero);
        }
        public static Vector4I8F24 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.Zero, I8F24.Zero, I8F24.One, I8F24.Zero);
        }
        public static Vector4I8F24 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I8F24(I8F24.Zero, I8F24.Zero, I8F24.Zero, I8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator +(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator -(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(Vector4I8F24 a, I8F24 b) => new Vector4I8F24(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator *(I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(Vector4I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(Vector4I8F24 a, I8F24 b) => new Vector4I8F24(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 operator /(I8F24 a, Vector4I8F24 b) => new Vector4I8F24(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I8F24 lhs, Vector4I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I8F24 lhs, Vector4I8F24 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I8F24 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, X); }
        public Vector2I8F24 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Y); }
        public Vector2I8F24 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Z); }
        public Vector2I8F24 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, W); }
        public Vector2I8F24 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, X); }
        public Vector2I8F24 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Y); }
        public Vector2I8F24 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Z); }
        public Vector2I8F24 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, W); }
        public Vector2I8F24 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, X); }
        public Vector2I8F24 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Y); }
        public Vector2I8F24 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, Z); }
        public Vector2I8F24 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Z, W); }
        public Vector2I8F24 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(W, X); }
        public Vector2I8F24 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(W, Y); }
        public Vector2I8F24 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(W, Z); }
        public Vector2I8F24 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(W, W); }
        public Vector3I8F24 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, X); }
        public Vector3I8F24 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Y); }
        public Vector3I8F24 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Z); }
        public Vector3I8F24 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, W); }
        public Vector3I8F24 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, X); }
        public Vector3I8F24 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Y); }
        public Vector3I8F24 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Z); }
        public Vector3I8F24 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, W); }
        public Vector3I8F24 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, X); }
        public Vector3I8F24 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Y); }
        public Vector3I8F24 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, Z); }
        public Vector3I8F24 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Z, W); }
        public Vector3I8F24 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, W, X); }
        public Vector3I8F24 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, W, Y); }
        public Vector3I8F24 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, W, Z); }
        public Vector3I8F24 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, W, W); }
        public Vector3I8F24 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, X); }
        public Vector3I8F24 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Y); }
        public Vector3I8F24 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Z); }
        public Vector3I8F24 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, W); }
        public Vector3I8F24 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, X); }
        public Vector3I8F24 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Y); }
        public Vector3I8F24 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Z); }
        public Vector3I8F24 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, W); }
        public Vector3I8F24 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, X); }
        public Vector3I8F24 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Y); }
        public Vector3I8F24 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, Z); }
        public Vector3I8F24 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Z, W); }
        public Vector3I8F24 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, W, X); }
        public Vector3I8F24 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, W, Y); }
        public Vector3I8F24 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, W, Z); }
        public Vector3I8F24 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, W, W); }
        public Vector3I8F24 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, X); }
        public Vector3I8F24 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Y); }
        public Vector3I8F24 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, Z); }
        public Vector3I8F24 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, X, W); }
        public Vector3I8F24 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, X); }
        public Vector3I8F24 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Y); }
        public Vector3I8F24 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, Z); }
        public Vector3I8F24 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Y, W); }
        public Vector3I8F24 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, X); }
        public Vector3I8F24 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Y); }
        public Vector3I8F24 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, Z); }
        public Vector3I8F24 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, Z, W); }
        public Vector3I8F24 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, W, X); }
        public Vector3I8F24 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, W, Y); }
        public Vector3I8F24 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, W, Z); }
        public Vector3I8F24 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Z, W, W); }
        public Vector3I8F24 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, X, X); }
        public Vector3I8F24 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, X, Y); }
        public Vector3I8F24 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, X, Z); }
        public Vector3I8F24 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, X, W); }
        public Vector3I8F24 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Y, X); }
        public Vector3I8F24 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Y, Y); }
        public Vector3I8F24 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Y, Z); }
        public Vector3I8F24 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Y, W); }
        public Vector3I8F24 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Z, X); }
        public Vector3I8F24 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Z, Y); }
        public Vector3I8F24 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Z, Z); }
        public Vector3I8F24 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, Z, W); }
        public Vector3I8F24 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, W, X); }
        public Vector3I8F24 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, W, Y); }
        public Vector3I8F24 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, W, Z); }
        public Vector3I8F24 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(W, W, W); }
        public Vector4I8F24 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, X); }
        public Vector4I8F24 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Y); }
        public Vector4I8F24 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Z); }
        public Vector4I8F24 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, W); }
        public Vector4I8F24 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, X); }
        public Vector4I8F24 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Y); }
        public Vector4I8F24 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Z); }
        public Vector4I8F24 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, W); }
        public Vector4I8F24 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, X); }
        public Vector4I8F24 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Y); }
        public Vector4I8F24 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, Z); }
        public Vector4I8F24 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Z, W); }
        public Vector4I8F24 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, W, X); }
        public Vector4I8F24 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, W, Y); }
        public Vector4I8F24 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, W, Z); }
        public Vector4I8F24 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, W, W); }
        public Vector4I8F24 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, X); }
        public Vector4I8F24 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Y); }
        public Vector4I8F24 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Z); }
        public Vector4I8F24 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, W); }
        public Vector4I8F24 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, X); }
        public Vector4I8F24 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Y); }
        public Vector4I8F24 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Z); }
        public Vector4I8F24 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, W); }
        public Vector4I8F24 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, X); }
        public Vector4I8F24 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Y); }
        public Vector4I8F24 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, Z); }
        public Vector4I8F24 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Z, W); }
        public Vector4I8F24 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, W, X); }
        public Vector4I8F24 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, W, Y); }
        public Vector4I8F24 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, W, Z); }
        public Vector4I8F24 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, W, W); }
        public Vector4I8F24 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, X); }
        public Vector4I8F24 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Y); }
        public Vector4I8F24 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, Z); }
        public Vector4I8F24 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, X, W); }
        public Vector4I8F24 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, X); }
        public Vector4I8F24 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Y); }
        public Vector4I8F24 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, Z); }
        public Vector4I8F24 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Y, W); }
        public Vector4I8F24 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, X); }
        public Vector4I8F24 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Y); }
        public Vector4I8F24 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, Z); }
        public Vector4I8F24 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, Z, W); }
        public Vector4I8F24 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, W, X); }
        public Vector4I8F24 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, W, Y); }
        public Vector4I8F24 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, W, Z); }
        public Vector4I8F24 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Z, W, W); }
        public Vector4I8F24 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, X, X); }
        public Vector4I8F24 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, X, Y); }
        public Vector4I8F24 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, X, Z); }
        public Vector4I8F24 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, X, W); }
        public Vector4I8F24 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Y, X); }
        public Vector4I8F24 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Y, Y); }
        public Vector4I8F24 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Y, Z); }
        public Vector4I8F24 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Y, W); }
        public Vector4I8F24 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Z, X); }
        public Vector4I8F24 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Z, Y); }
        public Vector4I8F24 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Z, Z); }
        public Vector4I8F24 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, Z, W); }
        public Vector4I8F24 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, W, X); }
        public Vector4I8F24 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, W, Y); }
        public Vector4I8F24 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, W, Z); }
        public Vector4I8F24 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, W, W, W); }
        public Vector4I8F24 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, X); }
        public Vector4I8F24 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Y); }
        public Vector4I8F24 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Z); }
        public Vector4I8F24 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, W); }
        public Vector4I8F24 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, X); }
        public Vector4I8F24 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Y); }
        public Vector4I8F24 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Z); }
        public Vector4I8F24 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, W); }
        public Vector4I8F24 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, X); }
        public Vector4I8F24 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Y); }
        public Vector4I8F24 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, Z); }
        public Vector4I8F24 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Z, W); }
        public Vector4I8F24 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, W, X); }
        public Vector4I8F24 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, W, Y); }
        public Vector4I8F24 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, W, Z); }
        public Vector4I8F24 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, W, W); }
        public Vector4I8F24 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, X); }
        public Vector4I8F24 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Y); }
        public Vector4I8F24 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Z); }
        public Vector4I8F24 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, W); }
        public Vector4I8F24 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, X); }
        public Vector4I8F24 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Y); }
        public Vector4I8F24 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Z); }
        public Vector4I8F24 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, W); }
        public Vector4I8F24 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, X); }
        public Vector4I8F24 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Y); }
        public Vector4I8F24 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, Z); }
        public Vector4I8F24 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Z, W); }
        public Vector4I8F24 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, W, X); }
        public Vector4I8F24 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, W, Y); }
        public Vector4I8F24 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, W, Z); }
        public Vector4I8F24 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, W, W); }
        public Vector4I8F24 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, X); }
        public Vector4I8F24 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Y); }
        public Vector4I8F24 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, Z); }
        public Vector4I8F24 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, X, W); }
        public Vector4I8F24 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, X); }
        public Vector4I8F24 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Y); }
        public Vector4I8F24 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, Z); }
        public Vector4I8F24 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Y, W); }
        public Vector4I8F24 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, X); }
        public Vector4I8F24 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Y); }
        public Vector4I8F24 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, Z); }
        public Vector4I8F24 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, Z, W); }
        public Vector4I8F24 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, W, X); }
        public Vector4I8F24 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, W, Y); }
        public Vector4I8F24 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, W, Z); }
        public Vector4I8F24 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Z, W, W); }
        public Vector4I8F24 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, X, X); }
        public Vector4I8F24 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, X, Y); }
        public Vector4I8F24 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, X, Z); }
        public Vector4I8F24 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, X, W); }
        public Vector4I8F24 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Y, X); }
        public Vector4I8F24 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Y, Y); }
        public Vector4I8F24 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Y, Z); }
        public Vector4I8F24 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Y, W); }
        public Vector4I8F24 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Z, X); }
        public Vector4I8F24 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Z, Y); }
        public Vector4I8F24 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Z, Z); }
        public Vector4I8F24 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, Z, W); }
        public Vector4I8F24 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, W, X); }
        public Vector4I8F24 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, W, Y); }
        public Vector4I8F24 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, W, Z); }
        public Vector4I8F24 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, W, W, W); }
        public Vector4I8F24 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, X); }
        public Vector4I8F24 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Y); }
        public Vector4I8F24 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, Z); }
        public Vector4I8F24 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, X, W); }
        public Vector4I8F24 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, X); }
        public Vector4I8F24 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Y); }
        public Vector4I8F24 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, Z); }
        public Vector4I8F24 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Y, W); }
        public Vector4I8F24 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, X); }
        public Vector4I8F24 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Y); }
        public Vector4I8F24 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, Z); }
        public Vector4I8F24 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, Z, W); }
        public Vector4I8F24 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, W, X); }
        public Vector4I8F24 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, W, Y); }
        public Vector4I8F24 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, W, Z); }
        public Vector4I8F24 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, X, W, W); }
        public Vector4I8F24 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, X); }
        public Vector4I8F24 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Y); }
        public Vector4I8F24 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, Z); }
        public Vector4I8F24 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, X, W); }
        public Vector4I8F24 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, X); }
        public Vector4I8F24 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Y); }
        public Vector4I8F24 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, Z); }
        public Vector4I8F24 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Y, W); }
        public Vector4I8F24 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, X); }
        public Vector4I8F24 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Y); }
        public Vector4I8F24 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, Z); }
        public Vector4I8F24 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, Z, W); }
        public Vector4I8F24 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, W, X); }
        public Vector4I8F24 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, W, Y); }
        public Vector4I8F24 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, W, Z); }
        public Vector4I8F24 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Y, W, W); }
        public Vector4I8F24 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, X); }
        public Vector4I8F24 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Y); }
        public Vector4I8F24 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, Z); }
        public Vector4I8F24 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, X, W); }
        public Vector4I8F24 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, X); }
        public Vector4I8F24 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Y); }
        public Vector4I8F24 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, Z); }
        public Vector4I8F24 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Y, W); }
        public Vector4I8F24 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, X); }
        public Vector4I8F24 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Y); }
        public Vector4I8F24 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, Z); }
        public Vector4I8F24 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, Z, W); }
        public Vector4I8F24 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, W, X); }
        public Vector4I8F24 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, W, Y); }
        public Vector4I8F24 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, W, Z); }
        public Vector4I8F24 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, Z, W, W); }
        public Vector4I8F24 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, X, X); }
        public Vector4I8F24 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, X, Y); }
        public Vector4I8F24 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, X, Z); }
        public Vector4I8F24 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, X, W); }
        public Vector4I8F24 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Y, X); }
        public Vector4I8F24 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Y, Y); }
        public Vector4I8F24 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Y, Z); }
        public Vector4I8F24 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Y, W); }
        public Vector4I8F24 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Z, X); }
        public Vector4I8F24 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Z, Y); }
        public Vector4I8F24 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Z, Z); }
        public Vector4I8F24 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, Z, W); }
        public Vector4I8F24 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, W, X); }
        public Vector4I8F24 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, W, Y); }
        public Vector4I8F24 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, W, Z); }
        public Vector4I8F24 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Z, W, W, W); }
        public Vector4I8F24 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, X, X); }
        public Vector4I8F24 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, X, Y); }
        public Vector4I8F24 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, X, Z); }
        public Vector4I8F24 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, X, W); }
        public Vector4I8F24 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Y, X); }
        public Vector4I8F24 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Y, Y); }
        public Vector4I8F24 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Y, Z); }
        public Vector4I8F24 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Y, W); }
        public Vector4I8F24 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Z, X); }
        public Vector4I8F24 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Z, Y); }
        public Vector4I8F24 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Z, Z); }
        public Vector4I8F24 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, Z, W); }
        public Vector4I8F24 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, W, X); }
        public Vector4I8F24 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, W, Y); }
        public Vector4I8F24 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, W, Z); }
        public Vector4I8F24 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, X, W, W); }
        public Vector4I8F24 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, X, X); }
        public Vector4I8F24 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, X, Y); }
        public Vector4I8F24 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, X, Z); }
        public Vector4I8F24 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, X, W); }
        public Vector4I8F24 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Y, X); }
        public Vector4I8F24 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Y, Y); }
        public Vector4I8F24 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Y, Z); }
        public Vector4I8F24 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Y, W); }
        public Vector4I8F24 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Z, X); }
        public Vector4I8F24 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Z, Y); }
        public Vector4I8F24 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Z, Z); }
        public Vector4I8F24 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, Z, W); }
        public Vector4I8F24 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, W, X); }
        public Vector4I8F24 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, W, Y); }
        public Vector4I8F24 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, W, Z); }
        public Vector4I8F24 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Y, W, W); }
        public Vector4I8F24 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, X, X); }
        public Vector4I8F24 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, X, Y); }
        public Vector4I8F24 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, X, Z); }
        public Vector4I8F24 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, X, W); }
        public Vector4I8F24 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Y, X); }
        public Vector4I8F24 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Y, Y); }
        public Vector4I8F24 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Y, Z); }
        public Vector4I8F24 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Y, W); }
        public Vector4I8F24 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Z, X); }
        public Vector4I8F24 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Z, Y); }
        public Vector4I8F24 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Z, Z); }
        public Vector4I8F24 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, Z, W); }
        public Vector4I8F24 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, W, X); }
        public Vector4I8F24 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, W, Y); }
        public Vector4I8F24 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, W, Z); }
        public Vector4I8F24 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, Z, W, W); }
        public Vector4I8F24 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, X, X); }
        public Vector4I8F24 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, X, Y); }
        public Vector4I8F24 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, X, Z); }
        public Vector4I8F24 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, X, W); }
        public Vector4I8F24 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Y, X); }
        public Vector4I8F24 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Y, Y); }
        public Vector4I8F24 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Y, Z); }
        public Vector4I8F24 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Y, W); }
        public Vector4I8F24 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Z, X); }
        public Vector4I8F24 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Z, Y); }
        public Vector4I8F24 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Z, Z); }
        public Vector4I8F24 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, Z, W); }
        public Vector4I8F24 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, W, X); }
        public Vector4I8F24 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, W, Y); }
        public Vector4I8F24 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, W, Z); }
        public Vector4I8F24 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I8F24 other)
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
        public Vector4I8F24 Min(Vector4I8F24 other) => new Vector4I8F24(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Max(Vector4I8F24 other) => new Vector4I8F24(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Abs() => new Vector4I8F24(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Half() => new Vector4I8F24(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Twice() => new Vector4I8F24(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Clamp(I8F24 min, I8F24 max) => new Vector4I8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 Clamp(
            Vector4I8F24 min, Vector4I8F24 max
        ) => new Vector4I8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 WrappingAdd(Vector4I8F24 other) => new Vector4I8F24(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 WrappingSub(Vector4I8F24 other) => new Vector4I8F24(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 WrappingMul(Vector4I8F24 other) => new Vector4I8F24(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 WrappingAddUnsigned(Vector4U8F24 other) => new Vector4I8F24(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 WrappingSubUnsigned(Vector4U8F24 other) => new Vector4I8F24(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 UnsignedAbs() => new Vector4U8F24(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 SaturatingAdd(Vector4I8F24 other) => new Vector4I8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 SaturatingMul(I8F24 other) => new Vector4I8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I8F24 other) {
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
        public I8F24 Dot(Vector4I8F24 other) {
            const long k = 1L << 22;
            return I8F24.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 SaturatingDot(Vector4I8F24 other) {
            const long k = 1L << 22;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I8F24.MaxValue;
            } else if (bits < int.MinValue) {
                return I8F24.MinValue;
            } else {
                return I8F24.FromBits((int)bits);
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
        public I18F46 LengthSquared() {
            return I18F46.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 LengthHalf() => I8F24.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23 Length() => I9F23.FromBits(LengthInternal());

    }

    partial struct I8F24 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F24 SaturatingMul(Vector4I8F24 other) => other.SaturatingMul(this);
    }
}
