using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U4F28 : IEquatable<Vector3U4F28>, IFormattable {
        // Fields
        // ---------------------------------------

        public U4F28 x;
        public U4F28 y;
        public U4F28 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U4F28 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(U4F28 x, U4F28 y, U4F28 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(U4F28 x, Vector2U4F28 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(Vector3U4F28 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U4F28(Vector2U4F28 xy, U4F28 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator +(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator -(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(Vector3U4F28 a, U4F28 b) => new Vector3U4F28(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator *(U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(Vector3U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(Vector3U4F28 a, U4F28 b) => new Vector3U4F28(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 operator /(U4F28 a, Vector3U4F28 b) => new Vector3U4F28(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(x, x); }
        public readonly Vector2U4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(x, y); }
        public readonly Vector2U4F28 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(x, z); }
        public readonly Vector2U4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(y, x); }
        public readonly Vector2U4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(y, y); }
        public readonly Vector2U4F28 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(y, z); }
        public readonly Vector2U4F28 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(z, x); }
        public readonly Vector2U4F28 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(z, y); }
        public readonly Vector2U4F28 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(z, z); }
        public readonly Vector3U4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, x, x); }
        public readonly Vector3U4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, x, y); }
        public readonly Vector3U4F28 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, x, z); }
        public readonly Vector3U4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, y, x); }
        public readonly Vector3U4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, y, y); }
        public readonly Vector3U4F28 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, y, z); }
        public readonly Vector3U4F28 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, z, x); }
        public readonly Vector3U4F28 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, z, y); }
        public readonly Vector3U4F28 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(x, z, z); }
        public readonly Vector3U4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, x, x); }
        public readonly Vector3U4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, x, y); }
        public readonly Vector3U4F28 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, x, z); }
        public readonly Vector3U4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, y, x); }
        public readonly Vector3U4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, y, y); }
        public readonly Vector3U4F28 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, y, z); }
        public readonly Vector3U4F28 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, z, x); }
        public readonly Vector3U4F28 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, z, y); }
        public readonly Vector3U4F28 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(y, z, z); }
        public readonly Vector3U4F28 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, x, x); }
        public readonly Vector3U4F28 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, x, y); }
        public readonly Vector3U4F28 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, x, z); }
        public readonly Vector3U4F28 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, y, x); }
        public readonly Vector3U4F28 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, y, y); }
        public readonly Vector3U4F28 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, y, z); }
        public readonly Vector3U4F28 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, z, x); }
        public readonly Vector3U4F28 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, z, y); }
        public readonly Vector3U4F28 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(z, z, z); }
        public readonly Vector4U4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, x, x); }
        public readonly Vector4U4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, x, y); }
        public readonly Vector4U4F28 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, x, z); }
        public readonly Vector4U4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, y, x); }
        public readonly Vector4U4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, y, y); }
        public readonly Vector4U4F28 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, y, z); }
        public readonly Vector4U4F28 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, z, x); }
        public readonly Vector4U4F28 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, z, y); }
        public readonly Vector4U4F28 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, x, z, z); }
        public readonly Vector4U4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, x, x); }
        public readonly Vector4U4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, x, y); }
        public readonly Vector4U4F28 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, x, z); }
        public readonly Vector4U4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, y, x); }
        public readonly Vector4U4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, y, y); }
        public readonly Vector4U4F28 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, y, z); }
        public readonly Vector4U4F28 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, z, x); }
        public readonly Vector4U4F28 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, z, y); }
        public readonly Vector4U4F28 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, y, z, z); }
        public readonly Vector4U4F28 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, x, x); }
        public readonly Vector4U4F28 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, x, y); }
        public readonly Vector4U4F28 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, x, z); }
        public readonly Vector4U4F28 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, y, x); }
        public readonly Vector4U4F28 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, y, y); }
        public readonly Vector4U4F28 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, y, z); }
        public readonly Vector4U4F28 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, z, x); }
        public readonly Vector4U4F28 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, z, y); }
        public readonly Vector4U4F28 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(x, z, z, z); }
        public readonly Vector4U4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, x, x); }
        public readonly Vector4U4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, x, y); }
        public readonly Vector4U4F28 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, x, z); }
        public readonly Vector4U4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, y, x); }
        public readonly Vector4U4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, y, y); }
        public readonly Vector4U4F28 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, y, z); }
        public readonly Vector4U4F28 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, z, x); }
        public readonly Vector4U4F28 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, z, y); }
        public readonly Vector4U4F28 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, x, z, z); }
        public readonly Vector4U4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, x, x); }
        public readonly Vector4U4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, x, y); }
        public readonly Vector4U4F28 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, x, z); }
        public readonly Vector4U4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, y, x); }
        public readonly Vector4U4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, y, y); }
        public readonly Vector4U4F28 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, y, z); }
        public readonly Vector4U4F28 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, z, x); }
        public readonly Vector4U4F28 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, z, y); }
        public readonly Vector4U4F28 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, y, z, z); }
        public readonly Vector4U4F28 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, x, x); }
        public readonly Vector4U4F28 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, x, y); }
        public readonly Vector4U4F28 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, x, z); }
        public readonly Vector4U4F28 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, y, x); }
        public readonly Vector4U4F28 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, y, y); }
        public readonly Vector4U4F28 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, y, z); }
        public readonly Vector4U4F28 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, z, x); }
        public readonly Vector4U4F28 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, z, y); }
        public readonly Vector4U4F28 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(y, z, z, z); }
        public readonly Vector4U4F28 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, x, x); }
        public readonly Vector4U4F28 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, x, y); }
        public readonly Vector4U4F28 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, x, z); }
        public readonly Vector4U4F28 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, y, x); }
        public readonly Vector4U4F28 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, y, y); }
        public readonly Vector4U4F28 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, y, z); }
        public readonly Vector4U4F28 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, z, x); }
        public readonly Vector4U4F28 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, z, y); }
        public readonly Vector4U4F28 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, x, z, z); }
        public readonly Vector4U4F28 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, x, x); }
        public readonly Vector4U4F28 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, x, y); }
        public readonly Vector4U4F28 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, x, z); }
        public readonly Vector4U4F28 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, y, x); }
        public readonly Vector4U4F28 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, y, y); }
        public readonly Vector4U4F28 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, y, z); }
        public readonly Vector4U4F28 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, z, x); }
        public readonly Vector4U4F28 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, z, y); }
        public readonly Vector4U4F28 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, y, z, z); }
        public readonly Vector4U4F28 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, x, x); }
        public readonly Vector4U4F28 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, x, y); }
        public readonly Vector4U4F28 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, x, z); }
        public readonly Vector4U4F28 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, y, x); }
        public readonly Vector4U4F28 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, y, y); }
        public readonly Vector4U4F28 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, y, z); }
        public readonly Vector4U4F28 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, z, x); }
        public readonly Vector4U4F28 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, z, y); }
        public readonly Vector4U4F28 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U4F28 lhs, Vector3U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U4F28 lhs, Vector3U4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U4F28({x}, {y}, {z})";

        // IEquatable<Vector3U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U4F28 other)
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
            return $"Vector3U4F28({x}, {y}, {z})";
        }
    }
}
