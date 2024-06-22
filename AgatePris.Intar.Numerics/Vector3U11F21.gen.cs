using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U11F21 : IEquatable<Vector3U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

        public U11F21 x;
        public U11F21 y;
        public U11F21 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U11F21 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(U11F21 x, U11F21 y, U11F21 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(U11F21 x, Vector2U11F21 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(Vector3U11F21 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U11F21(Vector2U11F21 xy, U11F21 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator +(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator -(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(Vector3U11F21 a, U11F21 b) => new Vector3U11F21(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator *(U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(Vector3U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(Vector3U11F21 a, U11F21 b) => new Vector3U11F21(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 operator /(U11F21 a, Vector3U11F21 b) => new Vector3U11F21(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(x, x); }
        public readonly Vector2U11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(x, y); }
        public readonly Vector2U11F21 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(x, z); }
        public readonly Vector2U11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(y, x); }
        public readonly Vector2U11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(y, y); }
        public readonly Vector2U11F21 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(y, z); }
        public readonly Vector2U11F21 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(z, x); }
        public readonly Vector2U11F21 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(z, y); }
        public readonly Vector2U11F21 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(z, z); }
        public readonly Vector3U11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, x, x); }
        public readonly Vector3U11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, x, y); }
        public readonly Vector3U11F21 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, x, z); }
        public readonly Vector3U11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, y, x); }
        public readonly Vector3U11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, y, y); }
        public readonly Vector3U11F21 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, y, z); }
        public readonly Vector3U11F21 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, z, x); }
        public readonly Vector3U11F21 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, z, y); }
        public readonly Vector3U11F21 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, z, z); }
        public readonly Vector3U11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, x, x); }
        public readonly Vector3U11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, x, y); }
        public readonly Vector3U11F21 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, x, z); }
        public readonly Vector3U11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, y, x); }
        public readonly Vector3U11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, y, y); }
        public readonly Vector3U11F21 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, y, z); }
        public readonly Vector3U11F21 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, z, x); }
        public readonly Vector3U11F21 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, z, y); }
        public readonly Vector3U11F21 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, z, z); }
        public readonly Vector3U11F21 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, x, x); }
        public readonly Vector3U11F21 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, x, y); }
        public readonly Vector3U11F21 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, x, z); }
        public readonly Vector3U11F21 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, y, x); }
        public readonly Vector3U11F21 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, y, y); }
        public readonly Vector3U11F21 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, y, z); }
        public readonly Vector3U11F21 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, z, x); }
        public readonly Vector3U11F21 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, z, y); }
        public readonly Vector3U11F21 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(z, z, z); }
        public readonly Vector4U11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, x, x); }
        public readonly Vector4U11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, x, y); }
        public readonly Vector4U11F21 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, x, z); }
        public readonly Vector4U11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, y, x); }
        public readonly Vector4U11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, y, y); }
        public readonly Vector4U11F21 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, y, z); }
        public readonly Vector4U11F21 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, z, x); }
        public readonly Vector4U11F21 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, z, y); }
        public readonly Vector4U11F21 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, z, z); }
        public readonly Vector4U11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, x, x); }
        public readonly Vector4U11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, x, y); }
        public readonly Vector4U11F21 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, x, z); }
        public readonly Vector4U11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, y, x); }
        public readonly Vector4U11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, y, y); }
        public readonly Vector4U11F21 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, y, z); }
        public readonly Vector4U11F21 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, z, x); }
        public readonly Vector4U11F21 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, z, y); }
        public readonly Vector4U11F21 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, z, z); }
        public readonly Vector4U11F21 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, x, x); }
        public readonly Vector4U11F21 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, x, y); }
        public readonly Vector4U11F21 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, x, z); }
        public readonly Vector4U11F21 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, y, x); }
        public readonly Vector4U11F21 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, y, y); }
        public readonly Vector4U11F21 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, y, z); }
        public readonly Vector4U11F21 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, z, x); }
        public readonly Vector4U11F21 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, z, y); }
        public readonly Vector4U11F21 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, z, z, z); }
        public readonly Vector4U11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, x, x); }
        public readonly Vector4U11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, x, y); }
        public readonly Vector4U11F21 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, x, z); }
        public readonly Vector4U11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, y, x); }
        public readonly Vector4U11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, y, y); }
        public readonly Vector4U11F21 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, y, z); }
        public readonly Vector4U11F21 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, z, x); }
        public readonly Vector4U11F21 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, z, y); }
        public readonly Vector4U11F21 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, z, z); }
        public readonly Vector4U11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, x, x); }
        public readonly Vector4U11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, x, y); }
        public readonly Vector4U11F21 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, x, z); }
        public readonly Vector4U11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, y, x); }
        public readonly Vector4U11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, y, y); }
        public readonly Vector4U11F21 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, y, z); }
        public readonly Vector4U11F21 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, z, x); }
        public readonly Vector4U11F21 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, z, y); }
        public readonly Vector4U11F21 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, z, z); }
        public readonly Vector4U11F21 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, x, x); }
        public readonly Vector4U11F21 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, x, y); }
        public readonly Vector4U11F21 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, x, z); }
        public readonly Vector4U11F21 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, y, x); }
        public readonly Vector4U11F21 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, y, y); }
        public readonly Vector4U11F21 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, y, z); }
        public readonly Vector4U11F21 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, z, x); }
        public readonly Vector4U11F21 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, z, y); }
        public readonly Vector4U11F21 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, z, z, z); }
        public readonly Vector4U11F21 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, x, x); }
        public readonly Vector4U11F21 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, x, y); }
        public readonly Vector4U11F21 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, x, z); }
        public readonly Vector4U11F21 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, y, x); }
        public readonly Vector4U11F21 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, y, y); }
        public readonly Vector4U11F21 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, y, z); }
        public readonly Vector4U11F21 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, z, x); }
        public readonly Vector4U11F21 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, z, y); }
        public readonly Vector4U11F21 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, x, z, z); }
        public readonly Vector4U11F21 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, x, x); }
        public readonly Vector4U11F21 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, x, y); }
        public readonly Vector4U11F21 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, x, z); }
        public readonly Vector4U11F21 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, y, x); }
        public readonly Vector4U11F21 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, y, y); }
        public readonly Vector4U11F21 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, y, z); }
        public readonly Vector4U11F21 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, z, x); }
        public readonly Vector4U11F21 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, z, y); }
        public readonly Vector4U11F21 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, y, z, z); }
        public readonly Vector4U11F21 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, x, x); }
        public readonly Vector4U11F21 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, x, y); }
        public readonly Vector4U11F21 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, x, z); }
        public readonly Vector4U11F21 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, y, x); }
        public readonly Vector4U11F21 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, y, y); }
        public readonly Vector4U11F21 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, y, z); }
        public readonly Vector4U11F21 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, z, x); }
        public readonly Vector4U11F21 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, z, y); }
        public readonly Vector4U11F21 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U11F21 lhs, Vector3U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U11F21 lhs, Vector3U11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U11F21({x}, {y}, {z})";

        // IEquatable<Vector3U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U11F21 other)
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
            return $"Vector3U11F21({x}, {y}, {z})";
        }
    }
}
