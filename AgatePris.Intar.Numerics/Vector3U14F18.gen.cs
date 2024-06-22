using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U14F18 : IEquatable<Vector3U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

        public U14F18 x;
        public U14F18 y;
        public U14F18 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U14F18 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U14F18(U14F18 x, U14F18 y, U14F18 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U14F18(U14F18 x, Vector2U14F18 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U14F18(Vector3U14F18 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U14F18(Vector2U14F18 xy, U14F18 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator +(Vector3U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator -(Vector3U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator *(Vector3U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator *(Vector3U14F18 a, U14F18 b) => new Vector3U14F18(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator *(U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator /(Vector3U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator /(Vector3U14F18 a, U14F18 b) => new Vector3U14F18(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 operator /(U14F18 a, Vector3U14F18 b) => new Vector3U14F18(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, x); }
        public readonly Vector2U14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, y); }
        public readonly Vector2U14F18 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, z); }
        public readonly Vector2U14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, x); }
        public readonly Vector2U14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, y); }
        public readonly Vector2U14F18 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, z); }
        public readonly Vector2U14F18 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, x); }
        public readonly Vector2U14F18 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, y); }
        public readonly Vector2U14F18 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(z, z); }
        public readonly Vector3U14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, x); }
        public readonly Vector3U14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, y); }
        public readonly Vector3U14F18 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, z); }
        public readonly Vector3U14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, x); }
        public readonly Vector3U14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, y); }
        public readonly Vector3U14F18 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, z); }
        public readonly Vector3U14F18 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, x); }
        public readonly Vector3U14F18 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, y); }
        public readonly Vector3U14F18 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, z, z); }
        public readonly Vector3U14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, x); }
        public readonly Vector3U14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, y); }
        public readonly Vector3U14F18 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, z); }
        public readonly Vector3U14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, x); }
        public readonly Vector3U14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, y); }
        public readonly Vector3U14F18 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, z); }
        public readonly Vector3U14F18 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, x); }
        public readonly Vector3U14F18 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, y); }
        public readonly Vector3U14F18 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, z, z); }
        public readonly Vector3U14F18 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, x); }
        public readonly Vector3U14F18 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, y); }
        public readonly Vector3U14F18 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, x, z); }
        public readonly Vector3U14F18 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, x); }
        public readonly Vector3U14F18 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, y); }
        public readonly Vector3U14F18 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, y, z); }
        public readonly Vector3U14F18 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, x); }
        public readonly Vector3U14F18 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, y); }
        public readonly Vector3U14F18 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(z, z, z); }
        public readonly Vector4U14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, x); }
        public readonly Vector4U14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, y); }
        public readonly Vector4U14F18 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, z); }
        public readonly Vector4U14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, x); }
        public readonly Vector4U14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, y); }
        public readonly Vector4U14F18 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, z); }
        public readonly Vector4U14F18 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, x); }
        public readonly Vector4U14F18 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, y); }
        public readonly Vector4U14F18 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, z, z); }
        public readonly Vector4U14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, x); }
        public readonly Vector4U14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, y); }
        public readonly Vector4U14F18 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, z); }
        public readonly Vector4U14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, x); }
        public readonly Vector4U14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, y); }
        public readonly Vector4U14F18 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, z); }
        public readonly Vector4U14F18 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, x); }
        public readonly Vector4U14F18 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, y); }
        public readonly Vector4U14F18 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, z, z); }
        public readonly Vector4U14F18 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, x); }
        public readonly Vector4U14F18 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, y); }
        public readonly Vector4U14F18 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, x, z); }
        public readonly Vector4U14F18 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, x); }
        public readonly Vector4U14F18 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, y); }
        public readonly Vector4U14F18 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, y, z); }
        public readonly Vector4U14F18 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, x); }
        public readonly Vector4U14F18 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, y); }
        public readonly Vector4U14F18 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, z, z, z); }
        public readonly Vector4U14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, x); }
        public readonly Vector4U14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, y); }
        public readonly Vector4U14F18 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, z); }
        public readonly Vector4U14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, x); }
        public readonly Vector4U14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, y); }
        public readonly Vector4U14F18 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, z); }
        public readonly Vector4U14F18 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, x); }
        public readonly Vector4U14F18 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, y); }
        public readonly Vector4U14F18 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, z, z); }
        public readonly Vector4U14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, x); }
        public readonly Vector4U14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, y); }
        public readonly Vector4U14F18 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, z); }
        public readonly Vector4U14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, x); }
        public readonly Vector4U14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, y); }
        public readonly Vector4U14F18 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, z); }
        public readonly Vector4U14F18 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, x); }
        public readonly Vector4U14F18 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, y); }
        public readonly Vector4U14F18 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, z, z); }
        public readonly Vector4U14F18 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, x); }
        public readonly Vector4U14F18 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, y); }
        public readonly Vector4U14F18 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, x, z); }
        public readonly Vector4U14F18 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, x); }
        public readonly Vector4U14F18 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, y); }
        public readonly Vector4U14F18 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, y, z); }
        public readonly Vector4U14F18 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, x); }
        public readonly Vector4U14F18 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, y); }
        public readonly Vector4U14F18 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, z, z, z); }
        public readonly Vector4U14F18 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, x); }
        public readonly Vector4U14F18 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, y); }
        public readonly Vector4U14F18 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, x, z); }
        public readonly Vector4U14F18 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, x); }
        public readonly Vector4U14F18 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, y); }
        public readonly Vector4U14F18 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, y, z); }
        public readonly Vector4U14F18 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, x); }
        public readonly Vector4U14F18 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, y); }
        public readonly Vector4U14F18 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, x, z, z); }
        public readonly Vector4U14F18 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, x); }
        public readonly Vector4U14F18 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, y); }
        public readonly Vector4U14F18 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, x, z); }
        public readonly Vector4U14F18 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, x); }
        public readonly Vector4U14F18 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, y); }
        public readonly Vector4U14F18 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, y, z); }
        public readonly Vector4U14F18 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, x); }
        public readonly Vector4U14F18 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, y); }
        public readonly Vector4U14F18 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, y, z, z); }
        public readonly Vector4U14F18 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, x); }
        public readonly Vector4U14F18 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, y); }
        public readonly Vector4U14F18 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, x, z); }
        public readonly Vector4U14F18 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, x); }
        public readonly Vector4U14F18 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, y); }
        public readonly Vector4U14F18 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, y, z); }
        public readonly Vector4U14F18 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, x); }
        public readonly Vector4U14F18 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, y); }
        public readonly Vector4U14F18 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U14F18 lhs, Vector3U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U14F18 lhs, Vector3U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U14F18({x}, {y}, {z})";

        // IEquatable<Vector3U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U14F18 other)
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
            return $"Vector3U14F18({x}, {y}, {z})";
        }
    }
}
