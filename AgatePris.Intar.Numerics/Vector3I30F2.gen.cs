using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I30F2 : IEquatable<Vector3I30F2>, IFormattable {
        // Fields
        // ---------------------------------------

        public I30F2 x;
        public I30F2 y;
        public I30F2 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I30F2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, I30F2 y, I30F2 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, Vector2I30F2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector3I30F2 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector2I30F2 xy, I30F2 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator +(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator -(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(x, x); }
        public readonly Vector2I30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(x, y); }
        public readonly Vector2I30F2 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(x, z); }
        public readonly Vector2I30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(y, x); }
        public readonly Vector2I30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(y, y); }
        public readonly Vector2I30F2 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(y, z); }
        public readonly Vector2I30F2 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(z, x); }
        public readonly Vector2I30F2 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(z, y); }
        public readonly Vector2I30F2 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(z, z); }
        public readonly Vector3I30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, x, x); }
        public readonly Vector3I30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, x, y); }
        public readonly Vector3I30F2 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, x, z); }
        public readonly Vector3I30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, y, x); }
        public readonly Vector3I30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, y, y); }
        public readonly Vector3I30F2 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, y, z); }
        public readonly Vector3I30F2 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, z, x); }
        public readonly Vector3I30F2 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, z, y); }
        public readonly Vector3I30F2 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(x, z, z); }
        public readonly Vector3I30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, x, x); }
        public readonly Vector3I30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, x, y); }
        public readonly Vector3I30F2 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, x, z); }
        public readonly Vector3I30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, y, x); }
        public readonly Vector3I30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, y, y); }
        public readonly Vector3I30F2 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, y, z); }
        public readonly Vector3I30F2 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, z, x); }
        public readonly Vector3I30F2 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, z, y); }
        public readonly Vector3I30F2 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(y, z, z); }
        public readonly Vector3I30F2 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, x, x); }
        public readonly Vector3I30F2 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, x, y); }
        public readonly Vector3I30F2 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, x, z); }
        public readonly Vector3I30F2 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, y, x); }
        public readonly Vector3I30F2 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, y, y); }
        public readonly Vector3I30F2 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, y, z); }
        public readonly Vector3I30F2 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, z, x); }
        public readonly Vector3I30F2 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, z, y); }
        public readonly Vector3I30F2 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(z, z, z); }
        public readonly Vector4I30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, x, x); }
        public readonly Vector4I30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, x, y); }
        public readonly Vector4I30F2 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, x, z); }
        public readonly Vector4I30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, y, x); }
        public readonly Vector4I30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, y, y); }
        public readonly Vector4I30F2 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, y, z); }
        public readonly Vector4I30F2 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, z, x); }
        public readonly Vector4I30F2 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, z, y); }
        public readonly Vector4I30F2 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, x, z, z); }
        public readonly Vector4I30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, x, x); }
        public readonly Vector4I30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, x, y); }
        public readonly Vector4I30F2 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, x, z); }
        public readonly Vector4I30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, y, x); }
        public readonly Vector4I30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, y, y); }
        public readonly Vector4I30F2 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, y, z); }
        public readonly Vector4I30F2 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, z, x); }
        public readonly Vector4I30F2 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, z, y); }
        public readonly Vector4I30F2 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, y, z, z); }
        public readonly Vector4I30F2 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, x, x); }
        public readonly Vector4I30F2 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, x, y); }
        public readonly Vector4I30F2 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, x, z); }
        public readonly Vector4I30F2 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, y, x); }
        public readonly Vector4I30F2 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, y, y); }
        public readonly Vector4I30F2 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, y, z); }
        public readonly Vector4I30F2 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, z, x); }
        public readonly Vector4I30F2 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, z, y); }
        public readonly Vector4I30F2 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(x, z, z, z); }
        public readonly Vector4I30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, x, x); }
        public readonly Vector4I30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, x, y); }
        public readonly Vector4I30F2 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, x, z); }
        public readonly Vector4I30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, y, x); }
        public readonly Vector4I30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, y, y); }
        public readonly Vector4I30F2 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, y, z); }
        public readonly Vector4I30F2 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, z, x); }
        public readonly Vector4I30F2 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, z, y); }
        public readonly Vector4I30F2 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, x, z, z); }
        public readonly Vector4I30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, x, x); }
        public readonly Vector4I30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, x, y); }
        public readonly Vector4I30F2 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, x, z); }
        public readonly Vector4I30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, y, x); }
        public readonly Vector4I30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, y, y); }
        public readonly Vector4I30F2 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, y, z); }
        public readonly Vector4I30F2 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, z, x); }
        public readonly Vector4I30F2 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, z, y); }
        public readonly Vector4I30F2 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, y, z, z); }
        public readonly Vector4I30F2 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, x, x); }
        public readonly Vector4I30F2 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, x, y); }
        public readonly Vector4I30F2 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, x, z); }
        public readonly Vector4I30F2 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, y, x); }
        public readonly Vector4I30F2 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, y, y); }
        public readonly Vector4I30F2 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, y, z); }
        public readonly Vector4I30F2 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, z, x); }
        public readonly Vector4I30F2 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, z, y); }
        public readonly Vector4I30F2 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(y, z, z, z); }
        public readonly Vector4I30F2 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, x, x); }
        public readonly Vector4I30F2 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, x, y); }
        public readonly Vector4I30F2 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, x, z); }
        public readonly Vector4I30F2 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, y, x); }
        public readonly Vector4I30F2 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, y, y); }
        public readonly Vector4I30F2 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, y, z); }
        public readonly Vector4I30F2 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, z, x); }
        public readonly Vector4I30F2 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, z, y); }
        public readonly Vector4I30F2 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, x, z, z); }
        public readonly Vector4I30F2 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, x, x); }
        public readonly Vector4I30F2 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, x, y); }
        public readonly Vector4I30F2 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, x, z); }
        public readonly Vector4I30F2 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, y, x); }
        public readonly Vector4I30F2 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, y, y); }
        public readonly Vector4I30F2 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, y, z); }
        public readonly Vector4I30F2 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, z, x); }
        public readonly Vector4I30F2 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, z, y); }
        public readonly Vector4I30F2 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, y, z, z); }
        public readonly Vector4I30F2 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, x, x); }
        public readonly Vector4I30F2 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, x, y); }
        public readonly Vector4I30F2 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, x, z); }
        public readonly Vector4I30F2 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, y, x); }
        public readonly Vector4I30F2 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, y, y); }
        public readonly Vector4I30F2 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, y, z); }
        public readonly Vector4I30F2 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, z, x); }
        public readonly Vector4I30F2 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, z, y); }
        public readonly Vector4I30F2 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I30F2 lhs, Vector3I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I30F2 lhs, Vector3I30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I30F2({x}, {y}, {z})";

        // IEquatable<Vector3I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I30F2 other)
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
            return $"Vector3I30F2({x}, {y}, {z})";
        }
    }
}
