using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I31F1 : IEquatable<Vector3I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

        public I31F1 x;
        public I31F1 y;
        public I31F1 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I31F1 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(I31F1 x, I31F1 y, I31F1 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(I31F1 x, Vector2I31F1 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(Vector3I31F1 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I31F1(Vector2I31F1 xy, I31F1 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator +(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator -(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(Vector3I31F1 a, I31F1 b) => new Vector3I31F1(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator *(I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(Vector3I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(Vector3I31F1 a, I31F1 b) => new Vector3I31F1(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 operator /(I31F1 a, Vector3I31F1 b) => new Vector3I31F1(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, x); }
        public readonly Vector2I31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, y); }
        public readonly Vector2I31F1 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, z); }
        public readonly Vector2I31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, x); }
        public readonly Vector2I31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, y); }
        public readonly Vector2I31F1 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, z); }
        public readonly Vector2I31F1 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, x); }
        public readonly Vector2I31F1 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, y); }
        public readonly Vector2I31F1 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(z, z); }
        public readonly Vector3I31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, x); }
        public readonly Vector3I31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, y); }
        public readonly Vector3I31F1 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, z); }
        public readonly Vector3I31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, x); }
        public readonly Vector3I31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, y); }
        public readonly Vector3I31F1 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, z); }
        public readonly Vector3I31F1 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, x); }
        public readonly Vector3I31F1 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, y); }
        public readonly Vector3I31F1 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, z, z); }
        public readonly Vector3I31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, x); }
        public readonly Vector3I31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, y); }
        public readonly Vector3I31F1 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, z); }
        public readonly Vector3I31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, x); }
        public readonly Vector3I31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, y); }
        public readonly Vector3I31F1 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, z); }
        public readonly Vector3I31F1 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, x); }
        public readonly Vector3I31F1 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, y); }
        public readonly Vector3I31F1 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, z, z); }
        public readonly Vector3I31F1 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, x); }
        public readonly Vector3I31F1 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, y); }
        public readonly Vector3I31F1 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, x, z); }
        public readonly Vector3I31F1 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, x); }
        public readonly Vector3I31F1 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, y); }
        public readonly Vector3I31F1 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, y, z); }
        public readonly Vector3I31F1 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, x); }
        public readonly Vector3I31F1 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, y); }
        public readonly Vector3I31F1 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(z, z, z); }
        public readonly Vector4I31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, x); }
        public readonly Vector4I31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, y); }
        public readonly Vector4I31F1 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, z); }
        public readonly Vector4I31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, x); }
        public readonly Vector4I31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, y); }
        public readonly Vector4I31F1 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, z); }
        public readonly Vector4I31F1 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, x); }
        public readonly Vector4I31F1 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, y); }
        public readonly Vector4I31F1 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, z, z); }
        public readonly Vector4I31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, x); }
        public readonly Vector4I31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, y); }
        public readonly Vector4I31F1 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, z); }
        public readonly Vector4I31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, x); }
        public readonly Vector4I31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, y); }
        public readonly Vector4I31F1 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, z); }
        public readonly Vector4I31F1 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, x); }
        public readonly Vector4I31F1 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, y); }
        public readonly Vector4I31F1 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, z, z); }
        public readonly Vector4I31F1 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, x); }
        public readonly Vector4I31F1 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, y); }
        public readonly Vector4I31F1 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, x, z); }
        public readonly Vector4I31F1 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, x); }
        public readonly Vector4I31F1 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, y); }
        public readonly Vector4I31F1 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, y, z); }
        public readonly Vector4I31F1 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, x); }
        public readonly Vector4I31F1 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, y); }
        public readonly Vector4I31F1 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, z, z, z); }
        public readonly Vector4I31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, x); }
        public readonly Vector4I31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, y); }
        public readonly Vector4I31F1 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, z); }
        public readonly Vector4I31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, x); }
        public readonly Vector4I31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, y); }
        public readonly Vector4I31F1 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, z); }
        public readonly Vector4I31F1 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, x); }
        public readonly Vector4I31F1 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, y); }
        public readonly Vector4I31F1 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, z, z); }
        public readonly Vector4I31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, x); }
        public readonly Vector4I31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, y); }
        public readonly Vector4I31F1 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, z); }
        public readonly Vector4I31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, x); }
        public readonly Vector4I31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, y); }
        public readonly Vector4I31F1 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, z); }
        public readonly Vector4I31F1 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, x); }
        public readonly Vector4I31F1 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, y); }
        public readonly Vector4I31F1 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, z, z); }
        public readonly Vector4I31F1 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, x); }
        public readonly Vector4I31F1 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, y); }
        public readonly Vector4I31F1 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, x, z); }
        public readonly Vector4I31F1 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, x); }
        public readonly Vector4I31F1 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, y); }
        public readonly Vector4I31F1 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, y, z); }
        public readonly Vector4I31F1 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, x); }
        public readonly Vector4I31F1 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, y); }
        public readonly Vector4I31F1 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, z, z, z); }
        public readonly Vector4I31F1 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, x); }
        public readonly Vector4I31F1 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, y); }
        public readonly Vector4I31F1 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, x, z); }
        public readonly Vector4I31F1 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, x); }
        public readonly Vector4I31F1 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, y); }
        public readonly Vector4I31F1 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, y, z); }
        public readonly Vector4I31F1 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, x); }
        public readonly Vector4I31F1 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, y); }
        public readonly Vector4I31F1 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, x, z, z); }
        public readonly Vector4I31F1 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, x); }
        public readonly Vector4I31F1 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, y); }
        public readonly Vector4I31F1 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, x, z); }
        public readonly Vector4I31F1 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, x); }
        public readonly Vector4I31F1 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, y); }
        public readonly Vector4I31F1 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, y, z); }
        public readonly Vector4I31F1 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, x); }
        public readonly Vector4I31F1 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, y); }
        public readonly Vector4I31F1 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, y, z, z); }
        public readonly Vector4I31F1 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, x); }
        public readonly Vector4I31F1 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, y); }
        public readonly Vector4I31F1 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, x, z); }
        public readonly Vector4I31F1 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, x); }
        public readonly Vector4I31F1 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, y); }
        public readonly Vector4I31F1 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, y, z); }
        public readonly Vector4I31F1 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, x); }
        public readonly Vector4I31F1 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, y); }
        public readonly Vector4I31F1 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I31F1 lhs, Vector3I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I31F1 lhs, Vector3I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I31F1({x}, {y}, {z})";

        // IEquatable<Vector3I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I31F1 other)
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
            return $"Vector3I31F1({x}, {y}, {z})";
        }
    }
}
