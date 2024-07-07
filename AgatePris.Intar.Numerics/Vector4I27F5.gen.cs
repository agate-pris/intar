using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I27F5 : IEquatable<Vector4I27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I27F5 X;
        public I27F5 Y;
        public I27F5 Z;
        public I27F5 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(I27F5 x, I27F5 y, I27F5 z, I27F5 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(I27F5 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(I27F5 x, I27F5 y, Vector2I27F5 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(I27F5 x, Vector3I27F5 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(Vector2I27F5 xy, Vector2I27F5 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(Vector4I27F5 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(I27F5 x, Vector2I27F5 yz, I27F5 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(Vector3I27F5 xyz, I27F5 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I27F5(Vector2I27F5 xy, I27F5 z, I27F5 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.Zero);
        }
        public static Vector4I27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.One);
        }
        public static Vector4I27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.One, I27F5.Zero, I27F5.Zero, I27F5.Zero);
        }
        public static Vector4I27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.Zero, I27F5.One, I27F5.Zero, I27F5.Zero);
        }
        public static Vector4I27F5 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.Zero, I27F5.Zero, I27F5.One, I27F5.Zero);
        }
        public static Vector4I27F5 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I27F5(I27F5.Zero, I27F5.Zero, I27F5.Zero, I27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator +(Vector4I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator -(Vector4I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator *(Vector4I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator *(Vector4I27F5 a, I27F5 b) => new Vector4I27F5(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator *(I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator /(Vector4I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator /(Vector4I27F5 a, I27F5 b) => new Vector4I27F5(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 operator /(I27F5 a, Vector4I27F5 b) => new Vector4I27F5(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I27F5 lhs, Vector4I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I27F5 lhs, Vector4I27F5 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I27F5 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, X); }
        public readonly Vector2I27F5 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Y); }
        public readonly Vector2I27F5 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Z); }
        public readonly Vector2I27F5 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, W); }
        public readonly Vector2I27F5 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, X); }
        public readonly Vector2I27F5 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Y); }
        public readonly Vector2I27F5 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Z); }
        public readonly Vector2I27F5 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, W); }
        public readonly Vector2I27F5 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, X); }
        public readonly Vector2I27F5 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, Y); }
        public readonly Vector2I27F5 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, Z); }
        public readonly Vector2I27F5 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Z, W); }
        public readonly Vector2I27F5 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(W, X); }
        public readonly Vector2I27F5 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(W, Y); }
        public readonly Vector2I27F5 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(W, Z); }
        public readonly Vector2I27F5 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(W, W); }
        public readonly Vector3I27F5 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, X); }
        public readonly Vector3I27F5 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Y); }
        public readonly Vector3I27F5 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Z); }
        public readonly Vector3I27F5 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, W); }
        public readonly Vector3I27F5 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, X); }
        public readonly Vector3I27F5 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Y); }
        public readonly Vector3I27F5 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Z); }
        public readonly Vector3I27F5 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, W); }
        public readonly Vector3I27F5 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, X); }
        public readonly Vector3I27F5 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, Y); }
        public readonly Vector3I27F5 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, Z); }
        public readonly Vector3I27F5 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Z, W); }
        public readonly Vector3I27F5 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, W, X); }
        public readonly Vector3I27F5 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, W, Y); }
        public readonly Vector3I27F5 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, W, Z); }
        public readonly Vector3I27F5 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, W, W); }
        public readonly Vector3I27F5 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, X); }
        public readonly Vector3I27F5 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Y); }
        public readonly Vector3I27F5 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Z); }
        public readonly Vector3I27F5 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, W); }
        public readonly Vector3I27F5 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, X); }
        public readonly Vector3I27F5 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Y); }
        public readonly Vector3I27F5 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Z); }
        public readonly Vector3I27F5 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, W); }
        public readonly Vector3I27F5 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, X); }
        public readonly Vector3I27F5 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, Y); }
        public readonly Vector3I27F5 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, Z); }
        public readonly Vector3I27F5 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Z, W); }
        public readonly Vector3I27F5 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, W, X); }
        public readonly Vector3I27F5 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, W, Y); }
        public readonly Vector3I27F5 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, W, Z); }
        public readonly Vector3I27F5 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, W, W); }
        public readonly Vector3I27F5 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, X); }
        public readonly Vector3I27F5 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, Y); }
        public readonly Vector3I27F5 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, Z); }
        public readonly Vector3I27F5 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, X, W); }
        public readonly Vector3I27F5 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, X); }
        public readonly Vector3I27F5 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, Y); }
        public readonly Vector3I27F5 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, Z); }
        public readonly Vector3I27F5 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Y, W); }
        public readonly Vector3I27F5 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, X); }
        public readonly Vector3I27F5 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, Y); }
        public readonly Vector3I27F5 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, Z); }
        public readonly Vector3I27F5 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, Z, W); }
        public readonly Vector3I27F5 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, W, X); }
        public readonly Vector3I27F5 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, W, Y); }
        public readonly Vector3I27F5 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, W, Z); }
        public readonly Vector3I27F5 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Z, W, W); }
        public readonly Vector3I27F5 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, X, X); }
        public readonly Vector3I27F5 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, X, Y); }
        public readonly Vector3I27F5 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, X, Z); }
        public readonly Vector3I27F5 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, X, W); }
        public readonly Vector3I27F5 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Y, X); }
        public readonly Vector3I27F5 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Y, Y); }
        public readonly Vector3I27F5 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Y, Z); }
        public readonly Vector3I27F5 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Y, W); }
        public readonly Vector3I27F5 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Z, X); }
        public readonly Vector3I27F5 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Z, Y); }
        public readonly Vector3I27F5 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Z, Z); }
        public readonly Vector3I27F5 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, Z, W); }
        public readonly Vector3I27F5 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, W, X); }
        public readonly Vector3I27F5 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, W, Y); }
        public readonly Vector3I27F5 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, W, Z); }
        public readonly Vector3I27F5 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(W, W, W); }
        public readonly Vector4I27F5 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, X); }
        public readonly Vector4I27F5 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Y); }
        public readonly Vector4I27F5 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Z); }
        public readonly Vector4I27F5 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, W); }
        public readonly Vector4I27F5 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, X); }
        public readonly Vector4I27F5 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Y); }
        public readonly Vector4I27F5 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Z); }
        public readonly Vector4I27F5 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, W); }
        public readonly Vector4I27F5 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, X); }
        public readonly Vector4I27F5 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, Y); }
        public readonly Vector4I27F5 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, Z); }
        public readonly Vector4I27F5 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Z, W); }
        public readonly Vector4I27F5 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, W, X); }
        public readonly Vector4I27F5 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, W, Y); }
        public readonly Vector4I27F5 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, W, Z); }
        public readonly Vector4I27F5 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, W, W); }
        public readonly Vector4I27F5 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, X); }
        public readonly Vector4I27F5 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Y); }
        public readonly Vector4I27F5 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Z); }
        public readonly Vector4I27F5 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, W); }
        public readonly Vector4I27F5 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, X); }
        public readonly Vector4I27F5 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Y); }
        public readonly Vector4I27F5 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Z); }
        public readonly Vector4I27F5 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, W); }
        public readonly Vector4I27F5 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, X); }
        public readonly Vector4I27F5 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, Y); }
        public readonly Vector4I27F5 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, Z); }
        public readonly Vector4I27F5 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Z, W); }
        public readonly Vector4I27F5 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, W, X); }
        public readonly Vector4I27F5 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, W, Y); }
        public readonly Vector4I27F5 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, W, Z); }
        public readonly Vector4I27F5 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, W, W); }
        public readonly Vector4I27F5 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, X); }
        public readonly Vector4I27F5 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, Y); }
        public readonly Vector4I27F5 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, Z); }
        public readonly Vector4I27F5 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, X, W); }
        public readonly Vector4I27F5 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, X); }
        public readonly Vector4I27F5 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, Y); }
        public readonly Vector4I27F5 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, Z); }
        public readonly Vector4I27F5 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Y, W); }
        public readonly Vector4I27F5 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, X); }
        public readonly Vector4I27F5 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, Y); }
        public readonly Vector4I27F5 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, Z); }
        public readonly Vector4I27F5 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, Z, W); }
        public readonly Vector4I27F5 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, W, X); }
        public readonly Vector4I27F5 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, W, Y); }
        public readonly Vector4I27F5 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, W, Z); }
        public readonly Vector4I27F5 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Z, W, W); }
        public readonly Vector4I27F5 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, X, X); }
        public readonly Vector4I27F5 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, X, Y); }
        public readonly Vector4I27F5 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, X, Z); }
        public readonly Vector4I27F5 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, X, W); }
        public readonly Vector4I27F5 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Y, X); }
        public readonly Vector4I27F5 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Y, Y); }
        public readonly Vector4I27F5 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Y, Z); }
        public readonly Vector4I27F5 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Y, W); }
        public readonly Vector4I27F5 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Z, X); }
        public readonly Vector4I27F5 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Z, Y); }
        public readonly Vector4I27F5 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Z, Z); }
        public readonly Vector4I27F5 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, Z, W); }
        public readonly Vector4I27F5 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, W, X); }
        public readonly Vector4I27F5 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, W, Y); }
        public readonly Vector4I27F5 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, W, Z); }
        public readonly Vector4I27F5 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, W, W, W); }
        public readonly Vector4I27F5 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, X); }
        public readonly Vector4I27F5 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Y); }
        public readonly Vector4I27F5 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Z); }
        public readonly Vector4I27F5 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, W); }
        public readonly Vector4I27F5 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, X); }
        public readonly Vector4I27F5 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Y); }
        public readonly Vector4I27F5 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Z); }
        public readonly Vector4I27F5 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, W); }
        public readonly Vector4I27F5 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, X); }
        public readonly Vector4I27F5 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, Y); }
        public readonly Vector4I27F5 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, Z); }
        public readonly Vector4I27F5 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Z, W); }
        public readonly Vector4I27F5 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, W, X); }
        public readonly Vector4I27F5 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, W, Y); }
        public readonly Vector4I27F5 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, W, Z); }
        public readonly Vector4I27F5 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, W, W); }
        public readonly Vector4I27F5 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, X); }
        public readonly Vector4I27F5 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Y); }
        public readonly Vector4I27F5 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Z); }
        public readonly Vector4I27F5 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, W); }
        public readonly Vector4I27F5 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, X); }
        public readonly Vector4I27F5 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Y); }
        public readonly Vector4I27F5 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Z); }
        public readonly Vector4I27F5 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, W); }
        public readonly Vector4I27F5 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, X); }
        public readonly Vector4I27F5 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, Y); }
        public readonly Vector4I27F5 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, Z); }
        public readonly Vector4I27F5 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Z, W); }
        public readonly Vector4I27F5 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, W, X); }
        public readonly Vector4I27F5 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, W, Y); }
        public readonly Vector4I27F5 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, W, Z); }
        public readonly Vector4I27F5 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, W, W); }
        public readonly Vector4I27F5 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, X); }
        public readonly Vector4I27F5 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, Y); }
        public readonly Vector4I27F5 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, Z); }
        public readonly Vector4I27F5 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, X, W); }
        public readonly Vector4I27F5 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, X); }
        public readonly Vector4I27F5 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, Y); }
        public readonly Vector4I27F5 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, Z); }
        public readonly Vector4I27F5 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Y, W); }
        public readonly Vector4I27F5 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, X); }
        public readonly Vector4I27F5 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, Y); }
        public readonly Vector4I27F5 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, Z); }
        public readonly Vector4I27F5 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, Z, W); }
        public readonly Vector4I27F5 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, W, X); }
        public readonly Vector4I27F5 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, W, Y); }
        public readonly Vector4I27F5 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, W, Z); }
        public readonly Vector4I27F5 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Z, W, W); }
        public readonly Vector4I27F5 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, X, X); }
        public readonly Vector4I27F5 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, X, Y); }
        public readonly Vector4I27F5 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, X, Z); }
        public readonly Vector4I27F5 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, X, W); }
        public readonly Vector4I27F5 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Y, X); }
        public readonly Vector4I27F5 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Y, Y); }
        public readonly Vector4I27F5 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Y, Z); }
        public readonly Vector4I27F5 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Y, W); }
        public readonly Vector4I27F5 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Z, X); }
        public readonly Vector4I27F5 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Z, Y); }
        public readonly Vector4I27F5 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Z, Z); }
        public readonly Vector4I27F5 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, Z, W); }
        public readonly Vector4I27F5 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, W, X); }
        public readonly Vector4I27F5 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, W, Y); }
        public readonly Vector4I27F5 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, W, Z); }
        public readonly Vector4I27F5 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, W, W, W); }
        public readonly Vector4I27F5 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, X); }
        public readonly Vector4I27F5 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, Y); }
        public readonly Vector4I27F5 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, Z); }
        public readonly Vector4I27F5 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, X, W); }
        public readonly Vector4I27F5 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, X); }
        public readonly Vector4I27F5 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, Y); }
        public readonly Vector4I27F5 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, Z); }
        public readonly Vector4I27F5 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Y, W); }
        public readonly Vector4I27F5 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, X); }
        public readonly Vector4I27F5 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, Y); }
        public readonly Vector4I27F5 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, Z); }
        public readonly Vector4I27F5 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, Z, W); }
        public readonly Vector4I27F5 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, W, X); }
        public readonly Vector4I27F5 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, W, Y); }
        public readonly Vector4I27F5 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, W, Z); }
        public readonly Vector4I27F5 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, X, W, W); }
        public readonly Vector4I27F5 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, X); }
        public readonly Vector4I27F5 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, Y); }
        public readonly Vector4I27F5 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, Z); }
        public readonly Vector4I27F5 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, X, W); }
        public readonly Vector4I27F5 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, X); }
        public readonly Vector4I27F5 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, Y); }
        public readonly Vector4I27F5 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, Z); }
        public readonly Vector4I27F5 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Y, W); }
        public readonly Vector4I27F5 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, X); }
        public readonly Vector4I27F5 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, Y); }
        public readonly Vector4I27F5 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, Z); }
        public readonly Vector4I27F5 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, Z, W); }
        public readonly Vector4I27F5 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, W, X); }
        public readonly Vector4I27F5 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, W, Y); }
        public readonly Vector4I27F5 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, W, Z); }
        public readonly Vector4I27F5 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Y, W, W); }
        public readonly Vector4I27F5 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, X); }
        public readonly Vector4I27F5 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, Y); }
        public readonly Vector4I27F5 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, Z); }
        public readonly Vector4I27F5 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, X, W); }
        public readonly Vector4I27F5 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, X); }
        public readonly Vector4I27F5 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, Y); }
        public readonly Vector4I27F5 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, Z); }
        public readonly Vector4I27F5 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Y, W); }
        public readonly Vector4I27F5 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, X); }
        public readonly Vector4I27F5 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, Y); }
        public readonly Vector4I27F5 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, Z); }
        public readonly Vector4I27F5 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, Z, W); }
        public readonly Vector4I27F5 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, W, X); }
        public readonly Vector4I27F5 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, W, Y); }
        public readonly Vector4I27F5 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, W, Z); }
        public readonly Vector4I27F5 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, Z, W, W); }
        public readonly Vector4I27F5 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, X, X); }
        public readonly Vector4I27F5 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, X, Y); }
        public readonly Vector4I27F5 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, X, Z); }
        public readonly Vector4I27F5 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, X, W); }
        public readonly Vector4I27F5 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Y, X); }
        public readonly Vector4I27F5 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Y, Y); }
        public readonly Vector4I27F5 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Y, Z); }
        public readonly Vector4I27F5 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Y, W); }
        public readonly Vector4I27F5 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Z, X); }
        public readonly Vector4I27F5 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Z, Y); }
        public readonly Vector4I27F5 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Z, Z); }
        public readonly Vector4I27F5 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, Z, W); }
        public readonly Vector4I27F5 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, W, X); }
        public readonly Vector4I27F5 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, W, Y); }
        public readonly Vector4I27F5 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, W, Z); }
        public readonly Vector4I27F5 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Z, W, W, W); }
        public readonly Vector4I27F5 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, X, X); }
        public readonly Vector4I27F5 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, X, Y); }
        public readonly Vector4I27F5 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, X, Z); }
        public readonly Vector4I27F5 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, X, W); }
        public readonly Vector4I27F5 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Y, X); }
        public readonly Vector4I27F5 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Y, Y); }
        public readonly Vector4I27F5 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Y, Z); }
        public readonly Vector4I27F5 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Y, W); }
        public readonly Vector4I27F5 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Z, X); }
        public readonly Vector4I27F5 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Z, Y); }
        public readonly Vector4I27F5 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Z, Z); }
        public readonly Vector4I27F5 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, Z, W); }
        public readonly Vector4I27F5 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, W, X); }
        public readonly Vector4I27F5 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, W, Y); }
        public readonly Vector4I27F5 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, W, Z); }
        public readonly Vector4I27F5 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, X, W, W); }
        public readonly Vector4I27F5 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, X, X); }
        public readonly Vector4I27F5 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, X, Y); }
        public readonly Vector4I27F5 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, X, Z); }
        public readonly Vector4I27F5 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, X, W); }
        public readonly Vector4I27F5 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Y, X); }
        public readonly Vector4I27F5 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Y, Y); }
        public readonly Vector4I27F5 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Y, Z); }
        public readonly Vector4I27F5 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Y, W); }
        public readonly Vector4I27F5 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Z, X); }
        public readonly Vector4I27F5 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Z, Y); }
        public readonly Vector4I27F5 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Z, Z); }
        public readonly Vector4I27F5 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, Z, W); }
        public readonly Vector4I27F5 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, W, X); }
        public readonly Vector4I27F5 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, W, Y); }
        public readonly Vector4I27F5 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, W, Z); }
        public readonly Vector4I27F5 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Y, W, W); }
        public readonly Vector4I27F5 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, X, X); }
        public readonly Vector4I27F5 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, X, Y); }
        public readonly Vector4I27F5 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, X, Z); }
        public readonly Vector4I27F5 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, X, W); }
        public readonly Vector4I27F5 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Y, X); }
        public readonly Vector4I27F5 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Y, Y); }
        public readonly Vector4I27F5 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Y, Z); }
        public readonly Vector4I27F5 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Y, W); }
        public readonly Vector4I27F5 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Z, X); }
        public readonly Vector4I27F5 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Z, Y); }
        public readonly Vector4I27F5 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Z, Z); }
        public readonly Vector4I27F5 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, Z, W); }
        public readonly Vector4I27F5 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, W, X); }
        public readonly Vector4I27F5 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, W, Y); }
        public readonly Vector4I27F5 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, W, Z); }
        public readonly Vector4I27F5 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, Z, W, W); }
        public readonly Vector4I27F5 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, X, X); }
        public readonly Vector4I27F5 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, X, Y); }
        public readonly Vector4I27F5 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, X, Z); }
        public readonly Vector4I27F5 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, X, W); }
        public readonly Vector4I27F5 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Y, X); }
        public readonly Vector4I27F5 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Y, Y); }
        public readonly Vector4I27F5 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Y, Z); }
        public readonly Vector4I27F5 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Y, W); }
        public readonly Vector4I27F5 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Z, X); }
        public readonly Vector4I27F5 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Z, Y); }
        public readonly Vector4I27F5 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Z, Z); }
        public readonly Vector4I27F5 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, Z, W); }
        public readonly Vector4I27F5 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, W, X); }
        public readonly Vector4I27F5 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, W, Y); }
        public readonly Vector4I27F5 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, W, Z); }
        public readonly Vector4I27F5 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I27F5 other)
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

        public readonly Vector4I27F5 Half() => new Vector4I27F5(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I27F5 Twice() => new Vector4I27F5(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I27F5 Clamp(I27F5 min, I27F5 max) => new Vector4I27F5(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I27F5 Clamp(
            Vector4I27F5 min, Vector4I27F5 max
        ) => new Vector4I27F5(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I27F5 SaturatingAdd(Vector4I27F5 other) => new Vector4I27F5(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I27F5 SaturatingMul(I27F5 other) => new Vector4I27F5(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I27F5 Dot(Vector4I27F5 other) {
            return
                X * other.X +
                Y * other.Y +
                Z * other.Z +
                W * other.W;
        }

    }

    partial struct I27F5 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I27F5 SaturatingMul(Vector4I27F5 other) => other.SaturatingMul(this);
    }
}
