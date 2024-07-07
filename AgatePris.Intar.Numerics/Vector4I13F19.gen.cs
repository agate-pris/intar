using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I13F19 : IEquatable<Vector4I13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I13F19 X;
        public I13F19 Y;
        public I13F19 Z;
        public I13F19 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(I13F19 x, I13F19 y, I13F19 z, I13F19 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(I13F19 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(I13F19 x, I13F19 y, Vector2I13F19 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(I13F19 x, Vector3I13F19 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(Vector2I13F19 xy, Vector2I13F19 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(Vector4I13F19 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(I13F19 x, Vector2I13F19 yz, I13F19 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(Vector3I13F19 xyz, I13F19 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I13F19(Vector2I13F19 xy, I13F19 z, I13F19 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.Zero);
        }
        public static Vector4I13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.One);
        }
        public static Vector4I13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.One, I13F19.Zero, I13F19.Zero, I13F19.Zero);
        }
        public static Vector4I13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.Zero, I13F19.One, I13F19.Zero, I13F19.Zero);
        }
        public static Vector4I13F19 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.Zero, I13F19.Zero, I13F19.One, I13F19.Zero);
        }
        public static Vector4I13F19 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I13F19(I13F19.Zero, I13F19.Zero, I13F19.Zero, I13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator +(Vector4I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator -(Vector4I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator *(Vector4I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator *(Vector4I13F19 a, I13F19 b) => new Vector4I13F19(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator *(I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator /(Vector4I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator /(Vector4I13F19 a, I13F19 b) => new Vector4I13F19(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 operator /(I13F19 a, Vector4I13F19 b) => new Vector4I13F19(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I13F19 lhs, Vector4I13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I13F19 lhs, Vector4I13F19 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I13F19 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, X); }
        public readonly Vector2I13F19 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, Y); }
        public readonly Vector2I13F19 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, Z); }
        public readonly Vector2I13F19 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, W); }
        public readonly Vector2I13F19 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, X); }
        public readonly Vector2I13F19 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, Y); }
        public readonly Vector2I13F19 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, Z); }
        public readonly Vector2I13F19 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, W); }
        public readonly Vector2I13F19 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, X); }
        public readonly Vector2I13F19 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, Y); }
        public readonly Vector2I13F19 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, Z); }
        public readonly Vector2I13F19 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Z, W); }
        public readonly Vector2I13F19 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(W, X); }
        public readonly Vector2I13F19 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(W, Y); }
        public readonly Vector2I13F19 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(W, Z); }
        public readonly Vector2I13F19 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(W, W); }
        public readonly Vector3I13F19 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, X); }
        public readonly Vector3I13F19 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, Y); }
        public readonly Vector3I13F19 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, Z); }
        public readonly Vector3I13F19 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, W); }
        public readonly Vector3I13F19 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, X); }
        public readonly Vector3I13F19 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, Y); }
        public readonly Vector3I13F19 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, Z); }
        public readonly Vector3I13F19 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, W); }
        public readonly Vector3I13F19 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, X); }
        public readonly Vector3I13F19 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, Y); }
        public readonly Vector3I13F19 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, Z); }
        public readonly Vector3I13F19 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Z, W); }
        public readonly Vector3I13F19 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, W, X); }
        public readonly Vector3I13F19 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, W, Y); }
        public readonly Vector3I13F19 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, W, Z); }
        public readonly Vector3I13F19 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, W, W); }
        public readonly Vector3I13F19 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, X); }
        public readonly Vector3I13F19 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, Y); }
        public readonly Vector3I13F19 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, Z); }
        public readonly Vector3I13F19 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, W); }
        public readonly Vector3I13F19 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, X); }
        public readonly Vector3I13F19 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, Y); }
        public readonly Vector3I13F19 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, Z); }
        public readonly Vector3I13F19 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, W); }
        public readonly Vector3I13F19 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, X); }
        public readonly Vector3I13F19 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, Y); }
        public readonly Vector3I13F19 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, Z); }
        public readonly Vector3I13F19 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Z, W); }
        public readonly Vector3I13F19 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, W, X); }
        public readonly Vector3I13F19 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, W, Y); }
        public readonly Vector3I13F19 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, W, Z); }
        public readonly Vector3I13F19 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, W, W); }
        public readonly Vector3I13F19 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, X); }
        public readonly Vector3I13F19 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, Y); }
        public readonly Vector3I13F19 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, Z); }
        public readonly Vector3I13F19 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, X, W); }
        public readonly Vector3I13F19 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, X); }
        public readonly Vector3I13F19 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, Y); }
        public readonly Vector3I13F19 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, Z); }
        public readonly Vector3I13F19 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Y, W); }
        public readonly Vector3I13F19 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, X); }
        public readonly Vector3I13F19 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, Y); }
        public readonly Vector3I13F19 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, Z); }
        public readonly Vector3I13F19 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, Z, W); }
        public readonly Vector3I13F19 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, W, X); }
        public readonly Vector3I13F19 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, W, Y); }
        public readonly Vector3I13F19 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, W, Z); }
        public readonly Vector3I13F19 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Z, W, W); }
        public readonly Vector3I13F19 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, X, X); }
        public readonly Vector3I13F19 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, X, Y); }
        public readonly Vector3I13F19 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, X, Z); }
        public readonly Vector3I13F19 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, X, W); }
        public readonly Vector3I13F19 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Y, X); }
        public readonly Vector3I13F19 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Y, Y); }
        public readonly Vector3I13F19 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Y, Z); }
        public readonly Vector3I13F19 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Y, W); }
        public readonly Vector3I13F19 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Z, X); }
        public readonly Vector3I13F19 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Z, Y); }
        public readonly Vector3I13F19 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Z, Z); }
        public readonly Vector3I13F19 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, Z, W); }
        public readonly Vector3I13F19 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, W, X); }
        public readonly Vector3I13F19 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, W, Y); }
        public readonly Vector3I13F19 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, W, Z); }
        public readonly Vector3I13F19 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(W, W, W); }
        public readonly Vector4I13F19 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, X); }
        public readonly Vector4I13F19 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, Y); }
        public readonly Vector4I13F19 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, Z); }
        public readonly Vector4I13F19 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, W); }
        public readonly Vector4I13F19 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, X); }
        public readonly Vector4I13F19 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, Y); }
        public readonly Vector4I13F19 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, Z); }
        public readonly Vector4I13F19 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, W); }
        public readonly Vector4I13F19 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, X); }
        public readonly Vector4I13F19 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, Y); }
        public readonly Vector4I13F19 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, Z); }
        public readonly Vector4I13F19 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Z, W); }
        public readonly Vector4I13F19 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, W, X); }
        public readonly Vector4I13F19 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, W, Y); }
        public readonly Vector4I13F19 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, W, Z); }
        public readonly Vector4I13F19 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, W, W); }
        public readonly Vector4I13F19 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, X); }
        public readonly Vector4I13F19 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, Y); }
        public readonly Vector4I13F19 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, Z); }
        public readonly Vector4I13F19 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, W); }
        public readonly Vector4I13F19 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, X); }
        public readonly Vector4I13F19 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, Y); }
        public readonly Vector4I13F19 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, Z); }
        public readonly Vector4I13F19 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, W); }
        public readonly Vector4I13F19 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, X); }
        public readonly Vector4I13F19 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, Y); }
        public readonly Vector4I13F19 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, Z); }
        public readonly Vector4I13F19 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Z, W); }
        public readonly Vector4I13F19 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, W, X); }
        public readonly Vector4I13F19 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, W, Y); }
        public readonly Vector4I13F19 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, W, Z); }
        public readonly Vector4I13F19 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, W, W); }
        public readonly Vector4I13F19 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, X); }
        public readonly Vector4I13F19 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, Y); }
        public readonly Vector4I13F19 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, Z); }
        public readonly Vector4I13F19 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, X, W); }
        public readonly Vector4I13F19 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, X); }
        public readonly Vector4I13F19 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, Y); }
        public readonly Vector4I13F19 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, Z); }
        public readonly Vector4I13F19 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Y, W); }
        public readonly Vector4I13F19 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, X); }
        public readonly Vector4I13F19 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, Y); }
        public readonly Vector4I13F19 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, Z); }
        public readonly Vector4I13F19 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, Z, W); }
        public readonly Vector4I13F19 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, W, X); }
        public readonly Vector4I13F19 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, W, Y); }
        public readonly Vector4I13F19 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, W, Z); }
        public readonly Vector4I13F19 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Z, W, W); }
        public readonly Vector4I13F19 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, X, X); }
        public readonly Vector4I13F19 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, X, Y); }
        public readonly Vector4I13F19 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, X, Z); }
        public readonly Vector4I13F19 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, X, W); }
        public readonly Vector4I13F19 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Y, X); }
        public readonly Vector4I13F19 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Y, Y); }
        public readonly Vector4I13F19 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Y, Z); }
        public readonly Vector4I13F19 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Y, W); }
        public readonly Vector4I13F19 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Z, X); }
        public readonly Vector4I13F19 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Z, Y); }
        public readonly Vector4I13F19 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Z, Z); }
        public readonly Vector4I13F19 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, Z, W); }
        public readonly Vector4I13F19 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, W, X); }
        public readonly Vector4I13F19 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, W, Y); }
        public readonly Vector4I13F19 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, W, Z); }
        public readonly Vector4I13F19 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, W, W, W); }
        public readonly Vector4I13F19 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, X); }
        public readonly Vector4I13F19 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, Y); }
        public readonly Vector4I13F19 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, Z); }
        public readonly Vector4I13F19 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, W); }
        public readonly Vector4I13F19 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, X); }
        public readonly Vector4I13F19 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, Y); }
        public readonly Vector4I13F19 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, Z); }
        public readonly Vector4I13F19 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, W); }
        public readonly Vector4I13F19 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, X); }
        public readonly Vector4I13F19 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, Y); }
        public readonly Vector4I13F19 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, Z); }
        public readonly Vector4I13F19 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Z, W); }
        public readonly Vector4I13F19 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, W, X); }
        public readonly Vector4I13F19 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, W, Y); }
        public readonly Vector4I13F19 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, W, Z); }
        public readonly Vector4I13F19 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, W, W); }
        public readonly Vector4I13F19 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, X); }
        public readonly Vector4I13F19 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, Y); }
        public readonly Vector4I13F19 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, Z); }
        public readonly Vector4I13F19 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, W); }
        public readonly Vector4I13F19 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, X); }
        public readonly Vector4I13F19 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, Y); }
        public readonly Vector4I13F19 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, Z); }
        public readonly Vector4I13F19 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, W); }
        public readonly Vector4I13F19 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, X); }
        public readonly Vector4I13F19 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, Y); }
        public readonly Vector4I13F19 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, Z); }
        public readonly Vector4I13F19 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Z, W); }
        public readonly Vector4I13F19 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, W, X); }
        public readonly Vector4I13F19 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, W, Y); }
        public readonly Vector4I13F19 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, W, Z); }
        public readonly Vector4I13F19 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, W, W); }
        public readonly Vector4I13F19 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, X); }
        public readonly Vector4I13F19 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, Y); }
        public readonly Vector4I13F19 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, Z); }
        public readonly Vector4I13F19 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, X, W); }
        public readonly Vector4I13F19 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, X); }
        public readonly Vector4I13F19 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, Y); }
        public readonly Vector4I13F19 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, Z); }
        public readonly Vector4I13F19 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Y, W); }
        public readonly Vector4I13F19 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, X); }
        public readonly Vector4I13F19 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, Y); }
        public readonly Vector4I13F19 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, Z); }
        public readonly Vector4I13F19 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, Z, W); }
        public readonly Vector4I13F19 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, W, X); }
        public readonly Vector4I13F19 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, W, Y); }
        public readonly Vector4I13F19 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, W, Z); }
        public readonly Vector4I13F19 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Z, W, W); }
        public readonly Vector4I13F19 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, X, X); }
        public readonly Vector4I13F19 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, X, Y); }
        public readonly Vector4I13F19 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, X, Z); }
        public readonly Vector4I13F19 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, X, W); }
        public readonly Vector4I13F19 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Y, X); }
        public readonly Vector4I13F19 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Y, Y); }
        public readonly Vector4I13F19 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Y, Z); }
        public readonly Vector4I13F19 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Y, W); }
        public readonly Vector4I13F19 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Z, X); }
        public readonly Vector4I13F19 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Z, Y); }
        public readonly Vector4I13F19 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Z, Z); }
        public readonly Vector4I13F19 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, Z, W); }
        public readonly Vector4I13F19 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, W, X); }
        public readonly Vector4I13F19 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, W, Y); }
        public readonly Vector4I13F19 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, W, Z); }
        public readonly Vector4I13F19 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, W, W, W); }
        public readonly Vector4I13F19 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, X); }
        public readonly Vector4I13F19 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, Y); }
        public readonly Vector4I13F19 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, Z); }
        public readonly Vector4I13F19 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, X, W); }
        public readonly Vector4I13F19 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, X); }
        public readonly Vector4I13F19 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, Y); }
        public readonly Vector4I13F19 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, Z); }
        public readonly Vector4I13F19 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Y, W); }
        public readonly Vector4I13F19 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, X); }
        public readonly Vector4I13F19 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, Y); }
        public readonly Vector4I13F19 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, Z); }
        public readonly Vector4I13F19 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, Z, W); }
        public readonly Vector4I13F19 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, W, X); }
        public readonly Vector4I13F19 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, W, Y); }
        public readonly Vector4I13F19 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, W, Z); }
        public readonly Vector4I13F19 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, X, W, W); }
        public readonly Vector4I13F19 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, X); }
        public readonly Vector4I13F19 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, Y); }
        public readonly Vector4I13F19 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, Z); }
        public readonly Vector4I13F19 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, X, W); }
        public readonly Vector4I13F19 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, X); }
        public readonly Vector4I13F19 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, Y); }
        public readonly Vector4I13F19 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, Z); }
        public readonly Vector4I13F19 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Y, W); }
        public readonly Vector4I13F19 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, X); }
        public readonly Vector4I13F19 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, Y); }
        public readonly Vector4I13F19 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, Z); }
        public readonly Vector4I13F19 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, Z, W); }
        public readonly Vector4I13F19 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, W, X); }
        public readonly Vector4I13F19 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, W, Y); }
        public readonly Vector4I13F19 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, W, Z); }
        public readonly Vector4I13F19 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Y, W, W); }
        public readonly Vector4I13F19 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, X); }
        public readonly Vector4I13F19 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, Y); }
        public readonly Vector4I13F19 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, Z); }
        public readonly Vector4I13F19 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, X, W); }
        public readonly Vector4I13F19 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, X); }
        public readonly Vector4I13F19 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, Y); }
        public readonly Vector4I13F19 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, Z); }
        public readonly Vector4I13F19 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Y, W); }
        public readonly Vector4I13F19 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, X); }
        public readonly Vector4I13F19 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, Y); }
        public readonly Vector4I13F19 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, Z); }
        public readonly Vector4I13F19 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, Z, W); }
        public readonly Vector4I13F19 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, W, X); }
        public readonly Vector4I13F19 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, W, Y); }
        public readonly Vector4I13F19 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, W, Z); }
        public readonly Vector4I13F19 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, Z, W, W); }
        public readonly Vector4I13F19 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, X, X); }
        public readonly Vector4I13F19 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, X, Y); }
        public readonly Vector4I13F19 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, X, Z); }
        public readonly Vector4I13F19 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, X, W); }
        public readonly Vector4I13F19 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Y, X); }
        public readonly Vector4I13F19 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Y, Y); }
        public readonly Vector4I13F19 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Y, Z); }
        public readonly Vector4I13F19 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Y, W); }
        public readonly Vector4I13F19 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Z, X); }
        public readonly Vector4I13F19 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Z, Y); }
        public readonly Vector4I13F19 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Z, Z); }
        public readonly Vector4I13F19 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, Z, W); }
        public readonly Vector4I13F19 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, W, X); }
        public readonly Vector4I13F19 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, W, Y); }
        public readonly Vector4I13F19 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, W, Z); }
        public readonly Vector4I13F19 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Z, W, W, W); }
        public readonly Vector4I13F19 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, X, X); }
        public readonly Vector4I13F19 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, X, Y); }
        public readonly Vector4I13F19 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, X, Z); }
        public readonly Vector4I13F19 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, X, W); }
        public readonly Vector4I13F19 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Y, X); }
        public readonly Vector4I13F19 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Y, Y); }
        public readonly Vector4I13F19 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Y, Z); }
        public readonly Vector4I13F19 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Y, W); }
        public readonly Vector4I13F19 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Z, X); }
        public readonly Vector4I13F19 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Z, Y); }
        public readonly Vector4I13F19 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Z, Z); }
        public readonly Vector4I13F19 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, Z, W); }
        public readonly Vector4I13F19 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, W, X); }
        public readonly Vector4I13F19 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, W, Y); }
        public readonly Vector4I13F19 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, W, Z); }
        public readonly Vector4I13F19 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, X, W, W); }
        public readonly Vector4I13F19 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, X, X); }
        public readonly Vector4I13F19 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, X, Y); }
        public readonly Vector4I13F19 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, X, Z); }
        public readonly Vector4I13F19 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, X, W); }
        public readonly Vector4I13F19 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Y, X); }
        public readonly Vector4I13F19 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Y, Y); }
        public readonly Vector4I13F19 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Y, Z); }
        public readonly Vector4I13F19 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Y, W); }
        public readonly Vector4I13F19 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Z, X); }
        public readonly Vector4I13F19 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Z, Y); }
        public readonly Vector4I13F19 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Z, Z); }
        public readonly Vector4I13F19 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, Z, W); }
        public readonly Vector4I13F19 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, W, X); }
        public readonly Vector4I13F19 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, W, Y); }
        public readonly Vector4I13F19 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, W, Z); }
        public readonly Vector4I13F19 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Y, W, W); }
        public readonly Vector4I13F19 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, X, X); }
        public readonly Vector4I13F19 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, X, Y); }
        public readonly Vector4I13F19 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, X, Z); }
        public readonly Vector4I13F19 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, X, W); }
        public readonly Vector4I13F19 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Y, X); }
        public readonly Vector4I13F19 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Y, Y); }
        public readonly Vector4I13F19 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Y, Z); }
        public readonly Vector4I13F19 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Y, W); }
        public readonly Vector4I13F19 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Z, X); }
        public readonly Vector4I13F19 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Z, Y); }
        public readonly Vector4I13F19 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Z, Z); }
        public readonly Vector4I13F19 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, Z, W); }
        public readonly Vector4I13F19 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, W, X); }
        public readonly Vector4I13F19 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, W, Y); }
        public readonly Vector4I13F19 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, W, Z); }
        public readonly Vector4I13F19 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, Z, W, W); }
        public readonly Vector4I13F19 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, X, X); }
        public readonly Vector4I13F19 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, X, Y); }
        public readonly Vector4I13F19 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, X, Z); }
        public readonly Vector4I13F19 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, X, W); }
        public readonly Vector4I13F19 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Y, X); }
        public readonly Vector4I13F19 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Y, Y); }
        public readonly Vector4I13F19 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Y, Z); }
        public readonly Vector4I13F19 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Y, W); }
        public readonly Vector4I13F19 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Z, X); }
        public readonly Vector4I13F19 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Z, Y); }
        public readonly Vector4I13F19 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Z, Z); }
        public readonly Vector4I13F19 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, Z, W); }
        public readonly Vector4I13F19 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, W, X); }
        public readonly Vector4I13F19 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, W, Y); }
        public readonly Vector4I13F19 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, W, Z); }
        public readonly Vector4I13F19 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(W, W, W, W); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector4I13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector4I13F19 other)
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

        public readonly Vector4I13F19 Half() => new Vector4I13F19(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        public readonly Vector4I13F19 Twice() => new Vector4I13F19(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        public readonly Vector4I13F19 Clamp(I13F19 min, I13F19 max) => new Vector4I13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        public readonly Vector4I13F19 Clamp(
            Vector4I13F19 min, Vector4I13F19 max
        ) => new Vector4I13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I13F19 SaturatingAdd(Vector4I13F19 other) => new Vector4I13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I13F19 SaturatingMul(I13F19 other) => new Vector4I13F19(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I13F19 Dot(Vector4I13F19 other) {
            return
                X * other.X +
                Y * other.Y +
                Z * other.Z +
                W * other.W;
        }

    }

    partial struct I13F19 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector4I13F19 SaturatingMul(Vector4I13F19 other) => other.SaturatingMul(this);
    }
}
