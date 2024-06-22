using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U20F12 : IEquatable<Vector3U20F12>, IFormattable {
        // Fields
        // ---------------------------------------

        public U20F12 x;
        public U20F12 y;
        public U20F12 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U20F12 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U20F12(U20F12 x, U20F12 y, U20F12 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U20F12(U20F12 x, Vector2U20F12 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U20F12(Vector3U20F12 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U20F12(Vector2U20F12 xy, U20F12 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator +(Vector3U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator -(Vector3U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator *(Vector3U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator *(Vector3U20F12 a, U20F12 b) => new Vector3U20F12(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator *(U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator /(Vector3U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator /(Vector3U20F12 a, U20F12 b) => new Vector3U20F12(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 operator /(U20F12 a, Vector3U20F12 b) => new Vector3U20F12(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, x); }
        public readonly Vector2U20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, y); }
        public readonly Vector2U20F12 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(x, z); }
        public readonly Vector2U20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, x); }
        public readonly Vector2U20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, y); }
        public readonly Vector2U20F12 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(y, z); }
        public readonly Vector2U20F12 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, x); }
        public readonly Vector2U20F12 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, y); }
        public readonly Vector2U20F12 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(z, z); }
        public readonly Vector3U20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, x); }
        public readonly Vector3U20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, y); }
        public readonly Vector3U20F12 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, x, z); }
        public readonly Vector3U20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, x); }
        public readonly Vector3U20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, y); }
        public readonly Vector3U20F12 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, y, z); }
        public readonly Vector3U20F12 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, x); }
        public readonly Vector3U20F12 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, y); }
        public readonly Vector3U20F12 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(x, z, z); }
        public readonly Vector3U20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, x); }
        public readonly Vector3U20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, y); }
        public readonly Vector3U20F12 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, x, z); }
        public readonly Vector3U20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, x); }
        public readonly Vector3U20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, y); }
        public readonly Vector3U20F12 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, y, z); }
        public readonly Vector3U20F12 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, x); }
        public readonly Vector3U20F12 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, y); }
        public readonly Vector3U20F12 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(y, z, z); }
        public readonly Vector3U20F12 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, x); }
        public readonly Vector3U20F12 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, y); }
        public readonly Vector3U20F12 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, x, z); }
        public readonly Vector3U20F12 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, x); }
        public readonly Vector3U20F12 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, y); }
        public readonly Vector3U20F12 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, y, z); }
        public readonly Vector3U20F12 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, x); }
        public readonly Vector3U20F12 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, y); }
        public readonly Vector3U20F12 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(z, z, z); }
        public readonly Vector4U20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, x); }
        public readonly Vector4U20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, y); }
        public readonly Vector4U20F12 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, x, z); }
        public readonly Vector4U20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, x); }
        public readonly Vector4U20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, y); }
        public readonly Vector4U20F12 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, y, z); }
        public readonly Vector4U20F12 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, x); }
        public readonly Vector4U20F12 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, y); }
        public readonly Vector4U20F12 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, x, z, z); }
        public readonly Vector4U20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, x); }
        public readonly Vector4U20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, y); }
        public readonly Vector4U20F12 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, x, z); }
        public readonly Vector4U20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, x); }
        public readonly Vector4U20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, y); }
        public readonly Vector4U20F12 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, y, z); }
        public readonly Vector4U20F12 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, x); }
        public readonly Vector4U20F12 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, y); }
        public readonly Vector4U20F12 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, y, z, z); }
        public readonly Vector4U20F12 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, x); }
        public readonly Vector4U20F12 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, y); }
        public readonly Vector4U20F12 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, x, z); }
        public readonly Vector4U20F12 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, x); }
        public readonly Vector4U20F12 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, y); }
        public readonly Vector4U20F12 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, y, z); }
        public readonly Vector4U20F12 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, x); }
        public readonly Vector4U20F12 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, y); }
        public readonly Vector4U20F12 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(x, z, z, z); }
        public readonly Vector4U20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, x); }
        public readonly Vector4U20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, y); }
        public readonly Vector4U20F12 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, x, z); }
        public readonly Vector4U20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, x); }
        public readonly Vector4U20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, y); }
        public readonly Vector4U20F12 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, y, z); }
        public readonly Vector4U20F12 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, x); }
        public readonly Vector4U20F12 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, y); }
        public readonly Vector4U20F12 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, x, z, z); }
        public readonly Vector4U20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, x); }
        public readonly Vector4U20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, y); }
        public readonly Vector4U20F12 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, x, z); }
        public readonly Vector4U20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, x); }
        public readonly Vector4U20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, y); }
        public readonly Vector4U20F12 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, y, z); }
        public readonly Vector4U20F12 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, x); }
        public readonly Vector4U20F12 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, y); }
        public readonly Vector4U20F12 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, y, z, z); }
        public readonly Vector4U20F12 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, x); }
        public readonly Vector4U20F12 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, y); }
        public readonly Vector4U20F12 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, x, z); }
        public readonly Vector4U20F12 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, x); }
        public readonly Vector4U20F12 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, y); }
        public readonly Vector4U20F12 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, y, z); }
        public readonly Vector4U20F12 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, x); }
        public readonly Vector4U20F12 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, y); }
        public readonly Vector4U20F12 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(y, z, z, z); }
        public readonly Vector4U20F12 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, x); }
        public readonly Vector4U20F12 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, y); }
        public readonly Vector4U20F12 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, x, z); }
        public readonly Vector4U20F12 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, x); }
        public readonly Vector4U20F12 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, y); }
        public readonly Vector4U20F12 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, y, z); }
        public readonly Vector4U20F12 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, x); }
        public readonly Vector4U20F12 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, y); }
        public readonly Vector4U20F12 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, x, z, z); }
        public readonly Vector4U20F12 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, x); }
        public readonly Vector4U20F12 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, y); }
        public readonly Vector4U20F12 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, x, z); }
        public readonly Vector4U20F12 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, x); }
        public readonly Vector4U20F12 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, y); }
        public readonly Vector4U20F12 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, y, z); }
        public readonly Vector4U20F12 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, x); }
        public readonly Vector4U20F12 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, y); }
        public readonly Vector4U20F12 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, y, z, z); }
        public readonly Vector4U20F12 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, x); }
        public readonly Vector4U20F12 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, y); }
        public readonly Vector4U20F12 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, x, z); }
        public readonly Vector4U20F12 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, x); }
        public readonly Vector4U20F12 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, y); }
        public readonly Vector4U20F12 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, y, z); }
        public readonly Vector4U20F12 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, x); }
        public readonly Vector4U20F12 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, y); }
        public readonly Vector4U20F12 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U20F12 lhs, Vector3U20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U20F12 lhs, Vector3U20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U20F12({x}, {y}, {z})";

        // IEquatable<Vector3U20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U20F12 other)
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
            return $"Vector3U20F12({x}, {y}, {z})";
        }
    }
}
