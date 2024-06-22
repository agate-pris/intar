using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U6F26 : IEquatable<Vector3U6F26>, IFormattable {
        // Fields
        // ---------------------------------------

        public U6F26 x;
        public U6F26 y;
        public U6F26 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U6F26 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(U6F26 x, U6F26 y, U6F26 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(U6F26 x, Vector2U6F26 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(Vector3U6F26 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26(Vector2U6F26 xy, U6F26 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator +(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator -(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(Vector3U6F26 a, U6F26 b) => new Vector3U6F26(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator *(U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(Vector3U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(Vector3U6F26 a, U6F26 b) => new Vector3U6F26(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 operator /(U6F26 a, Vector3U6F26 b) => new Vector3U6F26(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U6F26 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(x, x); }
        public readonly Vector2U6F26 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(x, y); }
        public readonly Vector2U6F26 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(x, z); }
        public readonly Vector2U6F26 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(y, x); }
        public readonly Vector2U6F26 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(y, y); }
        public readonly Vector2U6F26 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(y, z); }
        public readonly Vector2U6F26 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(z, x); }
        public readonly Vector2U6F26 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(z, y); }
        public readonly Vector2U6F26 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(z, z); }
        public readonly Vector3U6F26 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, x, x); }
        public readonly Vector3U6F26 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, x, y); }
        public readonly Vector3U6F26 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, x, z); }
        public readonly Vector3U6F26 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, y, x); }
        public readonly Vector3U6F26 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, y, y); }
        public readonly Vector3U6F26 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, y, z); }
        public readonly Vector3U6F26 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, z, x); }
        public readonly Vector3U6F26 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, z, y); }
        public readonly Vector3U6F26 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(x, z, z); }
        public readonly Vector3U6F26 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, x, x); }
        public readonly Vector3U6F26 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, x, y); }
        public readonly Vector3U6F26 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, x, z); }
        public readonly Vector3U6F26 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, y, x); }
        public readonly Vector3U6F26 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, y, y); }
        public readonly Vector3U6F26 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, y, z); }
        public readonly Vector3U6F26 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, z, x); }
        public readonly Vector3U6F26 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, z, y); }
        public readonly Vector3U6F26 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(y, z, z); }
        public readonly Vector3U6F26 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, x, x); }
        public readonly Vector3U6F26 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, x, y); }
        public readonly Vector3U6F26 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, x, z); }
        public readonly Vector3U6F26 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, y, x); }
        public readonly Vector3U6F26 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, y, y); }
        public readonly Vector3U6F26 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, y, z); }
        public readonly Vector3U6F26 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, z, x); }
        public readonly Vector3U6F26 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, z, y); }
        public readonly Vector3U6F26 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(z, z, z); }
        public readonly Vector4U6F26 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, x, x); }
        public readonly Vector4U6F26 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, x, y); }
        public readonly Vector4U6F26 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, x, z); }
        public readonly Vector4U6F26 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, y, x); }
        public readonly Vector4U6F26 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, y, y); }
        public readonly Vector4U6F26 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, y, z); }
        public readonly Vector4U6F26 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, z, x); }
        public readonly Vector4U6F26 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, z, y); }
        public readonly Vector4U6F26 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, x, z, z); }
        public readonly Vector4U6F26 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, x, x); }
        public readonly Vector4U6F26 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, x, y); }
        public readonly Vector4U6F26 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, x, z); }
        public readonly Vector4U6F26 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, y, x); }
        public readonly Vector4U6F26 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, y, y); }
        public readonly Vector4U6F26 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, y, z); }
        public readonly Vector4U6F26 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, z, x); }
        public readonly Vector4U6F26 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, z, y); }
        public readonly Vector4U6F26 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, y, z, z); }
        public readonly Vector4U6F26 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, x, x); }
        public readonly Vector4U6F26 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, x, y); }
        public readonly Vector4U6F26 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, x, z); }
        public readonly Vector4U6F26 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, y, x); }
        public readonly Vector4U6F26 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, y, y); }
        public readonly Vector4U6F26 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, y, z); }
        public readonly Vector4U6F26 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, z, x); }
        public readonly Vector4U6F26 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, z, y); }
        public readonly Vector4U6F26 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(x, z, z, z); }
        public readonly Vector4U6F26 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, x, x); }
        public readonly Vector4U6F26 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, x, y); }
        public readonly Vector4U6F26 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, x, z); }
        public readonly Vector4U6F26 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, y, x); }
        public readonly Vector4U6F26 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, y, y); }
        public readonly Vector4U6F26 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, y, z); }
        public readonly Vector4U6F26 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, z, x); }
        public readonly Vector4U6F26 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, z, y); }
        public readonly Vector4U6F26 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, x, z, z); }
        public readonly Vector4U6F26 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, x, x); }
        public readonly Vector4U6F26 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, x, y); }
        public readonly Vector4U6F26 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, x, z); }
        public readonly Vector4U6F26 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, y, x); }
        public readonly Vector4U6F26 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, y, y); }
        public readonly Vector4U6F26 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, y, z); }
        public readonly Vector4U6F26 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, z, x); }
        public readonly Vector4U6F26 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, z, y); }
        public readonly Vector4U6F26 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, y, z, z); }
        public readonly Vector4U6F26 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, x, x); }
        public readonly Vector4U6F26 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, x, y); }
        public readonly Vector4U6F26 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, x, z); }
        public readonly Vector4U6F26 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, y, x); }
        public readonly Vector4U6F26 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, y, y); }
        public readonly Vector4U6F26 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, y, z); }
        public readonly Vector4U6F26 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, z, x); }
        public readonly Vector4U6F26 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, z, y); }
        public readonly Vector4U6F26 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(y, z, z, z); }
        public readonly Vector4U6F26 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, x, x); }
        public readonly Vector4U6F26 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, x, y); }
        public readonly Vector4U6F26 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, x, z); }
        public readonly Vector4U6F26 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, y, x); }
        public readonly Vector4U6F26 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, y, y); }
        public readonly Vector4U6F26 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, y, z); }
        public readonly Vector4U6F26 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, z, x); }
        public readonly Vector4U6F26 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, z, y); }
        public readonly Vector4U6F26 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, x, z, z); }
        public readonly Vector4U6F26 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, x, x); }
        public readonly Vector4U6F26 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, x, y); }
        public readonly Vector4U6F26 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, x, z); }
        public readonly Vector4U6F26 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, y, x); }
        public readonly Vector4U6F26 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, y, y); }
        public readonly Vector4U6F26 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, y, z); }
        public readonly Vector4U6F26 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, z, x); }
        public readonly Vector4U6F26 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, z, y); }
        public readonly Vector4U6F26 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, y, z, z); }
        public readonly Vector4U6F26 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, x, x); }
        public readonly Vector4U6F26 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, x, y); }
        public readonly Vector4U6F26 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, x, z); }
        public readonly Vector4U6F26 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, y, x); }
        public readonly Vector4U6F26 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, y, y); }
        public readonly Vector4U6F26 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, y, z); }
        public readonly Vector4U6F26 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, z, x); }
        public readonly Vector4U6F26 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, z, y); }
        public readonly Vector4U6F26 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U6F26 lhs, Vector3U6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U6F26 lhs, Vector3U6F26 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U6F26({x}, {y}, {z})";

        // IEquatable<Vector3U6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U6F26 other)
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
            return $"Vector3U6F26({x}, {y}, {z})";
        }
    }
}
