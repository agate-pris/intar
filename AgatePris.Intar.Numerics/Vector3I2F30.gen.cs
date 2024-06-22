using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I2F30 : IEquatable<Vector3I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

        public I2F30 x;
        public I2F30 y;
        public I2F30 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I2F30 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 x, I2F30 y, I2F30 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 x, Vector2I2F30 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(Vector3I2F30 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(Vector2I2F30 xy, I2F30 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator +(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator -(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I2F30 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(x, x); }
        public readonly Vector2I2F30 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(x, y); }
        public readonly Vector2I2F30 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(x, z); }
        public readonly Vector2I2F30 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(y, x); }
        public readonly Vector2I2F30 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(y, y); }
        public readonly Vector2I2F30 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(y, z); }
        public readonly Vector2I2F30 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(z, x); }
        public readonly Vector2I2F30 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(z, y); }
        public readonly Vector2I2F30 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(z, z); }
        public readonly Vector3I2F30 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, x, x); }
        public readonly Vector3I2F30 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, x, y); }
        public readonly Vector3I2F30 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, x, z); }
        public readonly Vector3I2F30 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, y, x); }
        public readonly Vector3I2F30 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, y, y); }
        public readonly Vector3I2F30 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, y, z); }
        public readonly Vector3I2F30 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, z, x); }
        public readonly Vector3I2F30 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, z, y); }
        public readonly Vector3I2F30 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, z, z); }
        public readonly Vector3I2F30 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, x, x); }
        public readonly Vector3I2F30 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, x, y); }
        public readonly Vector3I2F30 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, x, z); }
        public readonly Vector3I2F30 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, y, x); }
        public readonly Vector3I2F30 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, y, y); }
        public readonly Vector3I2F30 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, y, z); }
        public readonly Vector3I2F30 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, z, x); }
        public readonly Vector3I2F30 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, z, y); }
        public readonly Vector3I2F30 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, z, z); }
        public readonly Vector3I2F30 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, x, x); }
        public readonly Vector3I2F30 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, x, y); }
        public readonly Vector3I2F30 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, x, z); }
        public readonly Vector3I2F30 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, y, x); }
        public readonly Vector3I2F30 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, y, y); }
        public readonly Vector3I2F30 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, y, z); }
        public readonly Vector3I2F30 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, z, x); }
        public readonly Vector3I2F30 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, z, y); }
        public readonly Vector3I2F30 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(z, z, z); }
        public readonly Vector4I2F30 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, x, x); }
        public readonly Vector4I2F30 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, x, y); }
        public readonly Vector4I2F30 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, x, z); }
        public readonly Vector4I2F30 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, y, x); }
        public readonly Vector4I2F30 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, y, y); }
        public readonly Vector4I2F30 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, y, z); }
        public readonly Vector4I2F30 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, z, x); }
        public readonly Vector4I2F30 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, z, y); }
        public readonly Vector4I2F30 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, z, z); }
        public readonly Vector4I2F30 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, x, x); }
        public readonly Vector4I2F30 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, x, y); }
        public readonly Vector4I2F30 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, x, z); }
        public readonly Vector4I2F30 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, y, x); }
        public readonly Vector4I2F30 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, y, y); }
        public readonly Vector4I2F30 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, y, z); }
        public readonly Vector4I2F30 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, z, x); }
        public readonly Vector4I2F30 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, z, y); }
        public readonly Vector4I2F30 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, z, z); }
        public readonly Vector4I2F30 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, x, x); }
        public readonly Vector4I2F30 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, x, y); }
        public readonly Vector4I2F30 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, x, z); }
        public readonly Vector4I2F30 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, y, x); }
        public readonly Vector4I2F30 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, y, y); }
        public readonly Vector4I2F30 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, y, z); }
        public readonly Vector4I2F30 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, z, x); }
        public readonly Vector4I2F30 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, z, y); }
        public readonly Vector4I2F30 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, z, z, z); }
        public readonly Vector4I2F30 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, x, x); }
        public readonly Vector4I2F30 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, x, y); }
        public readonly Vector4I2F30 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, x, z); }
        public readonly Vector4I2F30 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, y, x); }
        public readonly Vector4I2F30 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, y, y); }
        public readonly Vector4I2F30 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, y, z); }
        public readonly Vector4I2F30 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, z, x); }
        public readonly Vector4I2F30 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, z, y); }
        public readonly Vector4I2F30 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, z, z); }
        public readonly Vector4I2F30 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, x, x); }
        public readonly Vector4I2F30 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, x, y); }
        public readonly Vector4I2F30 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, x, z); }
        public readonly Vector4I2F30 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, y, x); }
        public readonly Vector4I2F30 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, y, y); }
        public readonly Vector4I2F30 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, y, z); }
        public readonly Vector4I2F30 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, z, x); }
        public readonly Vector4I2F30 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, z, y); }
        public readonly Vector4I2F30 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, z, z); }
        public readonly Vector4I2F30 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, x, x); }
        public readonly Vector4I2F30 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, x, y); }
        public readonly Vector4I2F30 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, x, z); }
        public readonly Vector4I2F30 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, y, x); }
        public readonly Vector4I2F30 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, y, y); }
        public readonly Vector4I2F30 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, y, z); }
        public readonly Vector4I2F30 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, z, x); }
        public readonly Vector4I2F30 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, z, y); }
        public readonly Vector4I2F30 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, z, z, z); }
        public readonly Vector4I2F30 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, x, x); }
        public readonly Vector4I2F30 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, x, y); }
        public readonly Vector4I2F30 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, x, z); }
        public readonly Vector4I2F30 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, y, x); }
        public readonly Vector4I2F30 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, y, y); }
        public readonly Vector4I2F30 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, y, z); }
        public readonly Vector4I2F30 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, z, x); }
        public readonly Vector4I2F30 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, z, y); }
        public readonly Vector4I2F30 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, x, z, z); }
        public readonly Vector4I2F30 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, x, x); }
        public readonly Vector4I2F30 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, x, y); }
        public readonly Vector4I2F30 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, x, z); }
        public readonly Vector4I2F30 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, y, x); }
        public readonly Vector4I2F30 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, y, y); }
        public readonly Vector4I2F30 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, y, z); }
        public readonly Vector4I2F30 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, z, x); }
        public readonly Vector4I2F30 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, z, y); }
        public readonly Vector4I2F30 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, y, z, z); }
        public readonly Vector4I2F30 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, x, x); }
        public readonly Vector4I2F30 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, x, y); }
        public readonly Vector4I2F30 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, x, z); }
        public readonly Vector4I2F30 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, y, x); }
        public readonly Vector4I2F30 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, y, y); }
        public readonly Vector4I2F30 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, y, z); }
        public readonly Vector4I2F30 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, z, x); }
        public readonly Vector4I2F30 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, z, y); }
        public readonly Vector4I2F30 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I2F30 lhs, Vector3I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I2F30 lhs, Vector3I2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I2F30({x}, {y}, {z})";

        // IEquatable<Vector3I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I2F30 other)
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
            return $"Vector3I2F30({x}, {y}, {z})";
        }
    }
}
