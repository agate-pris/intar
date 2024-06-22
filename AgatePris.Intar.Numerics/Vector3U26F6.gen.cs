using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U26F6 : IEquatable<Vector3U26F6>, IFormattable {
        // Fields
        // ---------------------------------------

        public U26F6 x;
        public U26F6 y;
        public U26F6 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U26F6 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, U26F6 y, U26F6 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, Vector2U26F6 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector3U26F6 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector2U26F6 xy, U26F6 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator +(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator -(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(x, x); }
        public readonly Vector2U26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(x, y); }
        public readonly Vector2U26F6 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(x, z); }
        public readonly Vector2U26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(y, x); }
        public readonly Vector2U26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(y, y); }
        public readonly Vector2U26F6 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(y, z); }
        public readonly Vector2U26F6 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(z, x); }
        public readonly Vector2U26F6 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(z, y); }
        public readonly Vector2U26F6 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(z, z); }
        public readonly Vector3U26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, x, x); }
        public readonly Vector3U26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, x, y); }
        public readonly Vector3U26F6 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, x, z); }
        public readonly Vector3U26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, y, x); }
        public readonly Vector3U26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, y, y); }
        public readonly Vector3U26F6 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, y, z); }
        public readonly Vector3U26F6 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, z, x); }
        public readonly Vector3U26F6 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, z, y); }
        public readonly Vector3U26F6 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(x, z, z); }
        public readonly Vector3U26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, x, x); }
        public readonly Vector3U26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, x, y); }
        public readonly Vector3U26F6 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, x, z); }
        public readonly Vector3U26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, y, x); }
        public readonly Vector3U26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, y, y); }
        public readonly Vector3U26F6 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, y, z); }
        public readonly Vector3U26F6 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, z, x); }
        public readonly Vector3U26F6 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, z, y); }
        public readonly Vector3U26F6 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(y, z, z); }
        public readonly Vector3U26F6 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, x, x); }
        public readonly Vector3U26F6 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, x, y); }
        public readonly Vector3U26F6 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, x, z); }
        public readonly Vector3U26F6 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, y, x); }
        public readonly Vector3U26F6 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, y, y); }
        public readonly Vector3U26F6 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, y, z); }
        public readonly Vector3U26F6 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, z, x); }
        public readonly Vector3U26F6 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, z, y); }
        public readonly Vector3U26F6 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(z, z, z); }
        public readonly Vector4U26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, x, x); }
        public readonly Vector4U26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, x, y); }
        public readonly Vector4U26F6 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, x, z); }
        public readonly Vector4U26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, y, x); }
        public readonly Vector4U26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, y, y); }
        public readonly Vector4U26F6 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, y, z); }
        public readonly Vector4U26F6 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, z, x); }
        public readonly Vector4U26F6 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, z, y); }
        public readonly Vector4U26F6 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, x, z, z); }
        public readonly Vector4U26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, x, x); }
        public readonly Vector4U26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, x, y); }
        public readonly Vector4U26F6 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, x, z); }
        public readonly Vector4U26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, y, x); }
        public readonly Vector4U26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, y, y); }
        public readonly Vector4U26F6 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, y, z); }
        public readonly Vector4U26F6 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, z, x); }
        public readonly Vector4U26F6 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, z, y); }
        public readonly Vector4U26F6 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, y, z, z); }
        public readonly Vector4U26F6 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, x, x); }
        public readonly Vector4U26F6 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, x, y); }
        public readonly Vector4U26F6 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, x, z); }
        public readonly Vector4U26F6 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, y, x); }
        public readonly Vector4U26F6 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, y, y); }
        public readonly Vector4U26F6 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, y, z); }
        public readonly Vector4U26F6 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, z, x); }
        public readonly Vector4U26F6 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, z, y); }
        public readonly Vector4U26F6 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(x, z, z, z); }
        public readonly Vector4U26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, x, x); }
        public readonly Vector4U26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, x, y); }
        public readonly Vector4U26F6 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, x, z); }
        public readonly Vector4U26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, y, x); }
        public readonly Vector4U26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, y, y); }
        public readonly Vector4U26F6 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, y, z); }
        public readonly Vector4U26F6 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, z, x); }
        public readonly Vector4U26F6 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, z, y); }
        public readonly Vector4U26F6 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, x, z, z); }
        public readonly Vector4U26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, x, x); }
        public readonly Vector4U26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, x, y); }
        public readonly Vector4U26F6 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, x, z); }
        public readonly Vector4U26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, y, x); }
        public readonly Vector4U26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, y, y); }
        public readonly Vector4U26F6 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, y, z); }
        public readonly Vector4U26F6 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, z, x); }
        public readonly Vector4U26F6 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, z, y); }
        public readonly Vector4U26F6 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, y, z, z); }
        public readonly Vector4U26F6 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, x, x); }
        public readonly Vector4U26F6 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, x, y); }
        public readonly Vector4U26F6 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, x, z); }
        public readonly Vector4U26F6 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, y, x); }
        public readonly Vector4U26F6 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, y, y); }
        public readonly Vector4U26F6 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, y, z); }
        public readonly Vector4U26F6 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, z, x); }
        public readonly Vector4U26F6 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, z, y); }
        public readonly Vector4U26F6 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(y, z, z, z); }
        public readonly Vector4U26F6 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, x, x); }
        public readonly Vector4U26F6 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, x, y); }
        public readonly Vector4U26F6 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, x, z); }
        public readonly Vector4U26F6 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, y, x); }
        public readonly Vector4U26F6 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, y, y); }
        public readonly Vector4U26F6 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, y, z); }
        public readonly Vector4U26F6 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, z, x); }
        public readonly Vector4U26F6 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, z, y); }
        public readonly Vector4U26F6 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, x, z, z); }
        public readonly Vector4U26F6 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, x, x); }
        public readonly Vector4U26F6 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, x, y); }
        public readonly Vector4U26F6 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, x, z); }
        public readonly Vector4U26F6 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, y, x); }
        public readonly Vector4U26F6 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, y, y); }
        public readonly Vector4U26F6 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, y, z); }
        public readonly Vector4U26F6 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, z, x); }
        public readonly Vector4U26F6 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, z, y); }
        public readonly Vector4U26F6 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, y, z, z); }
        public readonly Vector4U26F6 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, x, x); }
        public readonly Vector4U26F6 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, x, y); }
        public readonly Vector4U26F6 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, x, z); }
        public readonly Vector4U26F6 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, y, x); }
        public readonly Vector4U26F6 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, y, y); }
        public readonly Vector4U26F6 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, y, z); }
        public readonly Vector4U26F6 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, z, x); }
        public readonly Vector4U26F6 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, z, y); }
        public readonly Vector4U26F6 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U26F6 lhs, Vector3U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U26F6 lhs, Vector3U26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U26F6({x}, {y}, {z})";

        // IEquatable<Vector3U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U26F6 other)
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
            return $"Vector3U26F6({x}, {y}, {z})";
        }
    }
}
