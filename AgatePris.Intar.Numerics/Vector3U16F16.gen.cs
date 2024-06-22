using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U16F16 : IEquatable<Vector3U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

        public U16F16 x;
        public U16F16 y;
        public U16F16 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(U16F16 x, U16F16 y, U16F16 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(U16F16 x, Vector2U16F16 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(Vector3U16F16 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U16F16(Vector2U16F16 xy, U16F16 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator +(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator -(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(Vector3U16F16 a, U16F16 b) => new Vector3U16F16(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator *(U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(Vector3U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(Vector3U16F16 a, U16F16 b) => new Vector3U16F16(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 operator /(U16F16 a, Vector3U16F16 b) => new Vector3U16F16(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, x); }
        public readonly Vector2U16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, y); }
        public readonly Vector2U16F16 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, z); }
        public readonly Vector2U16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, x); }
        public readonly Vector2U16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, y); }
        public readonly Vector2U16F16 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, z); }
        public readonly Vector2U16F16 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, x); }
        public readonly Vector2U16F16 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, y); }
        public readonly Vector2U16F16 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(z, z); }
        public readonly Vector3U16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, x); }
        public readonly Vector3U16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, y); }
        public readonly Vector3U16F16 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, z); }
        public readonly Vector3U16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, x); }
        public readonly Vector3U16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, y); }
        public readonly Vector3U16F16 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, z); }
        public readonly Vector3U16F16 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, x); }
        public readonly Vector3U16F16 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, y); }
        public readonly Vector3U16F16 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, z, z); }
        public readonly Vector3U16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, x); }
        public readonly Vector3U16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, y); }
        public readonly Vector3U16F16 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, z); }
        public readonly Vector3U16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, x); }
        public readonly Vector3U16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, y); }
        public readonly Vector3U16F16 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, z); }
        public readonly Vector3U16F16 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, x); }
        public readonly Vector3U16F16 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, y); }
        public readonly Vector3U16F16 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, z, z); }
        public readonly Vector3U16F16 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, x); }
        public readonly Vector3U16F16 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, y); }
        public readonly Vector3U16F16 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, x, z); }
        public readonly Vector3U16F16 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, x); }
        public readonly Vector3U16F16 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, y); }
        public readonly Vector3U16F16 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, y, z); }
        public readonly Vector3U16F16 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, x); }
        public readonly Vector3U16F16 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, y); }
        public readonly Vector3U16F16 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(z, z, z); }
        public readonly Vector4U16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, x); }
        public readonly Vector4U16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, y); }
        public readonly Vector4U16F16 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, z); }
        public readonly Vector4U16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, x); }
        public readonly Vector4U16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, y); }
        public readonly Vector4U16F16 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, z); }
        public readonly Vector4U16F16 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, x); }
        public readonly Vector4U16F16 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, y); }
        public readonly Vector4U16F16 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, z, z); }
        public readonly Vector4U16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, x); }
        public readonly Vector4U16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, y); }
        public readonly Vector4U16F16 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, z); }
        public readonly Vector4U16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, x); }
        public readonly Vector4U16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, y); }
        public readonly Vector4U16F16 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, z); }
        public readonly Vector4U16F16 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, x); }
        public readonly Vector4U16F16 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, y); }
        public readonly Vector4U16F16 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, z, z); }
        public readonly Vector4U16F16 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, x); }
        public readonly Vector4U16F16 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, y); }
        public readonly Vector4U16F16 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, x, z); }
        public readonly Vector4U16F16 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, x); }
        public readonly Vector4U16F16 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, y); }
        public readonly Vector4U16F16 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, y, z); }
        public readonly Vector4U16F16 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, x); }
        public readonly Vector4U16F16 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, y); }
        public readonly Vector4U16F16 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, z, z, z); }
        public readonly Vector4U16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, x); }
        public readonly Vector4U16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, y); }
        public readonly Vector4U16F16 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, z); }
        public readonly Vector4U16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, x); }
        public readonly Vector4U16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, y); }
        public readonly Vector4U16F16 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, z); }
        public readonly Vector4U16F16 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, x); }
        public readonly Vector4U16F16 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, y); }
        public readonly Vector4U16F16 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, z, z); }
        public readonly Vector4U16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, x); }
        public readonly Vector4U16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, y); }
        public readonly Vector4U16F16 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, z); }
        public readonly Vector4U16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, x); }
        public readonly Vector4U16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, y); }
        public readonly Vector4U16F16 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, z); }
        public readonly Vector4U16F16 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, x); }
        public readonly Vector4U16F16 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, y); }
        public readonly Vector4U16F16 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, z, z); }
        public readonly Vector4U16F16 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, x); }
        public readonly Vector4U16F16 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, y); }
        public readonly Vector4U16F16 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, x, z); }
        public readonly Vector4U16F16 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, x); }
        public readonly Vector4U16F16 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, y); }
        public readonly Vector4U16F16 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, y, z); }
        public readonly Vector4U16F16 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, x); }
        public readonly Vector4U16F16 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, y); }
        public readonly Vector4U16F16 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, z, z, z); }
        public readonly Vector4U16F16 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, x); }
        public readonly Vector4U16F16 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, y); }
        public readonly Vector4U16F16 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, x, z); }
        public readonly Vector4U16F16 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, x); }
        public readonly Vector4U16F16 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, y); }
        public readonly Vector4U16F16 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, y, z); }
        public readonly Vector4U16F16 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, x); }
        public readonly Vector4U16F16 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, y); }
        public readonly Vector4U16F16 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, x, z, z); }
        public readonly Vector4U16F16 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, x); }
        public readonly Vector4U16F16 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, y); }
        public readonly Vector4U16F16 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, x, z); }
        public readonly Vector4U16F16 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, x); }
        public readonly Vector4U16F16 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, y); }
        public readonly Vector4U16F16 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, y, z); }
        public readonly Vector4U16F16 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, x); }
        public readonly Vector4U16F16 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, y); }
        public readonly Vector4U16F16 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, y, z, z); }
        public readonly Vector4U16F16 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, x); }
        public readonly Vector4U16F16 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, y); }
        public readonly Vector4U16F16 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, x, z); }
        public readonly Vector4U16F16 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, x); }
        public readonly Vector4U16F16 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, y); }
        public readonly Vector4U16F16 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, y, z); }
        public readonly Vector4U16F16 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, x); }
        public readonly Vector4U16F16 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, y); }
        public readonly Vector4U16F16 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U16F16 lhs, Vector3U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U16F16 lhs, Vector3U16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U16F16({x}, {y}, {z})";

        // IEquatable<Vector3U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U16F16 other)
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
            return $"Vector3U16F16({x}, {y}, {z})";
        }
    }
}
