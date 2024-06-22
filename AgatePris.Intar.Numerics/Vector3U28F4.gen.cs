using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U28F4 : IEquatable<Vector3U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

        public U28F4 x;
        public U28F4 y;
        public U28F4 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U28F4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(U28F4 x, U28F4 y, U28F4 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(U28F4 x, Vector2U28F4 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(Vector3U28F4 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U28F4(Vector2U28F4 xy, U28F4 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator +(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator -(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(Vector3U28F4 a, U28F4 b) => new Vector3U28F4(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator *(U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(Vector3U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(Vector3U28F4 a, U28F4 b) => new Vector3U28F4(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 operator /(U28F4 a, Vector3U28F4 b) => new Vector3U28F4(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, x); }
        public readonly Vector2U28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, y); }
        public readonly Vector2U28F4 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(x, z); }
        public readonly Vector2U28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, x); }
        public readonly Vector2U28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, y); }
        public readonly Vector2U28F4 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(y, z); }
        public readonly Vector2U28F4 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, x); }
        public readonly Vector2U28F4 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, y); }
        public readonly Vector2U28F4 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(z, z); }
        public readonly Vector3U28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, x); }
        public readonly Vector3U28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, y); }
        public readonly Vector3U28F4 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, x, z); }
        public readonly Vector3U28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, x); }
        public readonly Vector3U28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, y); }
        public readonly Vector3U28F4 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, y, z); }
        public readonly Vector3U28F4 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, x); }
        public readonly Vector3U28F4 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, y); }
        public readonly Vector3U28F4 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(x, z, z); }
        public readonly Vector3U28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, x); }
        public readonly Vector3U28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, y); }
        public readonly Vector3U28F4 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, x, z); }
        public readonly Vector3U28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, x); }
        public readonly Vector3U28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, y); }
        public readonly Vector3U28F4 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, y, z); }
        public readonly Vector3U28F4 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, x); }
        public readonly Vector3U28F4 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, y); }
        public readonly Vector3U28F4 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(y, z, z); }
        public readonly Vector3U28F4 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, x); }
        public readonly Vector3U28F4 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, y); }
        public readonly Vector3U28F4 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, x, z); }
        public readonly Vector3U28F4 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, x); }
        public readonly Vector3U28F4 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, y); }
        public readonly Vector3U28F4 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, y, z); }
        public readonly Vector3U28F4 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, x); }
        public readonly Vector3U28F4 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, y); }
        public readonly Vector3U28F4 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(z, z, z); }
        public readonly Vector4U28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, x); }
        public readonly Vector4U28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, y); }
        public readonly Vector4U28F4 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, x, z); }
        public readonly Vector4U28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, x); }
        public readonly Vector4U28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, y); }
        public readonly Vector4U28F4 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, y, z); }
        public readonly Vector4U28F4 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, x); }
        public readonly Vector4U28F4 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, y); }
        public readonly Vector4U28F4 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, x, z, z); }
        public readonly Vector4U28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, x); }
        public readonly Vector4U28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, y); }
        public readonly Vector4U28F4 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, x, z); }
        public readonly Vector4U28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, x); }
        public readonly Vector4U28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, y); }
        public readonly Vector4U28F4 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, y, z); }
        public readonly Vector4U28F4 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, x); }
        public readonly Vector4U28F4 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, y); }
        public readonly Vector4U28F4 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, y, z, z); }
        public readonly Vector4U28F4 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, x); }
        public readonly Vector4U28F4 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, y); }
        public readonly Vector4U28F4 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, x, z); }
        public readonly Vector4U28F4 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, x); }
        public readonly Vector4U28F4 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, y); }
        public readonly Vector4U28F4 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, y, z); }
        public readonly Vector4U28F4 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, x); }
        public readonly Vector4U28F4 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, y); }
        public readonly Vector4U28F4 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(x, z, z, z); }
        public readonly Vector4U28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, x); }
        public readonly Vector4U28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, y); }
        public readonly Vector4U28F4 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, x, z); }
        public readonly Vector4U28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, x); }
        public readonly Vector4U28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, y); }
        public readonly Vector4U28F4 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, y, z); }
        public readonly Vector4U28F4 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, x); }
        public readonly Vector4U28F4 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, y); }
        public readonly Vector4U28F4 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, x, z, z); }
        public readonly Vector4U28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, x); }
        public readonly Vector4U28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, y); }
        public readonly Vector4U28F4 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, x, z); }
        public readonly Vector4U28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, x); }
        public readonly Vector4U28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, y); }
        public readonly Vector4U28F4 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, y, z); }
        public readonly Vector4U28F4 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, x); }
        public readonly Vector4U28F4 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, y); }
        public readonly Vector4U28F4 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, y, z, z); }
        public readonly Vector4U28F4 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, x); }
        public readonly Vector4U28F4 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, y); }
        public readonly Vector4U28F4 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, x, z); }
        public readonly Vector4U28F4 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, x); }
        public readonly Vector4U28F4 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, y); }
        public readonly Vector4U28F4 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, y, z); }
        public readonly Vector4U28F4 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, x); }
        public readonly Vector4U28F4 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, y); }
        public readonly Vector4U28F4 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(y, z, z, z); }
        public readonly Vector4U28F4 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, x); }
        public readonly Vector4U28F4 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, y); }
        public readonly Vector4U28F4 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, x, z); }
        public readonly Vector4U28F4 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, x); }
        public readonly Vector4U28F4 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, y); }
        public readonly Vector4U28F4 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, y, z); }
        public readonly Vector4U28F4 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, x); }
        public readonly Vector4U28F4 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, y); }
        public readonly Vector4U28F4 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, x, z, z); }
        public readonly Vector4U28F4 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, x); }
        public readonly Vector4U28F4 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, y); }
        public readonly Vector4U28F4 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, x, z); }
        public readonly Vector4U28F4 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, x); }
        public readonly Vector4U28F4 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, y); }
        public readonly Vector4U28F4 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, y, z); }
        public readonly Vector4U28F4 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, x); }
        public readonly Vector4U28F4 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, y); }
        public readonly Vector4U28F4 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, y, z, z); }
        public readonly Vector4U28F4 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, x); }
        public readonly Vector4U28F4 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, y); }
        public readonly Vector4U28F4 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, x, z); }
        public readonly Vector4U28F4 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, x); }
        public readonly Vector4U28F4 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, y); }
        public readonly Vector4U28F4 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, y, z); }
        public readonly Vector4U28F4 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, x); }
        public readonly Vector4U28F4 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, y); }
        public readonly Vector4U28F4 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U28F4 lhs, Vector3U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U28F4 lhs, Vector3U28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U28F4({x}, {y}, {z})";

        // IEquatable<Vector3U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U28F4 other)
            => other.x == x
            && other.y == y
            && other.z == z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            var z = this.z.ToString(format, formatProvider);
            return $"Vector3U28F4({x}, {y}, {z})";
        }
    }
}
