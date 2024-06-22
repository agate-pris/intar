using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U17F15 : IEquatable<Vector3U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

        public U17F15 x;
        public U17F15 y;
        public U17F15 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U17F15 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, U17F15 y, U17F15 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(U17F15 x, Vector2U17F15 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector3U17F15 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15(Vector2U17F15 xy, U17F15 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator +(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator -(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator *(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(Vector3U17F15 a, U17F15 b) => new Vector3U17F15(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 operator /(U17F15 a, Vector3U17F15 b) => new Vector3U17F15(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, x); }
        public readonly Vector2U17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, y); }
        public readonly Vector2U17F15 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(x, z); }
        public readonly Vector2U17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, x); }
        public readonly Vector2U17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, y); }
        public readonly Vector2U17F15 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(y, z); }
        public readonly Vector2U17F15 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, x); }
        public readonly Vector2U17F15 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, y); }
        public readonly Vector2U17F15 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(z, z); }
        public readonly Vector3U17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, x); }
        public readonly Vector3U17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, y); }
        public readonly Vector3U17F15 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, x, z); }
        public readonly Vector3U17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, x); }
        public readonly Vector3U17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, y); }
        public readonly Vector3U17F15 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, y, z); }
        public readonly Vector3U17F15 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, x); }
        public readonly Vector3U17F15 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, y); }
        public readonly Vector3U17F15 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(x, z, z); }
        public readonly Vector3U17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, x); }
        public readonly Vector3U17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, y); }
        public readonly Vector3U17F15 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, x, z); }
        public readonly Vector3U17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, x); }
        public readonly Vector3U17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, y); }
        public readonly Vector3U17F15 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, y, z); }
        public readonly Vector3U17F15 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, x); }
        public readonly Vector3U17F15 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, y); }
        public readonly Vector3U17F15 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(y, z, z); }
        public readonly Vector3U17F15 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, x); }
        public readonly Vector3U17F15 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, y); }
        public readonly Vector3U17F15 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, x, z); }
        public readonly Vector3U17F15 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, x); }
        public readonly Vector3U17F15 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, y); }
        public readonly Vector3U17F15 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, y, z); }
        public readonly Vector3U17F15 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, x); }
        public readonly Vector3U17F15 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, y); }
        public readonly Vector3U17F15 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(z, z, z); }
        public readonly Vector4U17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, x); }
        public readonly Vector4U17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, y); }
        public readonly Vector4U17F15 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, x, z); }
        public readonly Vector4U17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, x); }
        public readonly Vector4U17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, y); }
        public readonly Vector4U17F15 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, y, z); }
        public readonly Vector4U17F15 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, x); }
        public readonly Vector4U17F15 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, y); }
        public readonly Vector4U17F15 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, x, z, z); }
        public readonly Vector4U17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, x); }
        public readonly Vector4U17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, y); }
        public readonly Vector4U17F15 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, x, z); }
        public readonly Vector4U17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, x); }
        public readonly Vector4U17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, y); }
        public readonly Vector4U17F15 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, y, z); }
        public readonly Vector4U17F15 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, x); }
        public readonly Vector4U17F15 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, y); }
        public readonly Vector4U17F15 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, y, z, z); }
        public readonly Vector4U17F15 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, x); }
        public readonly Vector4U17F15 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, y); }
        public readonly Vector4U17F15 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, x, z); }
        public readonly Vector4U17F15 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, x); }
        public readonly Vector4U17F15 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, y); }
        public readonly Vector4U17F15 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, y, z); }
        public readonly Vector4U17F15 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, x); }
        public readonly Vector4U17F15 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, y); }
        public readonly Vector4U17F15 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(x, z, z, z); }
        public readonly Vector4U17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, x); }
        public readonly Vector4U17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, y); }
        public readonly Vector4U17F15 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, x, z); }
        public readonly Vector4U17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, x); }
        public readonly Vector4U17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, y); }
        public readonly Vector4U17F15 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, y, z); }
        public readonly Vector4U17F15 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, x); }
        public readonly Vector4U17F15 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, y); }
        public readonly Vector4U17F15 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, x, z, z); }
        public readonly Vector4U17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, x); }
        public readonly Vector4U17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, y); }
        public readonly Vector4U17F15 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, x, z); }
        public readonly Vector4U17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, x); }
        public readonly Vector4U17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, y); }
        public readonly Vector4U17F15 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, y, z); }
        public readonly Vector4U17F15 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, x); }
        public readonly Vector4U17F15 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, y); }
        public readonly Vector4U17F15 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, y, z, z); }
        public readonly Vector4U17F15 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, x); }
        public readonly Vector4U17F15 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, y); }
        public readonly Vector4U17F15 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, x, z); }
        public readonly Vector4U17F15 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, x); }
        public readonly Vector4U17F15 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, y); }
        public readonly Vector4U17F15 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, y, z); }
        public readonly Vector4U17F15 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, x); }
        public readonly Vector4U17F15 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, y); }
        public readonly Vector4U17F15 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(y, z, z, z); }
        public readonly Vector4U17F15 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, x); }
        public readonly Vector4U17F15 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, y); }
        public readonly Vector4U17F15 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, x, z); }
        public readonly Vector4U17F15 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, x); }
        public readonly Vector4U17F15 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, y); }
        public readonly Vector4U17F15 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, y, z); }
        public readonly Vector4U17F15 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, x); }
        public readonly Vector4U17F15 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, y); }
        public readonly Vector4U17F15 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, x, z, z); }
        public readonly Vector4U17F15 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, x); }
        public readonly Vector4U17F15 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, y); }
        public readonly Vector4U17F15 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, x, z); }
        public readonly Vector4U17F15 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, x); }
        public readonly Vector4U17F15 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, y); }
        public readonly Vector4U17F15 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, y, z); }
        public readonly Vector4U17F15 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, x); }
        public readonly Vector4U17F15 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, y); }
        public readonly Vector4U17F15 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, y, z, z); }
        public readonly Vector4U17F15 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, x); }
        public readonly Vector4U17F15 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, y); }
        public readonly Vector4U17F15 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, x, z); }
        public readonly Vector4U17F15 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, x); }
        public readonly Vector4U17F15 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, y); }
        public readonly Vector4U17F15 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, y, z); }
        public readonly Vector4U17F15 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, x); }
        public readonly Vector4U17F15 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, y); }
        public readonly Vector4U17F15 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U17F15 lhs, Vector3U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U17F15 lhs, Vector3U17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U17F15({x}, {y}, {z})";

        // IEquatable<Vector3U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U17F15 other)
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
            return $"Vector3U17F15({x}, {y}, {z})";
        }
    }
}
