using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U12F20 : IEquatable<Vector3U12F20>, IFormattable {
        // Fields
        // ---------------------------------------

        public U12F20 x;
        public U12F20 y;
        public U12F20 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U12F20 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U12F20(U12F20 x, U12F20 y, U12F20 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U12F20(U12F20 x, Vector2U12F20 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U12F20(Vector3U12F20 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U12F20(Vector2U12F20 xy, U12F20 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator +(Vector3U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator -(Vector3U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator *(Vector3U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator *(Vector3U12F20 a, U12F20 b) => new Vector3U12F20(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator *(U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator /(Vector3U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator /(Vector3U12F20 a, U12F20 b) => new Vector3U12F20(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 operator /(U12F20 a, Vector3U12F20 b) => new Vector3U12F20(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U12F20 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(x, x); }
        public readonly Vector2U12F20 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(x, y); }
        public readonly Vector2U12F20 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(x, z); }
        public readonly Vector2U12F20 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(y, x); }
        public readonly Vector2U12F20 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(y, y); }
        public readonly Vector2U12F20 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(y, z); }
        public readonly Vector2U12F20 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(z, x); }
        public readonly Vector2U12F20 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(z, y); }
        public readonly Vector2U12F20 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(z, z); }
        public readonly Vector3U12F20 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, x, x); }
        public readonly Vector3U12F20 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, x, y); }
        public readonly Vector3U12F20 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, x, z); }
        public readonly Vector3U12F20 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, y, x); }
        public readonly Vector3U12F20 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, y, y); }
        public readonly Vector3U12F20 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, y, z); }
        public readonly Vector3U12F20 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, z, x); }
        public readonly Vector3U12F20 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, z, y); }
        public readonly Vector3U12F20 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, z, z); }
        public readonly Vector3U12F20 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, x, x); }
        public readonly Vector3U12F20 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, x, y); }
        public readonly Vector3U12F20 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, x, z); }
        public readonly Vector3U12F20 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, y, x); }
        public readonly Vector3U12F20 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, y, y); }
        public readonly Vector3U12F20 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, y, z); }
        public readonly Vector3U12F20 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, z, x); }
        public readonly Vector3U12F20 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, z, y); }
        public readonly Vector3U12F20 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, z, z); }
        public readonly Vector3U12F20 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, x, x); }
        public readonly Vector3U12F20 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, x, y); }
        public readonly Vector3U12F20 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, x, z); }
        public readonly Vector3U12F20 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, y, x); }
        public readonly Vector3U12F20 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, y, y); }
        public readonly Vector3U12F20 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, y, z); }
        public readonly Vector3U12F20 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, z, x); }
        public readonly Vector3U12F20 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, z, y); }
        public readonly Vector3U12F20 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(z, z, z); }
        public readonly Vector4U12F20 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, x, x); }
        public readonly Vector4U12F20 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, x, y); }
        public readonly Vector4U12F20 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, x, z); }
        public readonly Vector4U12F20 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, y, x); }
        public readonly Vector4U12F20 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, y, y); }
        public readonly Vector4U12F20 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, y, z); }
        public readonly Vector4U12F20 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, z, x); }
        public readonly Vector4U12F20 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, z, y); }
        public readonly Vector4U12F20 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, z, z); }
        public readonly Vector4U12F20 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, x, x); }
        public readonly Vector4U12F20 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, x, y); }
        public readonly Vector4U12F20 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, x, z); }
        public readonly Vector4U12F20 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, y, x); }
        public readonly Vector4U12F20 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, y, y); }
        public readonly Vector4U12F20 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, y, z); }
        public readonly Vector4U12F20 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, z, x); }
        public readonly Vector4U12F20 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, z, y); }
        public readonly Vector4U12F20 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, z, z); }
        public readonly Vector4U12F20 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, x, x); }
        public readonly Vector4U12F20 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, x, y); }
        public readonly Vector4U12F20 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, x, z); }
        public readonly Vector4U12F20 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, y, x); }
        public readonly Vector4U12F20 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, y, y); }
        public readonly Vector4U12F20 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, y, z); }
        public readonly Vector4U12F20 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, z, x); }
        public readonly Vector4U12F20 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, z, y); }
        public readonly Vector4U12F20 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, z, z, z); }
        public readonly Vector4U12F20 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, x, x); }
        public readonly Vector4U12F20 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, x, y); }
        public readonly Vector4U12F20 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, x, z); }
        public readonly Vector4U12F20 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, y, x); }
        public readonly Vector4U12F20 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, y, y); }
        public readonly Vector4U12F20 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, y, z); }
        public readonly Vector4U12F20 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, z, x); }
        public readonly Vector4U12F20 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, z, y); }
        public readonly Vector4U12F20 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, z, z); }
        public readonly Vector4U12F20 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, x, x); }
        public readonly Vector4U12F20 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, x, y); }
        public readonly Vector4U12F20 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, x, z); }
        public readonly Vector4U12F20 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, y, x); }
        public readonly Vector4U12F20 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, y, y); }
        public readonly Vector4U12F20 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, y, z); }
        public readonly Vector4U12F20 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, z, x); }
        public readonly Vector4U12F20 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, z, y); }
        public readonly Vector4U12F20 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, z, z); }
        public readonly Vector4U12F20 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, x, x); }
        public readonly Vector4U12F20 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, x, y); }
        public readonly Vector4U12F20 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, x, z); }
        public readonly Vector4U12F20 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, y, x); }
        public readonly Vector4U12F20 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, y, y); }
        public readonly Vector4U12F20 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, y, z); }
        public readonly Vector4U12F20 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, z, x); }
        public readonly Vector4U12F20 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, z, y); }
        public readonly Vector4U12F20 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, z, z, z); }
        public readonly Vector4U12F20 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, x, x); }
        public readonly Vector4U12F20 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, x, y); }
        public readonly Vector4U12F20 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, x, z); }
        public readonly Vector4U12F20 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, y, x); }
        public readonly Vector4U12F20 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, y, y); }
        public readonly Vector4U12F20 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, y, z); }
        public readonly Vector4U12F20 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, z, x); }
        public readonly Vector4U12F20 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, z, y); }
        public readonly Vector4U12F20 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, x, z, z); }
        public readonly Vector4U12F20 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, x, x); }
        public readonly Vector4U12F20 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, x, y); }
        public readonly Vector4U12F20 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, x, z); }
        public readonly Vector4U12F20 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, y, x); }
        public readonly Vector4U12F20 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, y, y); }
        public readonly Vector4U12F20 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, y, z); }
        public readonly Vector4U12F20 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, z, x); }
        public readonly Vector4U12F20 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, z, y); }
        public readonly Vector4U12F20 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, y, z, z); }
        public readonly Vector4U12F20 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, x, x); }
        public readonly Vector4U12F20 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, x, y); }
        public readonly Vector4U12F20 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, x, z); }
        public readonly Vector4U12F20 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, y, x); }
        public readonly Vector4U12F20 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, y, y); }
        public readonly Vector4U12F20 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, y, z); }
        public readonly Vector4U12F20 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, z, x); }
        public readonly Vector4U12F20 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, z, y); }
        public readonly Vector4U12F20 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U12F20 lhs, Vector3U12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U12F20 lhs, Vector3U12F20 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U12F20({x}, {y}, {z})";

        // IEquatable<Vector3U12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U12F20 other)
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
            return $"Vector3U12F20({x}, {y}, {z})";
        }
    }
}
