using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U18F14 : IEquatable<Vector3U18F14>, IFormattable {
        // Fields
        // ---------------------------------------

        public U18F14 x;
        public U18F14 y;
        public U18F14 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U18F14 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(U18F14 x, U18F14 y, U18F14 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(U18F14 x, Vector2U18F14 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(Vector3U18F14 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U18F14(Vector2U18F14 xy, U18F14 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator +(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator -(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(Vector3U18F14 a, U18F14 b) => new Vector3U18F14(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator *(U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(Vector3U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(Vector3U18F14 a, U18F14 b) => new Vector3U18F14(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 operator /(U18F14 a, Vector3U18F14 b) => new Vector3U18F14(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, x); }
        public readonly Vector2U18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, y); }
        public readonly Vector2U18F14 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(x, z); }
        public readonly Vector2U18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, x); }
        public readonly Vector2U18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, y); }
        public readonly Vector2U18F14 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(y, z); }
        public readonly Vector2U18F14 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, x); }
        public readonly Vector2U18F14 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, y); }
        public readonly Vector2U18F14 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U18F14(z, z); }
        public readonly Vector3U18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, x); }
        public readonly Vector3U18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, y); }
        public readonly Vector3U18F14 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, x, z); }
        public readonly Vector3U18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, x); }
        public readonly Vector3U18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, y); }
        public readonly Vector3U18F14 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, y, z); }
        public readonly Vector3U18F14 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, x); }
        public readonly Vector3U18F14 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, y); }
        public readonly Vector3U18F14 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(x, z, z); }
        public readonly Vector3U18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, x); }
        public readonly Vector3U18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, y); }
        public readonly Vector3U18F14 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, x, z); }
        public readonly Vector3U18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, x); }
        public readonly Vector3U18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, y); }
        public readonly Vector3U18F14 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, y, z); }
        public readonly Vector3U18F14 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, x); }
        public readonly Vector3U18F14 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, y); }
        public readonly Vector3U18F14 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(y, z, z); }
        public readonly Vector3U18F14 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, x); }
        public readonly Vector3U18F14 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, y); }
        public readonly Vector3U18F14 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, x, z); }
        public readonly Vector3U18F14 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, x); }
        public readonly Vector3U18F14 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, y); }
        public readonly Vector3U18F14 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, y, z); }
        public readonly Vector3U18F14 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, x); }
        public readonly Vector3U18F14 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, y); }
        public readonly Vector3U18F14 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U18F14(z, z, z); }
        public readonly Vector4U18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, x); }
        public readonly Vector4U18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, y); }
        public readonly Vector4U18F14 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, x, z); }
        public readonly Vector4U18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, x); }
        public readonly Vector4U18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, y); }
        public readonly Vector4U18F14 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, y, z); }
        public readonly Vector4U18F14 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, x); }
        public readonly Vector4U18F14 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, y); }
        public readonly Vector4U18F14 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, x, z, z); }
        public readonly Vector4U18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, x); }
        public readonly Vector4U18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, y); }
        public readonly Vector4U18F14 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, x, z); }
        public readonly Vector4U18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, x); }
        public readonly Vector4U18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, y); }
        public readonly Vector4U18F14 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, y, z); }
        public readonly Vector4U18F14 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, x); }
        public readonly Vector4U18F14 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, y); }
        public readonly Vector4U18F14 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, y, z, z); }
        public readonly Vector4U18F14 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, x); }
        public readonly Vector4U18F14 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, y); }
        public readonly Vector4U18F14 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, x, z); }
        public readonly Vector4U18F14 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, x); }
        public readonly Vector4U18F14 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, y); }
        public readonly Vector4U18F14 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, y, z); }
        public readonly Vector4U18F14 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, x); }
        public readonly Vector4U18F14 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, y); }
        public readonly Vector4U18F14 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(x, z, z, z); }
        public readonly Vector4U18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, x); }
        public readonly Vector4U18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, y); }
        public readonly Vector4U18F14 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, x, z); }
        public readonly Vector4U18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, x); }
        public readonly Vector4U18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, y); }
        public readonly Vector4U18F14 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, y, z); }
        public readonly Vector4U18F14 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, x); }
        public readonly Vector4U18F14 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, y); }
        public readonly Vector4U18F14 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, x, z, z); }
        public readonly Vector4U18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, x); }
        public readonly Vector4U18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, y); }
        public readonly Vector4U18F14 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, x, z); }
        public readonly Vector4U18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, x); }
        public readonly Vector4U18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, y); }
        public readonly Vector4U18F14 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, y, z); }
        public readonly Vector4U18F14 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, x); }
        public readonly Vector4U18F14 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, y); }
        public readonly Vector4U18F14 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, y, z, z); }
        public readonly Vector4U18F14 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, x); }
        public readonly Vector4U18F14 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, y); }
        public readonly Vector4U18F14 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, x, z); }
        public readonly Vector4U18F14 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, x); }
        public readonly Vector4U18F14 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, y); }
        public readonly Vector4U18F14 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, y, z); }
        public readonly Vector4U18F14 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, x); }
        public readonly Vector4U18F14 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, y); }
        public readonly Vector4U18F14 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(y, z, z, z); }
        public readonly Vector4U18F14 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, x); }
        public readonly Vector4U18F14 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, y); }
        public readonly Vector4U18F14 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, x, z); }
        public readonly Vector4U18F14 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, x); }
        public readonly Vector4U18F14 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, y); }
        public readonly Vector4U18F14 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, y, z); }
        public readonly Vector4U18F14 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, x); }
        public readonly Vector4U18F14 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, y); }
        public readonly Vector4U18F14 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, x, z, z); }
        public readonly Vector4U18F14 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, x); }
        public readonly Vector4U18F14 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, y); }
        public readonly Vector4U18F14 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, x, z); }
        public readonly Vector4U18F14 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, x); }
        public readonly Vector4U18F14 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, y); }
        public readonly Vector4U18F14 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, y, z); }
        public readonly Vector4U18F14 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, x); }
        public readonly Vector4U18F14 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, y); }
        public readonly Vector4U18F14 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, y, z, z); }
        public readonly Vector4U18F14 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, x); }
        public readonly Vector4U18F14 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, y); }
        public readonly Vector4U18F14 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, x, z); }
        public readonly Vector4U18F14 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, x); }
        public readonly Vector4U18F14 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, y); }
        public readonly Vector4U18F14 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, y, z); }
        public readonly Vector4U18F14 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, x); }
        public readonly Vector4U18F14 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, y); }
        public readonly Vector4U18F14 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U18F14(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U18F14 lhs, Vector3U18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U18F14 lhs, Vector3U18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U18F14({x}, {y}, {z})";

        // IEquatable<Vector3U18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U18F14 other)
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
            return $"Vector3U18F14({x}, {y}, {z})";
        }
    }
}
