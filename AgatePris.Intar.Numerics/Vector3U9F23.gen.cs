using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U9F23 : IEquatable<Vector3U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

        public U9F23 x;
        public U9F23 y;
        public U9F23 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U9F23 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(U9F23 x, U9F23 y, U9F23 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(U9F23 x, Vector2U9F23 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(Vector3U9F23 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U9F23(Vector2U9F23 xy, U9F23 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator +(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator -(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(Vector3U9F23 a, U9F23 b) => new Vector3U9F23(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator *(U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(Vector3U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(Vector3U9F23 a, U9F23 b) => new Vector3U9F23(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 operator /(U9F23 a, Vector3U9F23 b) => new Vector3U9F23(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(x, x); }
        public readonly Vector2U9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(x, y); }
        public readonly Vector2U9F23 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(x, z); }
        public readonly Vector2U9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(y, x); }
        public readonly Vector2U9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(y, y); }
        public readonly Vector2U9F23 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(y, z); }
        public readonly Vector2U9F23 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(z, x); }
        public readonly Vector2U9F23 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(z, y); }
        public readonly Vector2U9F23 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(z, z); }
        public readonly Vector3U9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, x, x); }
        public readonly Vector3U9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, x, y); }
        public readonly Vector3U9F23 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, x, z); }
        public readonly Vector3U9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, y, x); }
        public readonly Vector3U9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, y, y); }
        public readonly Vector3U9F23 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, y, z); }
        public readonly Vector3U9F23 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, z, x); }
        public readonly Vector3U9F23 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, z, y); }
        public readonly Vector3U9F23 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, z, z); }
        public readonly Vector3U9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, x, x); }
        public readonly Vector3U9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, x, y); }
        public readonly Vector3U9F23 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, x, z); }
        public readonly Vector3U9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, y, x); }
        public readonly Vector3U9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, y, y); }
        public readonly Vector3U9F23 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, y, z); }
        public readonly Vector3U9F23 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, z, x); }
        public readonly Vector3U9F23 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, z, y); }
        public readonly Vector3U9F23 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, z, z); }
        public readonly Vector3U9F23 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, x, x); }
        public readonly Vector3U9F23 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, x, y); }
        public readonly Vector3U9F23 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, x, z); }
        public readonly Vector3U9F23 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, y, x); }
        public readonly Vector3U9F23 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, y, y); }
        public readonly Vector3U9F23 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, y, z); }
        public readonly Vector3U9F23 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, z, x); }
        public readonly Vector3U9F23 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, z, y); }
        public readonly Vector3U9F23 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(z, z, z); }
        public readonly Vector4U9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, x, x); }
        public readonly Vector4U9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, x, y); }
        public readonly Vector4U9F23 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, x, z); }
        public readonly Vector4U9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, y, x); }
        public readonly Vector4U9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, y, y); }
        public readonly Vector4U9F23 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, y, z); }
        public readonly Vector4U9F23 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, z, x); }
        public readonly Vector4U9F23 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, z, y); }
        public readonly Vector4U9F23 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, z, z); }
        public readonly Vector4U9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, x, x); }
        public readonly Vector4U9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, x, y); }
        public readonly Vector4U9F23 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, x, z); }
        public readonly Vector4U9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, y, x); }
        public readonly Vector4U9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, y, y); }
        public readonly Vector4U9F23 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, y, z); }
        public readonly Vector4U9F23 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, z, x); }
        public readonly Vector4U9F23 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, z, y); }
        public readonly Vector4U9F23 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, z, z); }
        public readonly Vector4U9F23 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, x, x); }
        public readonly Vector4U9F23 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, x, y); }
        public readonly Vector4U9F23 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, x, z); }
        public readonly Vector4U9F23 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, y, x); }
        public readonly Vector4U9F23 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, y, y); }
        public readonly Vector4U9F23 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, y, z); }
        public readonly Vector4U9F23 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, z, x); }
        public readonly Vector4U9F23 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, z, y); }
        public readonly Vector4U9F23 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, z, z, z); }
        public readonly Vector4U9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, x, x); }
        public readonly Vector4U9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, x, y); }
        public readonly Vector4U9F23 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, x, z); }
        public readonly Vector4U9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, y, x); }
        public readonly Vector4U9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, y, y); }
        public readonly Vector4U9F23 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, y, z); }
        public readonly Vector4U9F23 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, z, x); }
        public readonly Vector4U9F23 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, z, y); }
        public readonly Vector4U9F23 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, z, z); }
        public readonly Vector4U9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, x, x); }
        public readonly Vector4U9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, x, y); }
        public readonly Vector4U9F23 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, x, z); }
        public readonly Vector4U9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, y, x); }
        public readonly Vector4U9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, y, y); }
        public readonly Vector4U9F23 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, y, z); }
        public readonly Vector4U9F23 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, z, x); }
        public readonly Vector4U9F23 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, z, y); }
        public readonly Vector4U9F23 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, z, z); }
        public readonly Vector4U9F23 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, x, x); }
        public readonly Vector4U9F23 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, x, y); }
        public readonly Vector4U9F23 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, x, z); }
        public readonly Vector4U9F23 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, y, x); }
        public readonly Vector4U9F23 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, y, y); }
        public readonly Vector4U9F23 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, y, z); }
        public readonly Vector4U9F23 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, z, x); }
        public readonly Vector4U9F23 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, z, y); }
        public readonly Vector4U9F23 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, z, z, z); }
        public readonly Vector4U9F23 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, x, x); }
        public readonly Vector4U9F23 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, x, y); }
        public readonly Vector4U9F23 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, x, z); }
        public readonly Vector4U9F23 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, y, x); }
        public readonly Vector4U9F23 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, y, y); }
        public readonly Vector4U9F23 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, y, z); }
        public readonly Vector4U9F23 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, z, x); }
        public readonly Vector4U9F23 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, z, y); }
        public readonly Vector4U9F23 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, x, z, z); }
        public readonly Vector4U9F23 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, x, x); }
        public readonly Vector4U9F23 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, x, y); }
        public readonly Vector4U9F23 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, x, z); }
        public readonly Vector4U9F23 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, y, x); }
        public readonly Vector4U9F23 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, y, y); }
        public readonly Vector4U9F23 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, y, z); }
        public readonly Vector4U9F23 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, z, x); }
        public readonly Vector4U9F23 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, z, y); }
        public readonly Vector4U9F23 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, y, z, z); }
        public readonly Vector4U9F23 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, x, x); }
        public readonly Vector4U9F23 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, x, y); }
        public readonly Vector4U9F23 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, x, z); }
        public readonly Vector4U9F23 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, y, x); }
        public readonly Vector4U9F23 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, y, y); }
        public readonly Vector4U9F23 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, y, z); }
        public readonly Vector4U9F23 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, z, x); }
        public readonly Vector4U9F23 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, z, y); }
        public readonly Vector4U9F23 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U9F23 lhs, Vector3U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U9F23 lhs, Vector3U9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U9F23({x}, {y}, {z})";

        // IEquatable<Vector3U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U9F23 other)
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
            return $"Vector3U9F23({x}, {y}, {z})";
        }
    }
}
