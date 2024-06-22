using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3U15F17 : IEquatable<Vector3U15F17>, IFormattable {
        // Fields
        // ---------------------------------------

        public U15F17 x;
        public U15F17 y;
        public U15F17 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3U15F17 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, U15F17 y, U15F17 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, Vector2U15F17 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector3U15F17 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector2U15F17 xy, U15F17 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator +(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator -(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U15F17 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(x, x); }
        public readonly Vector2U15F17 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(x, y); }
        public readonly Vector2U15F17 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(x, z); }
        public readonly Vector2U15F17 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(y, x); }
        public readonly Vector2U15F17 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(y, y); }
        public readonly Vector2U15F17 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(y, z); }
        public readonly Vector2U15F17 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(z, x); }
        public readonly Vector2U15F17 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(z, y); }
        public readonly Vector2U15F17 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(z, z); }
        public readonly Vector3U15F17 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, x, x); }
        public readonly Vector3U15F17 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, x, y); }
        public readonly Vector3U15F17 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, x, z); }
        public readonly Vector3U15F17 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, y, x); }
        public readonly Vector3U15F17 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, y, y); }
        public readonly Vector3U15F17 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, y, z); }
        public readonly Vector3U15F17 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, z, x); }
        public readonly Vector3U15F17 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, z, y); }
        public readonly Vector3U15F17 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(x, z, z); }
        public readonly Vector3U15F17 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, x, x); }
        public readonly Vector3U15F17 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, x, y); }
        public readonly Vector3U15F17 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, x, z); }
        public readonly Vector3U15F17 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, y, x); }
        public readonly Vector3U15F17 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, y, y); }
        public readonly Vector3U15F17 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, y, z); }
        public readonly Vector3U15F17 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, z, x); }
        public readonly Vector3U15F17 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, z, y); }
        public readonly Vector3U15F17 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(y, z, z); }
        public readonly Vector3U15F17 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, x, x); }
        public readonly Vector3U15F17 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, x, y); }
        public readonly Vector3U15F17 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, x, z); }
        public readonly Vector3U15F17 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, y, x); }
        public readonly Vector3U15F17 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, y, y); }
        public readonly Vector3U15F17 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, y, z); }
        public readonly Vector3U15F17 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, z, x); }
        public readonly Vector3U15F17 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, z, y); }
        public readonly Vector3U15F17 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(z, z, z); }
        public readonly Vector4U15F17 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, x, x); }
        public readonly Vector4U15F17 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, x, y); }
        public readonly Vector4U15F17 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, x, z); }
        public readonly Vector4U15F17 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, y, x); }
        public readonly Vector4U15F17 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, y, y); }
        public readonly Vector4U15F17 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, y, z); }
        public readonly Vector4U15F17 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, z, x); }
        public readonly Vector4U15F17 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, z, y); }
        public readonly Vector4U15F17 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, x, z, z); }
        public readonly Vector4U15F17 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, x, x); }
        public readonly Vector4U15F17 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, x, y); }
        public readonly Vector4U15F17 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, x, z); }
        public readonly Vector4U15F17 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, y, x); }
        public readonly Vector4U15F17 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, y, y); }
        public readonly Vector4U15F17 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, y, z); }
        public readonly Vector4U15F17 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, z, x); }
        public readonly Vector4U15F17 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, z, y); }
        public readonly Vector4U15F17 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, y, z, z); }
        public readonly Vector4U15F17 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, x, x); }
        public readonly Vector4U15F17 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, x, y); }
        public readonly Vector4U15F17 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, x, z); }
        public readonly Vector4U15F17 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, y, x); }
        public readonly Vector4U15F17 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, y, y); }
        public readonly Vector4U15F17 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, y, z); }
        public readonly Vector4U15F17 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, z, x); }
        public readonly Vector4U15F17 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, z, y); }
        public readonly Vector4U15F17 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(x, z, z, z); }
        public readonly Vector4U15F17 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, x, x); }
        public readonly Vector4U15F17 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, x, y); }
        public readonly Vector4U15F17 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, x, z); }
        public readonly Vector4U15F17 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, y, x); }
        public readonly Vector4U15F17 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, y, y); }
        public readonly Vector4U15F17 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, y, z); }
        public readonly Vector4U15F17 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, z, x); }
        public readonly Vector4U15F17 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, z, y); }
        public readonly Vector4U15F17 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, x, z, z); }
        public readonly Vector4U15F17 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, x, x); }
        public readonly Vector4U15F17 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, x, y); }
        public readonly Vector4U15F17 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, x, z); }
        public readonly Vector4U15F17 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, y, x); }
        public readonly Vector4U15F17 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, y, y); }
        public readonly Vector4U15F17 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, y, z); }
        public readonly Vector4U15F17 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, z, x); }
        public readonly Vector4U15F17 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, z, y); }
        public readonly Vector4U15F17 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, y, z, z); }
        public readonly Vector4U15F17 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, x, x); }
        public readonly Vector4U15F17 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, x, y); }
        public readonly Vector4U15F17 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, x, z); }
        public readonly Vector4U15F17 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, y, x); }
        public readonly Vector4U15F17 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, y, y); }
        public readonly Vector4U15F17 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, y, z); }
        public readonly Vector4U15F17 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, z, x); }
        public readonly Vector4U15F17 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, z, y); }
        public readonly Vector4U15F17 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(y, z, z, z); }
        public readonly Vector4U15F17 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, x, x); }
        public readonly Vector4U15F17 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, x, y); }
        public readonly Vector4U15F17 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, x, z); }
        public readonly Vector4U15F17 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, y, x); }
        public readonly Vector4U15F17 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, y, y); }
        public readonly Vector4U15F17 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, y, z); }
        public readonly Vector4U15F17 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, z, x); }
        public readonly Vector4U15F17 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, z, y); }
        public readonly Vector4U15F17 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, x, z, z); }
        public readonly Vector4U15F17 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, x, x); }
        public readonly Vector4U15F17 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, x, y); }
        public readonly Vector4U15F17 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, x, z); }
        public readonly Vector4U15F17 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, y, x); }
        public readonly Vector4U15F17 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, y, y); }
        public readonly Vector4U15F17 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, y, z); }
        public readonly Vector4U15F17 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, z, x); }
        public readonly Vector4U15F17 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, z, y); }
        public readonly Vector4U15F17 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, y, z, z); }
        public readonly Vector4U15F17 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, x, x); }
        public readonly Vector4U15F17 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, x, y); }
        public readonly Vector4U15F17 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, x, z); }
        public readonly Vector4U15F17 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, y, x); }
        public readonly Vector4U15F17 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, y, y); }
        public readonly Vector4U15F17 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, y, z); }
        public readonly Vector4U15F17 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, z, x); }
        public readonly Vector4U15F17 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, z, y); }
        public readonly Vector4U15F17 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U15F17 lhs, Vector3U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U15F17 lhs, Vector3U15F17 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3U15F17({x}, {y}, {z})";

        // IEquatable<Vector3U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3U15F17 other)
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
            return $"Vector3U15F17({x}, {y}, {z})";
        }
    }
}
