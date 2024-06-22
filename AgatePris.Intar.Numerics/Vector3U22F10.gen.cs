using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U22F10 : IEquatable<Vector3U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

        public U22F10 x;
        public U22F10 y;
        public U22F10 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U22F10 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, U22F10 y, U22F10 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(U22F10 x, Vector2U22F10 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector3U22F10 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U22F10(Vector2U22F10 xy, U22F10 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator +(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator -(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator *(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(Vector3U22F10 a, U22F10 b) => new Vector3U22F10(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 operator /(U22F10 a, Vector3U22F10 b) => new Vector3U22F10(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U22F10 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(x, x); }
        public readonly Vector2U22F10 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(x, y); }
        public readonly Vector2U22F10 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(x, z); }
        public readonly Vector2U22F10 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(y, x); }
        public readonly Vector2U22F10 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(y, y); }
        public readonly Vector2U22F10 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(y, z); }
        public readonly Vector2U22F10 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(z, x); }
        public readonly Vector2U22F10 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(z, y); }
        public readonly Vector2U22F10 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(z, z); }
        public readonly Vector3U22F10 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, x, x); }
        public readonly Vector3U22F10 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, x, y); }
        public readonly Vector3U22F10 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, x, z); }
        public readonly Vector3U22F10 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, y, x); }
        public readonly Vector3U22F10 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, y, y); }
        public readonly Vector3U22F10 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, y, z); }
        public readonly Vector3U22F10 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, z, x); }
        public readonly Vector3U22F10 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, z, y); }
        public readonly Vector3U22F10 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, z, z); }
        public readonly Vector3U22F10 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, x, x); }
        public readonly Vector3U22F10 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, x, y); }
        public readonly Vector3U22F10 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, x, z); }
        public readonly Vector3U22F10 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, y, x); }
        public readonly Vector3U22F10 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, y, y); }
        public readonly Vector3U22F10 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, y, z); }
        public readonly Vector3U22F10 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, z, x); }
        public readonly Vector3U22F10 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, z, y); }
        public readonly Vector3U22F10 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, z, z); }
        public readonly Vector3U22F10 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, x, x); }
        public readonly Vector3U22F10 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, x, y); }
        public readonly Vector3U22F10 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, x, z); }
        public readonly Vector3U22F10 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, y, x); }
        public readonly Vector3U22F10 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, y, y); }
        public readonly Vector3U22F10 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, y, z); }
        public readonly Vector3U22F10 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, z, x); }
        public readonly Vector3U22F10 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, z, y); }
        public readonly Vector3U22F10 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(z, z, z); }
        public readonly Vector4U22F10 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, x, x); }
        public readonly Vector4U22F10 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, x, y); }
        public readonly Vector4U22F10 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, x, z); }
        public readonly Vector4U22F10 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, y, x); }
        public readonly Vector4U22F10 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, y, y); }
        public readonly Vector4U22F10 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, y, z); }
        public readonly Vector4U22F10 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, z, x); }
        public readonly Vector4U22F10 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, z, y); }
        public readonly Vector4U22F10 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, z, z); }
        public readonly Vector4U22F10 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, x, x); }
        public readonly Vector4U22F10 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, x, y); }
        public readonly Vector4U22F10 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, x, z); }
        public readonly Vector4U22F10 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, y, x); }
        public readonly Vector4U22F10 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, y, y); }
        public readonly Vector4U22F10 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, y, z); }
        public readonly Vector4U22F10 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, z, x); }
        public readonly Vector4U22F10 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, z, y); }
        public readonly Vector4U22F10 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, z, z); }
        public readonly Vector4U22F10 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, x, x); }
        public readonly Vector4U22F10 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, x, y); }
        public readonly Vector4U22F10 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, x, z); }
        public readonly Vector4U22F10 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, y, x); }
        public readonly Vector4U22F10 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, y, y); }
        public readonly Vector4U22F10 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, y, z); }
        public readonly Vector4U22F10 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, z, x); }
        public readonly Vector4U22F10 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, z, y); }
        public readonly Vector4U22F10 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, z, z, z); }
        public readonly Vector4U22F10 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, x, x); }
        public readonly Vector4U22F10 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, x, y); }
        public readonly Vector4U22F10 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, x, z); }
        public readonly Vector4U22F10 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, y, x); }
        public readonly Vector4U22F10 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, y, y); }
        public readonly Vector4U22F10 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, y, z); }
        public readonly Vector4U22F10 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, z, x); }
        public readonly Vector4U22F10 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, z, y); }
        public readonly Vector4U22F10 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, z, z); }
        public readonly Vector4U22F10 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, x, x); }
        public readonly Vector4U22F10 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, x, y); }
        public readonly Vector4U22F10 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, x, z); }
        public readonly Vector4U22F10 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, y, x); }
        public readonly Vector4U22F10 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, y, y); }
        public readonly Vector4U22F10 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, y, z); }
        public readonly Vector4U22F10 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, z, x); }
        public readonly Vector4U22F10 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, z, y); }
        public readonly Vector4U22F10 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, z, z); }
        public readonly Vector4U22F10 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, x, x); }
        public readonly Vector4U22F10 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, x, y); }
        public readonly Vector4U22F10 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, x, z); }
        public readonly Vector4U22F10 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, y, x); }
        public readonly Vector4U22F10 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, y, y); }
        public readonly Vector4U22F10 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, y, z); }
        public readonly Vector4U22F10 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, z, x); }
        public readonly Vector4U22F10 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, z, y); }
        public readonly Vector4U22F10 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, z, z, z); }
        public readonly Vector4U22F10 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, x, x); }
        public readonly Vector4U22F10 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, x, y); }
        public readonly Vector4U22F10 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, x, z); }
        public readonly Vector4U22F10 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, y, x); }
        public readonly Vector4U22F10 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, y, y); }
        public readonly Vector4U22F10 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, y, z); }
        public readonly Vector4U22F10 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, z, x); }
        public readonly Vector4U22F10 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, z, y); }
        public readonly Vector4U22F10 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, x, z, z); }
        public readonly Vector4U22F10 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, x, x); }
        public readonly Vector4U22F10 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, x, y); }
        public readonly Vector4U22F10 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, x, z); }
        public readonly Vector4U22F10 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, y, x); }
        public readonly Vector4U22F10 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, y, y); }
        public readonly Vector4U22F10 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, y, z); }
        public readonly Vector4U22F10 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, z, x); }
        public readonly Vector4U22F10 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, z, y); }
        public readonly Vector4U22F10 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, y, z, z); }
        public readonly Vector4U22F10 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, x, x); }
        public readonly Vector4U22F10 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, x, y); }
        public readonly Vector4U22F10 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, x, z); }
        public readonly Vector4U22F10 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, y, x); }
        public readonly Vector4U22F10 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, y, y); }
        public readonly Vector4U22F10 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, y, z); }
        public readonly Vector4U22F10 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, z, x); }
        public readonly Vector4U22F10 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, z, y); }
        public readonly Vector4U22F10 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U22F10 lhs, Vector3U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U22F10 lhs, Vector3U22F10 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U22F10({x}, {y}, {z})";

        // IEquatable<Vector3U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U22F10 other)
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
            return $"Vector3U22F10({x}, {y}, {z})";
        }
    }
}
