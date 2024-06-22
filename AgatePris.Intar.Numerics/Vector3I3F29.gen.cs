using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I3F29 : IEquatable<Vector3I3F29>, IFormattable {
        // Fields
        // ---------------------------------------

        public I3F29 x;
        public I3F29 y;
        public I3F29 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I3F29 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(I3F29 x, I3F29 y, I3F29 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(I3F29 x, Vector2I3F29 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(Vector3I3F29 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I3F29(Vector2I3F29 xy, I3F29 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator +(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator -(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(Vector3I3F29 a, I3F29 b) => new Vector3I3F29(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator *(I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(Vector3I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(Vector3I3F29 a, I3F29 b) => new Vector3I3F29(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 operator /(I3F29 a, Vector3I3F29 b) => new Vector3I3F29(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, x); }
        public readonly Vector2I3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, y); }
        public readonly Vector2I3F29 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, z); }
        public readonly Vector2I3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, x); }
        public readonly Vector2I3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, y); }
        public readonly Vector2I3F29 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, z); }
        public readonly Vector2I3F29 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, x); }
        public readonly Vector2I3F29 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, y); }
        public readonly Vector2I3F29 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(z, z); }
        public readonly Vector3I3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, x); }
        public readonly Vector3I3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, y); }
        public readonly Vector3I3F29 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, z); }
        public readonly Vector3I3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, x); }
        public readonly Vector3I3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, y); }
        public readonly Vector3I3F29 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, z); }
        public readonly Vector3I3F29 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, x); }
        public readonly Vector3I3F29 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, y); }
        public readonly Vector3I3F29 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, z, z); }
        public readonly Vector3I3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, x); }
        public readonly Vector3I3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, y); }
        public readonly Vector3I3F29 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, z); }
        public readonly Vector3I3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, x); }
        public readonly Vector3I3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, y); }
        public readonly Vector3I3F29 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, z); }
        public readonly Vector3I3F29 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, x); }
        public readonly Vector3I3F29 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, y); }
        public readonly Vector3I3F29 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, z, z); }
        public readonly Vector3I3F29 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, x); }
        public readonly Vector3I3F29 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, y); }
        public readonly Vector3I3F29 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, x, z); }
        public readonly Vector3I3F29 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, x); }
        public readonly Vector3I3F29 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, y); }
        public readonly Vector3I3F29 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, y, z); }
        public readonly Vector3I3F29 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, x); }
        public readonly Vector3I3F29 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, y); }
        public readonly Vector3I3F29 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(z, z, z); }
        public readonly Vector4I3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, x); }
        public readonly Vector4I3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, y); }
        public readonly Vector4I3F29 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, z); }
        public readonly Vector4I3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, x); }
        public readonly Vector4I3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, y); }
        public readonly Vector4I3F29 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, z); }
        public readonly Vector4I3F29 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, x); }
        public readonly Vector4I3F29 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, y); }
        public readonly Vector4I3F29 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, z, z); }
        public readonly Vector4I3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, x); }
        public readonly Vector4I3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, y); }
        public readonly Vector4I3F29 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, z); }
        public readonly Vector4I3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, x); }
        public readonly Vector4I3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, y); }
        public readonly Vector4I3F29 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, z); }
        public readonly Vector4I3F29 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, x); }
        public readonly Vector4I3F29 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, y); }
        public readonly Vector4I3F29 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, z, z); }
        public readonly Vector4I3F29 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, x); }
        public readonly Vector4I3F29 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, y); }
        public readonly Vector4I3F29 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, x, z); }
        public readonly Vector4I3F29 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, x); }
        public readonly Vector4I3F29 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, y); }
        public readonly Vector4I3F29 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, y, z); }
        public readonly Vector4I3F29 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, x); }
        public readonly Vector4I3F29 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, y); }
        public readonly Vector4I3F29 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, z, z, z); }
        public readonly Vector4I3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, x); }
        public readonly Vector4I3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, y); }
        public readonly Vector4I3F29 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, z); }
        public readonly Vector4I3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, x); }
        public readonly Vector4I3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, y); }
        public readonly Vector4I3F29 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, z); }
        public readonly Vector4I3F29 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, x); }
        public readonly Vector4I3F29 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, y); }
        public readonly Vector4I3F29 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, z, z); }
        public readonly Vector4I3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, x); }
        public readonly Vector4I3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, y); }
        public readonly Vector4I3F29 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, z); }
        public readonly Vector4I3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, x); }
        public readonly Vector4I3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, y); }
        public readonly Vector4I3F29 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, z); }
        public readonly Vector4I3F29 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, x); }
        public readonly Vector4I3F29 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, y); }
        public readonly Vector4I3F29 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, z, z); }
        public readonly Vector4I3F29 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, x); }
        public readonly Vector4I3F29 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, y); }
        public readonly Vector4I3F29 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, x, z); }
        public readonly Vector4I3F29 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, x); }
        public readonly Vector4I3F29 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, y); }
        public readonly Vector4I3F29 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, y, z); }
        public readonly Vector4I3F29 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, x); }
        public readonly Vector4I3F29 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, y); }
        public readonly Vector4I3F29 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, z, z, z); }
        public readonly Vector4I3F29 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, x); }
        public readonly Vector4I3F29 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, y); }
        public readonly Vector4I3F29 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, x, z); }
        public readonly Vector4I3F29 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, x); }
        public readonly Vector4I3F29 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, y); }
        public readonly Vector4I3F29 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, y, z); }
        public readonly Vector4I3F29 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, x); }
        public readonly Vector4I3F29 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, y); }
        public readonly Vector4I3F29 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, x, z, z); }
        public readonly Vector4I3F29 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, x); }
        public readonly Vector4I3F29 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, y); }
        public readonly Vector4I3F29 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, x, z); }
        public readonly Vector4I3F29 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, x); }
        public readonly Vector4I3F29 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, y); }
        public readonly Vector4I3F29 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, y, z); }
        public readonly Vector4I3F29 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, x); }
        public readonly Vector4I3F29 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, y); }
        public readonly Vector4I3F29 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, y, z, z); }
        public readonly Vector4I3F29 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, x); }
        public readonly Vector4I3F29 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, y); }
        public readonly Vector4I3F29 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, x, z); }
        public readonly Vector4I3F29 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, x); }
        public readonly Vector4I3F29 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, y); }
        public readonly Vector4I3F29 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, y, z); }
        public readonly Vector4I3F29 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, x); }
        public readonly Vector4I3F29 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, y); }
        public readonly Vector4I3F29 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I3F29 lhs, Vector3I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I3F29 lhs, Vector3I3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I3F29({x}, {y}, {z})";

        // IEquatable<Vector3I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I3F29 other)
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
            return $"Vector3I3F29({x}, {y}, {z})";
        }
    }
}
