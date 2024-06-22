using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I19F13 : IEquatable<Vector3I19F13>, IFormattable {
        // Fields
        // ---------------------------------------

        public I19F13 x;
        public I19F13 y;
        public I19F13 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I19F13 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I19F13(I19F13 x, I19F13 y, I19F13 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I19F13(I19F13 x, Vector2I19F13 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I19F13(Vector3I19F13 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I19F13(Vector2I19F13 xy, I19F13 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator +(Vector3I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator -(Vector3I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator *(Vector3I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator *(Vector3I19F13 a, I19F13 b) => new Vector3I19F13(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator *(I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator /(Vector3I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator /(Vector3I19F13 a, I19F13 b) => new Vector3I19F13(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 operator /(I19F13 a, Vector3I19F13 b) => new Vector3I19F13(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, x); }
        public readonly Vector2I19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, y); }
        public readonly Vector2I19F13 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, z); }
        public readonly Vector2I19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, x); }
        public readonly Vector2I19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, y); }
        public readonly Vector2I19F13 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, z); }
        public readonly Vector2I19F13 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, x); }
        public readonly Vector2I19F13 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, y); }
        public readonly Vector2I19F13 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(z, z); }
        public readonly Vector3I19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, x); }
        public readonly Vector3I19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, y); }
        public readonly Vector3I19F13 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, z); }
        public readonly Vector3I19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, x); }
        public readonly Vector3I19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, y); }
        public readonly Vector3I19F13 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, z); }
        public readonly Vector3I19F13 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, x); }
        public readonly Vector3I19F13 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, y); }
        public readonly Vector3I19F13 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, z, z); }
        public readonly Vector3I19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, x); }
        public readonly Vector3I19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, y); }
        public readonly Vector3I19F13 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, z); }
        public readonly Vector3I19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, x); }
        public readonly Vector3I19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, y); }
        public readonly Vector3I19F13 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, z); }
        public readonly Vector3I19F13 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, x); }
        public readonly Vector3I19F13 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, y); }
        public readonly Vector3I19F13 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, z, z); }
        public readonly Vector3I19F13 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, x); }
        public readonly Vector3I19F13 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, y); }
        public readonly Vector3I19F13 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, x, z); }
        public readonly Vector3I19F13 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, x); }
        public readonly Vector3I19F13 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, y); }
        public readonly Vector3I19F13 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, y, z); }
        public readonly Vector3I19F13 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, x); }
        public readonly Vector3I19F13 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, y); }
        public readonly Vector3I19F13 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(z, z, z); }
        public readonly Vector4I19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, x); }
        public readonly Vector4I19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, y); }
        public readonly Vector4I19F13 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, z); }
        public readonly Vector4I19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, x); }
        public readonly Vector4I19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, y); }
        public readonly Vector4I19F13 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, z); }
        public readonly Vector4I19F13 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, x); }
        public readonly Vector4I19F13 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, y); }
        public readonly Vector4I19F13 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, z, z); }
        public readonly Vector4I19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, x); }
        public readonly Vector4I19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, y); }
        public readonly Vector4I19F13 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, z); }
        public readonly Vector4I19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, x); }
        public readonly Vector4I19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, y); }
        public readonly Vector4I19F13 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, z); }
        public readonly Vector4I19F13 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, x); }
        public readonly Vector4I19F13 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, y); }
        public readonly Vector4I19F13 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, z, z); }
        public readonly Vector4I19F13 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, x); }
        public readonly Vector4I19F13 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, y); }
        public readonly Vector4I19F13 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, x, z); }
        public readonly Vector4I19F13 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, x); }
        public readonly Vector4I19F13 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, y); }
        public readonly Vector4I19F13 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, y, z); }
        public readonly Vector4I19F13 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, x); }
        public readonly Vector4I19F13 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, y); }
        public readonly Vector4I19F13 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, z, z, z); }
        public readonly Vector4I19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, x); }
        public readonly Vector4I19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, y); }
        public readonly Vector4I19F13 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, z); }
        public readonly Vector4I19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, x); }
        public readonly Vector4I19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, y); }
        public readonly Vector4I19F13 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, z); }
        public readonly Vector4I19F13 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, x); }
        public readonly Vector4I19F13 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, y); }
        public readonly Vector4I19F13 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, z, z); }
        public readonly Vector4I19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, x); }
        public readonly Vector4I19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, y); }
        public readonly Vector4I19F13 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, z); }
        public readonly Vector4I19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, x); }
        public readonly Vector4I19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, y); }
        public readonly Vector4I19F13 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, z); }
        public readonly Vector4I19F13 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, x); }
        public readonly Vector4I19F13 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, y); }
        public readonly Vector4I19F13 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, z, z); }
        public readonly Vector4I19F13 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, x); }
        public readonly Vector4I19F13 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, y); }
        public readonly Vector4I19F13 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, x, z); }
        public readonly Vector4I19F13 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, x); }
        public readonly Vector4I19F13 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, y); }
        public readonly Vector4I19F13 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, y, z); }
        public readonly Vector4I19F13 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, x); }
        public readonly Vector4I19F13 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, y); }
        public readonly Vector4I19F13 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, z, z, z); }
        public readonly Vector4I19F13 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, x); }
        public readonly Vector4I19F13 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, y); }
        public readonly Vector4I19F13 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, x, z); }
        public readonly Vector4I19F13 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, x); }
        public readonly Vector4I19F13 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, y); }
        public readonly Vector4I19F13 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, y, z); }
        public readonly Vector4I19F13 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, x); }
        public readonly Vector4I19F13 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, y); }
        public readonly Vector4I19F13 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, x, z, z); }
        public readonly Vector4I19F13 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, x); }
        public readonly Vector4I19F13 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, y); }
        public readonly Vector4I19F13 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, x, z); }
        public readonly Vector4I19F13 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, x); }
        public readonly Vector4I19F13 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, y); }
        public readonly Vector4I19F13 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, y, z); }
        public readonly Vector4I19F13 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, x); }
        public readonly Vector4I19F13 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, y); }
        public readonly Vector4I19F13 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, y, z, z); }
        public readonly Vector4I19F13 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, x); }
        public readonly Vector4I19F13 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, y); }
        public readonly Vector4I19F13 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, x, z); }
        public readonly Vector4I19F13 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, x); }
        public readonly Vector4I19F13 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, y); }
        public readonly Vector4I19F13 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, y, z); }
        public readonly Vector4I19F13 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, x); }
        public readonly Vector4I19F13 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, y); }
        public readonly Vector4I19F13 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I19F13 lhs, Vector3I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I19F13 lhs, Vector3I19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I19F13({x}, {y}, {z})";

        // IEquatable<Vector3I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I19F13 other)
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
            return $"Vector3I19F13({x}, {y}, {z})";
        }
    }
}
