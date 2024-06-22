using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U29F3 : IEquatable<Vector3U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

        public U29F3 x;
        public U29F3 y;
        public U29F3 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U29F3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, U29F3 y, U29F3 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(U29F3 x, Vector2U29F3 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector3U29F3 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U29F3(Vector2U29F3 xy, U29F3 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator +(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator -(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator *(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(Vector3U29F3 a, U29F3 b) => new Vector3U29F3(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 operator /(U29F3 a, Vector3U29F3 b) => new Vector3U29F3(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, x); }
        public readonly Vector2U29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, y); }
        public readonly Vector2U29F3 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(x, z); }
        public readonly Vector2U29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, x); }
        public readonly Vector2U29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, y); }
        public readonly Vector2U29F3 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(y, z); }
        public readonly Vector2U29F3 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, x); }
        public readonly Vector2U29F3 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, y); }
        public readonly Vector2U29F3 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(z, z); }
        public readonly Vector3U29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, x); }
        public readonly Vector3U29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, y); }
        public readonly Vector3U29F3 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, x, z); }
        public readonly Vector3U29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, x); }
        public readonly Vector3U29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, y); }
        public readonly Vector3U29F3 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, y, z); }
        public readonly Vector3U29F3 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, x); }
        public readonly Vector3U29F3 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, y); }
        public readonly Vector3U29F3 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(x, z, z); }
        public readonly Vector3U29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, x); }
        public readonly Vector3U29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, y); }
        public readonly Vector3U29F3 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, x, z); }
        public readonly Vector3U29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, x); }
        public readonly Vector3U29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, y); }
        public readonly Vector3U29F3 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, y, z); }
        public readonly Vector3U29F3 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, x); }
        public readonly Vector3U29F3 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, y); }
        public readonly Vector3U29F3 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(y, z, z); }
        public readonly Vector3U29F3 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, x); }
        public readonly Vector3U29F3 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, y); }
        public readonly Vector3U29F3 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, x, z); }
        public readonly Vector3U29F3 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, x); }
        public readonly Vector3U29F3 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, y); }
        public readonly Vector3U29F3 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, y, z); }
        public readonly Vector3U29F3 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, x); }
        public readonly Vector3U29F3 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, y); }
        public readonly Vector3U29F3 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(z, z, z); }
        public readonly Vector4U29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, x); }
        public readonly Vector4U29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, y); }
        public readonly Vector4U29F3 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, x, z); }
        public readonly Vector4U29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, x); }
        public readonly Vector4U29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, y); }
        public readonly Vector4U29F3 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, y, z); }
        public readonly Vector4U29F3 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, x); }
        public readonly Vector4U29F3 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, y); }
        public readonly Vector4U29F3 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, x, z, z); }
        public readonly Vector4U29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, x); }
        public readonly Vector4U29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, y); }
        public readonly Vector4U29F3 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, x, z); }
        public readonly Vector4U29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, x); }
        public readonly Vector4U29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, y); }
        public readonly Vector4U29F3 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, y, z); }
        public readonly Vector4U29F3 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, x); }
        public readonly Vector4U29F3 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, y); }
        public readonly Vector4U29F3 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, y, z, z); }
        public readonly Vector4U29F3 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, x); }
        public readonly Vector4U29F3 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, y); }
        public readonly Vector4U29F3 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, x, z); }
        public readonly Vector4U29F3 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, x); }
        public readonly Vector4U29F3 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, y); }
        public readonly Vector4U29F3 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, y, z); }
        public readonly Vector4U29F3 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, x); }
        public readonly Vector4U29F3 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, y); }
        public readonly Vector4U29F3 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(x, z, z, z); }
        public readonly Vector4U29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, x); }
        public readonly Vector4U29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, y); }
        public readonly Vector4U29F3 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, x, z); }
        public readonly Vector4U29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, x); }
        public readonly Vector4U29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, y); }
        public readonly Vector4U29F3 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, y, z); }
        public readonly Vector4U29F3 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, x); }
        public readonly Vector4U29F3 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, y); }
        public readonly Vector4U29F3 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, x, z, z); }
        public readonly Vector4U29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, x); }
        public readonly Vector4U29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, y); }
        public readonly Vector4U29F3 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, x, z); }
        public readonly Vector4U29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, x); }
        public readonly Vector4U29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, y); }
        public readonly Vector4U29F3 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, y, z); }
        public readonly Vector4U29F3 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, x); }
        public readonly Vector4U29F3 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, y); }
        public readonly Vector4U29F3 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, y, z, z); }
        public readonly Vector4U29F3 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, x); }
        public readonly Vector4U29F3 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, y); }
        public readonly Vector4U29F3 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, x, z); }
        public readonly Vector4U29F3 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, x); }
        public readonly Vector4U29F3 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, y); }
        public readonly Vector4U29F3 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, y, z); }
        public readonly Vector4U29F3 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, x); }
        public readonly Vector4U29F3 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, y); }
        public readonly Vector4U29F3 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(y, z, z, z); }
        public readonly Vector4U29F3 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, x); }
        public readonly Vector4U29F3 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, y); }
        public readonly Vector4U29F3 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, x, z); }
        public readonly Vector4U29F3 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, x); }
        public readonly Vector4U29F3 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, y); }
        public readonly Vector4U29F3 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, y, z); }
        public readonly Vector4U29F3 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, x); }
        public readonly Vector4U29F3 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, y); }
        public readonly Vector4U29F3 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, x, z, z); }
        public readonly Vector4U29F3 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, x); }
        public readonly Vector4U29F3 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, y); }
        public readonly Vector4U29F3 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, x, z); }
        public readonly Vector4U29F3 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, x); }
        public readonly Vector4U29F3 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, y); }
        public readonly Vector4U29F3 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, y, z); }
        public readonly Vector4U29F3 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, x); }
        public readonly Vector4U29F3 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, y); }
        public readonly Vector4U29F3 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, y, z, z); }
        public readonly Vector4U29F3 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, x); }
        public readonly Vector4U29F3 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, y); }
        public readonly Vector4U29F3 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, x, z); }
        public readonly Vector4U29F3 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, x); }
        public readonly Vector4U29F3 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, y); }
        public readonly Vector4U29F3 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, y, z); }
        public readonly Vector4U29F3 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, x); }
        public readonly Vector4U29F3 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, y); }
        public readonly Vector4U29F3 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U29F3 lhs, Vector3U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U29F3 lhs, Vector3U29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U29F3({x}, {y}, {z})";

        // IEquatable<Vector3U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U29F3 other)
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
            return $"Vector3U29F3({x}, {y}, {z})";
        }
    }
}
