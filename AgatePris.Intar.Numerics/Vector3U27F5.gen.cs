using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U27F5 : IEquatable<Vector3U27F5>, IFormattable {
        // Fields
        // ---------------------------------------

        public U27F5 x;
        public U27F5 y;
        public U27F5 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U27F5 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(U27F5 x, U27F5 y, U27F5 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(U27F5 x, Vector2U27F5 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(Vector3U27F5 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U27F5(Vector2U27F5 xy, U27F5 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator +(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator -(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(Vector3U27F5 a, U27F5 b) => new Vector3U27F5(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator *(U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(Vector3U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(Vector3U27F5 a, U27F5 b) => new Vector3U27F5(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 operator /(U27F5 a, Vector3U27F5 b) => new Vector3U27F5(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, x); }
        public readonly Vector2U27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, y); }
        public readonly Vector2U27F5 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(x, z); }
        public readonly Vector2U27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, x); }
        public readonly Vector2U27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, y); }
        public readonly Vector2U27F5 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(y, z); }
        public readonly Vector2U27F5 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, x); }
        public readonly Vector2U27F5 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, y); }
        public readonly Vector2U27F5 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(z, z); }
        public readonly Vector3U27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, x); }
        public readonly Vector3U27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, y); }
        public readonly Vector3U27F5 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, x, z); }
        public readonly Vector3U27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, x); }
        public readonly Vector3U27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, y); }
        public readonly Vector3U27F5 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, y, z); }
        public readonly Vector3U27F5 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, x); }
        public readonly Vector3U27F5 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, y); }
        public readonly Vector3U27F5 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(x, z, z); }
        public readonly Vector3U27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, x); }
        public readonly Vector3U27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, y); }
        public readonly Vector3U27F5 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, x, z); }
        public readonly Vector3U27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, x); }
        public readonly Vector3U27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, y); }
        public readonly Vector3U27F5 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, y, z); }
        public readonly Vector3U27F5 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, x); }
        public readonly Vector3U27F5 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, y); }
        public readonly Vector3U27F5 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(y, z, z); }
        public readonly Vector3U27F5 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, x); }
        public readonly Vector3U27F5 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, y); }
        public readonly Vector3U27F5 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, x, z); }
        public readonly Vector3U27F5 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, x); }
        public readonly Vector3U27F5 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, y); }
        public readonly Vector3U27F5 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, y, z); }
        public readonly Vector3U27F5 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, x); }
        public readonly Vector3U27F5 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, y); }
        public readonly Vector3U27F5 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(z, z, z); }
        public readonly Vector4U27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, x); }
        public readonly Vector4U27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, y); }
        public readonly Vector4U27F5 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, x, z); }
        public readonly Vector4U27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, x); }
        public readonly Vector4U27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, y); }
        public readonly Vector4U27F5 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, y, z); }
        public readonly Vector4U27F5 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, x); }
        public readonly Vector4U27F5 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, y); }
        public readonly Vector4U27F5 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, x, z, z); }
        public readonly Vector4U27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, x); }
        public readonly Vector4U27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, y); }
        public readonly Vector4U27F5 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, x, z); }
        public readonly Vector4U27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, x); }
        public readonly Vector4U27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, y); }
        public readonly Vector4U27F5 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, y, z); }
        public readonly Vector4U27F5 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, x); }
        public readonly Vector4U27F5 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, y); }
        public readonly Vector4U27F5 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, y, z, z); }
        public readonly Vector4U27F5 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, x); }
        public readonly Vector4U27F5 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, y); }
        public readonly Vector4U27F5 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, x, z); }
        public readonly Vector4U27F5 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, x); }
        public readonly Vector4U27F5 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, y); }
        public readonly Vector4U27F5 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, y, z); }
        public readonly Vector4U27F5 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, x); }
        public readonly Vector4U27F5 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, y); }
        public readonly Vector4U27F5 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(x, z, z, z); }
        public readonly Vector4U27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, x); }
        public readonly Vector4U27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, y); }
        public readonly Vector4U27F5 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, x, z); }
        public readonly Vector4U27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, x); }
        public readonly Vector4U27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, y); }
        public readonly Vector4U27F5 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, y, z); }
        public readonly Vector4U27F5 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, x); }
        public readonly Vector4U27F5 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, y); }
        public readonly Vector4U27F5 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, x, z, z); }
        public readonly Vector4U27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, x); }
        public readonly Vector4U27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, y); }
        public readonly Vector4U27F5 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, x, z); }
        public readonly Vector4U27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, x); }
        public readonly Vector4U27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, y); }
        public readonly Vector4U27F5 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, y, z); }
        public readonly Vector4U27F5 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, x); }
        public readonly Vector4U27F5 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, y); }
        public readonly Vector4U27F5 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, y, z, z); }
        public readonly Vector4U27F5 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, x); }
        public readonly Vector4U27F5 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, y); }
        public readonly Vector4U27F5 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, x, z); }
        public readonly Vector4U27F5 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, x); }
        public readonly Vector4U27F5 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, y); }
        public readonly Vector4U27F5 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, y, z); }
        public readonly Vector4U27F5 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, x); }
        public readonly Vector4U27F5 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, y); }
        public readonly Vector4U27F5 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(y, z, z, z); }
        public readonly Vector4U27F5 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, x); }
        public readonly Vector4U27F5 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, y); }
        public readonly Vector4U27F5 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, x, z); }
        public readonly Vector4U27F5 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, x); }
        public readonly Vector4U27F5 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, y); }
        public readonly Vector4U27F5 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, y, z); }
        public readonly Vector4U27F5 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, x); }
        public readonly Vector4U27F5 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, y); }
        public readonly Vector4U27F5 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, x, z, z); }
        public readonly Vector4U27F5 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, x); }
        public readonly Vector4U27F5 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, y); }
        public readonly Vector4U27F5 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, x, z); }
        public readonly Vector4U27F5 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, x); }
        public readonly Vector4U27F5 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, y); }
        public readonly Vector4U27F5 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, y, z); }
        public readonly Vector4U27F5 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, x); }
        public readonly Vector4U27F5 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, y); }
        public readonly Vector4U27F5 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, y, z, z); }
        public readonly Vector4U27F5 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, x); }
        public readonly Vector4U27F5 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, y); }
        public readonly Vector4U27F5 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, x, z); }
        public readonly Vector4U27F5 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, x); }
        public readonly Vector4U27F5 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, y); }
        public readonly Vector4U27F5 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, y, z); }
        public readonly Vector4U27F5 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, x); }
        public readonly Vector4U27F5 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, y); }
        public readonly Vector4U27F5 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U27F5 lhs, Vector3U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U27F5 lhs, Vector3U27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U27F5({x}, {y}, {z})";

        // IEquatable<Vector3U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U27F5 other)
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
            return $"Vector3U27F5({x}, {y}, {z})";
        }
    }
}
