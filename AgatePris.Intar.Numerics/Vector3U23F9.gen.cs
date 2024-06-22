using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U23F9 : IEquatable<Vector3U23F9>, IFormattable {
        // Fields
        // ---------------------------------------

        public U23F9 x;
        public U23F9 y;
        public U23F9 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U23F9 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, U23F9 y, U23F9 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, Vector2U23F9 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector3U23F9 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector2U23F9 xy, U23F9 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator +(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator -(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U23F9 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, x); }
        public readonly Vector2U23F9 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, y); }
        public readonly Vector2U23F9 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(x, z); }
        public readonly Vector2U23F9 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, x); }
        public readonly Vector2U23F9 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, y); }
        public readonly Vector2U23F9 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(y, z); }
        public readonly Vector2U23F9 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, x); }
        public readonly Vector2U23F9 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, y); }
        public readonly Vector2U23F9 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(z, z); }
        public readonly Vector3U23F9 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, x); }
        public readonly Vector3U23F9 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, y); }
        public readonly Vector3U23F9 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, x, z); }
        public readonly Vector3U23F9 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, x); }
        public readonly Vector3U23F9 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, y); }
        public readonly Vector3U23F9 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, y, z); }
        public readonly Vector3U23F9 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, x); }
        public readonly Vector3U23F9 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, y); }
        public readonly Vector3U23F9 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(x, z, z); }
        public readonly Vector3U23F9 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, x); }
        public readonly Vector3U23F9 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, y); }
        public readonly Vector3U23F9 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, x, z); }
        public readonly Vector3U23F9 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, x); }
        public readonly Vector3U23F9 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, y); }
        public readonly Vector3U23F9 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, y, z); }
        public readonly Vector3U23F9 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, x); }
        public readonly Vector3U23F9 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, y); }
        public readonly Vector3U23F9 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(y, z, z); }
        public readonly Vector3U23F9 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, x); }
        public readonly Vector3U23F9 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, y); }
        public readonly Vector3U23F9 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, x, z); }
        public readonly Vector3U23F9 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, x); }
        public readonly Vector3U23F9 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, y); }
        public readonly Vector3U23F9 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, y, z); }
        public readonly Vector3U23F9 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, x); }
        public readonly Vector3U23F9 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, y); }
        public readonly Vector3U23F9 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(z, z, z); }
        public readonly Vector4U23F9 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, x); }
        public readonly Vector4U23F9 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, y); }
        public readonly Vector4U23F9 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, x, z); }
        public readonly Vector4U23F9 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, x); }
        public readonly Vector4U23F9 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, y); }
        public readonly Vector4U23F9 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, y, z); }
        public readonly Vector4U23F9 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, x); }
        public readonly Vector4U23F9 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, y); }
        public readonly Vector4U23F9 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, x, z, z); }
        public readonly Vector4U23F9 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, x); }
        public readonly Vector4U23F9 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, y); }
        public readonly Vector4U23F9 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, x, z); }
        public readonly Vector4U23F9 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, x); }
        public readonly Vector4U23F9 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, y); }
        public readonly Vector4U23F9 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, y, z); }
        public readonly Vector4U23F9 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, x); }
        public readonly Vector4U23F9 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, y); }
        public readonly Vector4U23F9 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, y, z, z); }
        public readonly Vector4U23F9 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, x); }
        public readonly Vector4U23F9 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, y); }
        public readonly Vector4U23F9 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, x, z); }
        public readonly Vector4U23F9 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, x); }
        public readonly Vector4U23F9 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, y); }
        public readonly Vector4U23F9 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, y, z); }
        public readonly Vector4U23F9 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, x); }
        public readonly Vector4U23F9 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, y); }
        public readonly Vector4U23F9 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(x, z, z, z); }
        public readonly Vector4U23F9 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, x); }
        public readonly Vector4U23F9 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, y); }
        public readonly Vector4U23F9 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, x, z); }
        public readonly Vector4U23F9 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, x); }
        public readonly Vector4U23F9 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, y); }
        public readonly Vector4U23F9 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, y, z); }
        public readonly Vector4U23F9 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, x); }
        public readonly Vector4U23F9 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, y); }
        public readonly Vector4U23F9 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, x, z, z); }
        public readonly Vector4U23F9 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, x); }
        public readonly Vector4U23F9 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, y); }
        public readonly Vector4U23F9 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, x, z); }
        public readonly Vector4U23F9 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, x); }
        public readonly Vector4U23F9 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, y); }
        public readonly Vector4U23F9 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, y, z); }
        public readonly Vector4U23F9 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, x); }
        public readonly Vector4U23F9 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, y); }
        public readonly Vector4U23F9 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, y, z, z); }
        public readonly Vector4U23F9 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, x); }
        public readonly Vector4U23F9 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, y); }
        public readonly Vector4U23F9 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, x, z); }
        public readonly Vector4U23F9 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, x); }
        public readonly Vector4U23F9 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, y); }
        public readonly Vector4U23F9 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, y, z); }
        public readonly Vector4U23F9 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, x); }
        public readonly Vector4U23F9 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, y); }
        public readonly Vector4U23F9 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(y, z, z, z); }
        public readonly Vector4U23F9 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, x); }
        public readonly Vector4U23F9 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, y); }
        public readonly Vector4U23F9 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, x, z); }
        public readonly Vector4U23F9 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, x); }
        public readonly Vector4U23F9 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, y); }
        public readonly Vector4U23F9 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, y, z); }
        public readonly Vector4U23F9 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, x); }
        public readonly Vector4U23F9 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, y); }
        public readonly Vector4U23F9 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, x, z, z); }
        public readonly Vector4U23F9 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, x); }
        public readonly Vector4U23F9 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, y); }
        public readonly Vector4U23F9 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, x, z); }
        public readonly Vector4U23F9 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, x); }
        public readonly Vector4U23F9 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, y); }
        public readonly Vector4U23F9 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, y, z); }
        public readonly Vector4U23F9 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, x); }
        public readonly Vector4U23F9 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, y); }
        public readonly Vector4U23F9 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, y, z, z); }
        public readonly Vector4U23F9 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, x); }
        public readonly Vector4U23F9 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, y); }
        public readonly Vector4U23F9 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, x, z); }
        public readonly Vector4U23F9 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, x); }
        public readonly Vector4U23F9 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, y); }
        public readonly Vector4U23F9 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, y, z); }
        public readonly Vector4U23F9 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, x); }
        public readonly Vector4U23F9 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, y); }
        public readonly Vector4U23F9 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U23F9 lhs, Vector3U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U23F9 lhs, Vector3U23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U23F9({x}, {y}, {z})";

        // IEquatable<Vector3U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U23F9 other)
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
            return $"Vector3U23F9({x}, {y}, {z})";
        }
    }
}
