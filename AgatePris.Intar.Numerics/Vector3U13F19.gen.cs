using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U13F19 : IEquatable<Vector3U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

        public U13F19 x;
        public U13F19 y;
        public U13F19 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U13F19 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, U13F19 y, U13F19 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, Vector2U13F19 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector3U13F19 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector2U13F19 xy, U13F19 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator +(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator -(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U13F19 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, x); }
        public readonly Vector2U13F19 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, y); }
        public readonly Vector2U13F19 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, z); }
        public readonly Vector2U13F19 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, x); }
        public readonly Vector2U13F19 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, y); }
        public readonly Vector2U13F19 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, z); }
        public readonly Vector2U13F19 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, x); }
        public readonly Vector2U13F19 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, y); }
        public readonly Vector2U13F19 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(z, z); }
        public readonly Vector3U13F19 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, x); }
        public readonly Vector3U13F19 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, y); }
        public readonly Vector3U13F19 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, z); }
        public readonly Vector3U13F19 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, x); }
        public readonly Vector3U13F19 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, y); }
        public readonly Vector3U13F19 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, z); }
        public readonly Vector3U13F19 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, x); }
        public readonly Vector3U13F19 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, y); }
        public readonly Vector3U13F19 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, z, z); }
        public readonly Vector3U13F19 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, x); }
        public readonly Vector3U13F19 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, y); }
        public readonly Vector3U13F19 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, z); }
        public readonly Vector3U13F19 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, x); }
        public readonly Vector3U13F19 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, y); }
        public readonly Vector3U13F19 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, z); }
        public readonly Vector3U13F19 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, x); }
        public readonly Vector3U13F19 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, y); }
        public readonly Vector3U13F19 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, z, z); }
        public readonly Vector3U13F19 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, x); }
        public readonly Vector3U13F19 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, y); }
        public readonly Vector3U13F19 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, x, z); }
        public readonly Vector3U13F19 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, x); }
        public readonly Vector3U13F19 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, y); }
        public readonly Vector3U13F19 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, y, z); }
        public readonly Vector3U13F19 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, x); }
        public readonly Vector3U13F19 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, y); }
        public readonly Vector3U13F19 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(z, z, z); }
        public readonly Vector4U13F19 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, x); }
        public readonly Vector4U13F19 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, y); }
        public readonly Vector4U13F19 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, z); }
        public readonly Vector4U13F19 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, x); }
        public readonly Vector4U13F19 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, y); }
        public readonly Vector4U13F19 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, z); }
        public readonly Vector4U13F19 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, x); }
        public readonly Vector4U13F19 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, y); }
        public readonly Vector4U13F19 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, z, z); }
        public readonly Vector4U13F19 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, x); }
        public readonly Vector4U13F19 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, y); }
        public readonly Vector4U13F19 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, z); }
        public readonly Vector4U13F19 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, x); }
        public readonly Vector4U13F19 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, y); }
        public readonly Vector4U13F19 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, z); }
        public readonly Vector4U13F19 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, x); }
        public readonly Vector4U13F19 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, y); }
        public readonly Vector4U13F19 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, z, z); }
        public readonly Vector4U13F19 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, x); }
        public readonly Vector4U13F19 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, y); }
        public readonly Vector4U13F19 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, x, z); }
        public readonly Vector4U13F19 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, x); }
        public readonly Vector4U13F19 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, y); }
        public readonly Vector4U13F19 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, y, z); }
        public readonly Vector4U13F19 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, x); }
        public readonly Vector4U13F19 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, y); }
        public readonly Vector4U13F19 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, z, z, z); }
        public readonly Vector4U13F19 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, x); }
        public readonly Vector4U13F19 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, y); }
        public readonly Vector4U13F19 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, z); }
        public readonly Vector4U13F19 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, x); }
        public readonly Vector4U13F19 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, y); }
        public readonly Vector4U13F19 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, z); }
        public readonly Vector4U13F19 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, x); }
        public readonly Vector4U13F19 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, y); }
        public readonly Vector4U13F19 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, z, z); }
        public readonly Vector4U13F19 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, x); }
        public readonly Vector4U13F19 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, y); }
        public readonly Vector4U13F19 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, z); }
        public readonly Vector4U13F19 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, x); }
        public readonly Vector4U13F19 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, y); }
        public readonly Vector4U13F19 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, z); }
        public readonly Vector4U13F19 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, x); }
        public readonly Vector4U13F19 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, y); }
        public readonly Vector4U13F19 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, z, z); }
        public readonly Vector4U13F19 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, x); }
        public readonly Vector4U13F19 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, y); }
        public readonly Vector4U13F19 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, x, z); }
        public readonly Vector4U13F19 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, x); }
        public readonly Vector4U13F19 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, y); }
        public readonly Vector4U13F19 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, y, z); }
        public readonly Vector4U13F19 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, x); }
        public readonly Vector4U13F19 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, y); }
        public readonly Vector4U13F19 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, z, z, z); }
        public readonly Vector4U13F19 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, x); }
        public readonly Vector4U13F19 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, y); }
        public readonly Vector4U13F19 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, x, z); }
        public readonly Vector4U13F19 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, x); }
        public readonly Vector4U13F19 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, y); }
        public readonly Vector4U13F19 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, y, z); }
        public readonly Vector4U13F19 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, x); }
        public readonly Vector4U13F19 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, y); }
        public readonly Vector4U13F19 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, x, z, z); }
        public readonly Vector4U13F19 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, x); }
        public readonly Vector4U13F19 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, y); }
        public readonly Vector4U13F19 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, x, z); }
        public readonly Vector4U13F19 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, x); }
        public readonly Vector4U13F19 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, y); }
        public readonly Vector4U13F19 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, y, z); }
        public readonly Vector4U13F19 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, x); }
        public readonly Vector4U13F19 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, y); }
        public readonly Vector4U13F19 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, y, z, z); }
        public readonly Vector4U13F19 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, x); }
        public readonly Vector4U13F19 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, y); }
        public readonly Vector4U13F19 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, x, z); }
        public readonly Vector4U13F19 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, x); }
        public readonly Vector4U13F19 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, y); }
        public readonly Vector4U13F19 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, y, z); }
        public readonly Vector4U13F19 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, x); }
        public readonly Vector4U13F19 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, y); }
        public readonly Vector4U13F19 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U13F19 lhs, Vector3U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U13F19 lhs, Vector3U13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U13F19({x}, {y}, {z})";

        // IEquatable<Vector3U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U13F19 other)
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
            return $"Vector3U13F19({x}, {y}, {z})";
        }
    }
}
