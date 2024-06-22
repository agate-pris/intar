using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U10F22 : IEquatable<Vector3U10F22>, IFormattable {
        // Fields
        // ---------------------------------------

        public U10F22 x;
        public U10F22 y;
        public U10F22 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U10F22 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U10F22(U10F22 x, U10F22 y, U10F22 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U10F22(U10F22 x, Vector2U10F22 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U10F22(Vector3U10F22 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U10F22(Vector2U10F22 xy, U10F22 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator +(Vector3U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator -(Vector3U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator *(Vector3U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator *(Vector3U10F22 a, U10F22 b) => new Vector3U10F22(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator *(U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator /(Vector3U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator /(Vector3U10F22 a, U10F22 b) => new Vector3U10F22(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 operator /(U10F22 a, Vector3U10F22 b) => new Vector3U10F22(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U10F22 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(x, x); }
        public readonly Vector2U10F22 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(x, y); }
        public readonly Vector2U10F22 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(x, z); }
        public readonly Vector2U10F22 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(y, x); }
        public readonly Vector2U10F22 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(y, y); }
        public readonly Vector2U10F22 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(y, z); }
        public readonly Vector2U10F22 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(z, x); }
        public readonly Vector2U10F22 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(z, y); }
        public readonly Vector2U10F22 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(z, z); }
        public readonly Vector3U10F22 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, x, x); }
        public readonly Vector3U10F22 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, x, y); }
        public readonly Vector3U10F22 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, x, z); }
        public readonly Vector3U10F22 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, y, x); }
        public readonly Vector3U10F22 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, y, y); }
        public readonly Vector3U10F22 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, y, z); }
        public readonly Vector3U10F22 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, z, x); }
        public readonly Vector3U10F22 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, z, y); }
        public readonly Vector3U10F22 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, z, z); }
        public readonly Vector3U10F22 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, x, x); }
        public readonly Vector3U10F22 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, x, y); }
        public readonly Vector3U10F22 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, x, z); }
        public readonly Vector3U10F22 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, y, x); }
        public readonly Vector3U10F22 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, y, y); }
        public readonly Vector3U10F22 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, y, z); }
        public readonly Vector3U10F22 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, z, x); }
        public readonly Vector3U10F22 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, z, y); }
        public readonly Vector3U10F22 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, z, z); }
        public readonly Vector3U10F22 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, x, x); }
        public readonly Vector3U10F22 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, x, y); }
        public readonly Vector3U10F22 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, x, z); }
        public readonly Vector3U10F22 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, y, x); }
        public readonly Vector3U10F22 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, y, y); }
        public readonly Vector3U10F22 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, y, z); }
        public readonly Vector3U10F22 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, z, x); }
        public readonly Vector3U10F22 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, z, y); }
        public readonly Vector3U10F22 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(z, z, z); }
        public readonly Vector4U10F22 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, x, x); }
        public readonly Vector4U10F22 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, x, y); }
        public readonly Vector4U10F22 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, x, z); }
        public readonly Vector4U10F22 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, y, x); }
        public readonly Vector4U10F22 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, y, y); }
        public readonly Vector4U10F22 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, y, z); }
        public readonly Vector4U10F22 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, z, x); }
        public readonly Vector4U10F22 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, z, y); }
        public readonly Vector4U10F22 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, z, z); }
        public readonly Vector4U10F22 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, x, x); }
        public readonly Vector4U10F22 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, x, y); }
        public readonly Vector4U10F22 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, x, z); }
        public readonly Vector4U10F22 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, y, x); }
        public readonly Vector4U10F22 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, y, y); }
        public readonly Vector4U10F22 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, y, z); }
        public readonly Vector4U10F22 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, z, x); }
        public readonly Vector4U10F22 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, z, y); }
        public readonly Vector4U10F22 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, z, z); }
        public readonly Vector4U10F22 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, x, x); }
        public readonly Vector4U10F22 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, x, y); }
        public readonly Vector4U10F22 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, x, z); }
        public readonly Vector4U10F22 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, y, x); }
        public readonly Vector4U10F22 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, y, y); }
        public readonly Vector4U10F22 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, y, z); }
        public readonly Vector4U10F22 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, z, x); }
        public readonly Vector4U10F22 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, z, y); }
        public readonly Vector4U10F22 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, z, z, z); }
        public readonly Vector4U10F22 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, x, x); }
        public readonly Vector4U10F22 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, x, y); }
        public readonly Vector4U10F22 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, x, z); }
        public readonly Vector4U10F22 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, y, x); }
        public readonly Vector4U10F22 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, y, y); }
        public readonly Vector4U10F22 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, y, z); }
        public readonly Vector4U10F22 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, z, x); }
        public readonly Vector4U10F22 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, z, y); }
        public readonly Vector4U10F22 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, z, z); }
        public readonly Vector4U10F22 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, x, x); }
        public readonly Vector4U10F22 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, x, y); }
        public readonly Vector4U10F22 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, x, z); }
        public readonly Vector4U10F22 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, y, x); }
        public readonly Vector4U10F22 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, y, y); }
        public readonly Vector4U10F22 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, y, z); }
        public readonly Vector4U10F22 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, z, x); }
        public readonly Vector4U10F22 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, z, y); }
        public readonly Vector4U10F22 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, z, z); }
        public readonly Vector4U10F22 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, x, x); }
        public readonly Vector4U10F22 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, x, y); }
        public readonly Vector4U10F22 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, x, z); }
        public readonly Vector4U10F22 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, y, x); }
        public readonly Vector4U10F22 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, y, y); }
        public readonly Vector4U10F22 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, y, z); }
        public readonly Vector4U10F22 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, z, x); }
        public readonly Vector4U10F22 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, z, y); }
        public readonly Vector4U10F22 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, z, z, z); }
        public readonly Vector4U10F22 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, x, x); }
        public readonly Vector4U10F22 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, x, y); }
        public readonly Vector4U10F22 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, x, z); }
        public readonly Vector4U10F22 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, y, x); }
        public readonly Vector4U10F22 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, y, y); }
        public readonly Vector4U10F22 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, y, z); }
        public readonly Vector4U10F22 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, z, x); }
        public readonly Vector4U10F22 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, z, y); }
        public readonly Vector4U10F22 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, x, z, z); }
        public readonly Vector4U10F22 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, x, x); }
        public readonly Vector4U10F22 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, x, y); }
        public readonly Vector4U10F22 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, x, z); }
        public readonly Vector4U10F22 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, y, x); }
        public readonly Vector4U10F22 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, y, y); }
        public readonly Vector4U10F22 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, y, z); }
        public readonly Vector4U10F22 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, z, x); }
        public readonly Vector4U10F22 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, z, y); }
        public readonly Vector4U10F22 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, y, z, z); }
        public readonly Vector4U10F22 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, x, x); }
        public readonly Vector4U10F22 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, x, y); }
        public readonly Vector4U10F22 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, x, z); }
        public readonly Vector4U10F22 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, y, x); }
        public readonly Vector4U10F22 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, y, y); }
        public readonly Vector4U10F22 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, y, z); }
        public readonly Vector4U10F22 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, z, x); }
        public readonly Vector4U10F22 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, z, y); }
        public readonly Vector4U10F22 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U10F22 lhs, Vector3U10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U10F22 lhs, Vector3U10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U10F22({x}, {y}, {z})";

        // IEquatable<Vector3U10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U10F22 other)
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
            return $"Vector3U10F22({x}, {y}, {z})";
        }
    }
}
