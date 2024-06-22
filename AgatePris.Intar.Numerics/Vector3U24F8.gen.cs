using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U24F8 : IEquatable<Vector3U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

        public U24F8 x;
        public U24F8 y;
        public U24F8 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U24F8 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U24F8(U24F8 x, U24F8 y, U24F8 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U24F8(U24F8 x, Vector2U24F8 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U24F8(Vector3U24F8 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U24F8(Vector2U24F8 xy, U24F8 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator +(Vector3U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator -(Vector3U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator *(Vector3U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator *(Vector3U24F8 a, U24F8 b) => new Vector3U24F8(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator *(U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator /(Vector3U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator /(Vector3U24F8 a, U24F8 b) => new Vector3U24F8(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 operator /(U24F8 a, Vector3U24F8 b) => new Vector3U24F8(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, x); }
        public readonly Vector2U24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, y); }
        public readonly Vector2U24F8 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, z); }
        public readonly Vector2U24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, x); }
        public readonly Vector2U24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, y); }
        public readonly Vector2U24F8 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, z); }
        public readonly Vector2U24F8 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, x); }
        public readonly Vector2U24F8 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, y); }
        public readonly Vector2U24F8 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(z, z); }
        public readonly Vector3U24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, x); }
        public readonly Vector3U24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, y); }
        public readonly Vector3U24F8 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, z); }
        public readonly Vector3U24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, x); }
        public readonly Vector3U24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, y); }
        public readonly Vector3U24F8 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, z); }
        public readonly Vector3U24F8 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, x); }
        public readonly Vector3U24F8 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, y); }
        public readonly Vector3U24F8 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, z, z); }
        public readonly Vector3U24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, x); }
        public readonly Vector3U24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, y); }
        public readonly Vector3U24F8 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, z); }
        public readonly Vector3U24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, x); }
        public readonly Vector3U24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, y); }
        public readonly Vector3U24F8 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, z); }
        public readonly Vector3U24F8 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, x); }
        public readonly Vector3U24F8 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, y); }
        public readonly Vector3U24F8 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, z, z); }
        public readonly Vector3U24F8 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, x); }
        public readonly Vector3U24F8 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, y); }
        public readonly Vector3U24F8 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, x, z); }
        public readonly Vector3U24F8 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, x); }
        public readonly Vector3U24F8 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, y); }
        public readonly Vector3U24F8 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, y, z); }
        public readonly Vector3U24F8 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, x); }
        public readonly Vector3U24F8 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, y); }
        public readonly Vector3U24F8 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(z, z, z); }
        public readonly Vector4U24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, x); }
        public readonly Vector4U24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, y); }
        public readonly Vector4U24F8 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, z); }
        public readonly Vector4U24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, x); }
        public readonly Vector4U24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, y); }
        public readonly Vector4U24F8 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, z); }
        public readonly Vector4U24F8 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, x); }
        public readonly Vector4U24F8 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, y); }
        public readonly Vector4U24F8 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, z, z); }
        public readonly Vector4U24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, x); }
        public readonly Vector4U24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, y); }
        public readonly Vector4U24F8 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, z); }
        public readonly Vector4U24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, x); }
        public readonly Vector4U24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, y); }
        public readonly Vector4U24F8 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, z); }
        public readonly Vector4U24F8 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, x); }
        public readonly Vector4U24F8 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, y); }
        public readonly Vector4U24F8 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, z, z); }
        public readonly Vector4U24F8 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, x); }
        public readonly Vector4U24F8 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, y); }
        public readonly Vector4U24F8 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, x, z); }
        public readonly Vector4U24F8 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, x); }
        public readonly Vector4U24F8 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, y); }
        public readonly Vector4U24F8 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, y, z); }
        public readonly Vector4U24F8 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, x); }
        public readonly Vector4U24F8 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, y); }
        public readonly Vector4U24F8 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, z, z, z); }
        public readonly Vector4U24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, x); }
        public readonly Vector4U24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, y); }
        public readonly Vector4U24F8 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, z); }
        public readonly Vector4U24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, x); }
        public readonly Vector4U24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, y); }
        public readonly Vector4U24F8 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, z); }
        public readonly Vector4U24F8 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, x); }
        public readonly Vector4U24F8 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, y); }
        public readonly Vector4U24F8 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, z, z); }
        public readonly Vector4U24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, x); }
        public readonly Vector4U24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, y); }
        public readonly Vector4U24F8 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, z); }
        public readonly Vector4U24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, x); }
        public readonly Vector4U24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, y); }
        public readonly Vector4U24F8 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, z); }
        public readonly Vector4U24F8 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, x); }
        public readonly Vector4U24F8 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, y); }
        public readonly Vector4U24F8 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, z, z); }
        public readonly Vector4U24F8 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, x); }
        public readonly Vector4U24F8 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, y); }
        public readonly Vector4U24F8 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, x, z); }
        public readonly Vector4U24F8 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, x); }
        public readonly Vector4U24F8 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, y); }
        public readonly Vector4U24F8 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, y, z); }
        public readonly Vector4U24F8 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, x); }
        public readonly Vector4U24F8 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, y); }
        public readonly Vector4U24F8 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, z, z, z); }
        public readonly Vector4U24F8 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, x); }
        public readonly Vector4U24F8 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, y); }
        public readonly Vector4U24F8 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, x, z); }
        public readonly Vector4U24F8 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, x); }
        public readonly Vector4U24F8 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, y); }
        public readonly Vector4U24F8 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, y, z); }
        public readonly Vector4U24F8 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, x); }
        public readonly Vector4U24F8 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, y); }
        public readonly Vector4U24F8 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, x, z, z); }
        public readonly Vector4U24F8 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, x); }
        public readonly Vector4U24F8 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, y); }
        public readonly Vector4U24F8 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, x, z); }
        public readonly Vector4U24F8 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, x); }
        public readonly Vector4U24F8 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, y); }
        public readonly Vector4U24F8 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, y, z); }
        public readonly Vector4U24F8 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, x); }
        public readonly Vector4U24F8 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, y); }
        public readonly Vector4U24F8 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, y, z, z); }
        public readonly Vector4U24F8 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, x); }
        public readonly Vector4U24F8 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, y); }
        public readonly Vector4U24F8 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, x, z); }
        public readonly Vector4U24F8 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, x); }
        public readonly Vector4U24F8 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, y); }
        public readonly Vector4U24F8 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, y, z); }
        public readonly Vector4U24F8 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, x); }
        public readonly Vector4U24F8 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, y); }
        public readonly Vector4U24F8 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U24F8 lhs, Vector3U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U24F8 lhs, Vector3U24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U24F8({x}, {y}, {z})";

        // IEquatable<Vector3U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U24F8 other)
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
            return $"Vector3U24F8({x}, {y}, {z})";
        }
    }
}
