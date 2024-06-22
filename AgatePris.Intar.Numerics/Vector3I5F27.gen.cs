using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I5F27 : IEquatable<Vector3I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

        public I5F27 x;
        public I5F27 y;
        public I5F27 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, I5F27 y, I5F27 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(I5F27 x, Vector2I5F27 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector3I5F27 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I5F27(Vector2I5F27 xy, I5F27 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator +(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator -(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator *(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(Vector3I5F27 a, I5F27 b) => new Vector3I5F27(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 operator /(I5F27 a, Vector3I5F27 b) => new Vector3I5F27(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(x, x); }
        public readonly Vector2I5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(x, y); }
        public readonly Vector2I5F27 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(x, z); }
        public readonly Vector2I5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(y, x); }
        public readonly Vector2I5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(y, y); }
        public readonly Vector2I5F27 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(y, z); }
        public readonly Vector2I5F27 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(z, x); }
        public readonly Vector2I5F27 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(z, y); }
        public readonly Vector2I5F27 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(z, z); }
        public readonly Vector3I5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, x, x); }
        public readonly Vector3I5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, x, y); }
        public readonly Vector3I5F27 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, x, z); }
        public readonly Vector3I5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, y, x); }
        public readonly Vector3I5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, y, y); }
        public readonly Vector3I5F27 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, y, z); }
        public readonly Vector3I5F27 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, z, x); }
        public readonly Vector3I5F27 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, z, y); }
        public readonly Vector3I5F27 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, z, z); }
        public readonly Vector3I5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, x, x); }
        public readonly Vector3I5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, x, y); }
        public readonly Vector3I5F27 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, x, z); }
        public readonly Vector3I5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, y, x); }
        public readonly Vector3I5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, y, y); }
        public readonly Vector3I5F27 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, y, z); }
        public readonly Vector3I5F27 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, z, x); }
        public readonly Vector3I5F27 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, z, y); }
        public readonly Vector3I5F27 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, z, z); }
        public readonly Vector3I5F27 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, x, x); }
        public readonly Vector3I5F27 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, x, y); }
        public readonly Vector3I5F27 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, x, z); }
        public readonly Vector3I5F27 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, y, x); }
        public readonly Vector3I5F27 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, y, y); }
        public readonly Vector3I5F27 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, y, z); }
        public readonly Vector3I5F27 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, z, x); }
        public readonly Vector3I5F27 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, z, y); }
        public readonly Vector3I5F27 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(z, z, z); }
        public readonly Vector4I5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, x, x); }
        public readonly Vector4I5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, x, y); }
        public readonly Vector4I5F27 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, x, z); }
        public readonly Vector4I5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, y, x); }
        public readonly Vector4I5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, y, y); }
        public readonly Vector4I5F27 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, y, z); }
        public readonly Vector4I5F27 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, z, x); }
        public readonly Vector4I5F27 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, z, y); }
        public readonly Vector4I5F27 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, z, z); }
        public readonly Vector4I5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, x, x); }
        public readonly Vector4I5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, x, y); }
        public readonly Vector4I5F27 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, x, z); }
        public readonly Vector4I5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, y, x); }
        public readonly Vector4I5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, y, y); }
        public readonly Vector4I5F27 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, y, z); }
        public readonly Vector4I5F27 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, z, x); }
        public readonly Vector4I5F27 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, z, y); }
        public readonly Vector4I5F27 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, z, z); }
        public readonly Vector4I5F27 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, x, x); }
        public readonly Vector4I5F27 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, x, y); }
        public readonly Vector4I5F27 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, x, z); }
        public readonly Vector4I5F27 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, y, x); }
        public readonly Vector4I5F27 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, y, y); }
        public readonly Vector4I5F27 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, y, z); }
        public readonly Vector4I5F27 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, z, x); }
        public readonly Vector4I5F27 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, z, y); }
        public readonly Vector4I5F27 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, z, z, z); }
        public readonly Vector4I5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, x, x); }
        public readonly Vector4I5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, x, y); }
        public readonly Vector4I5F27 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, x, z); }
        public readonly Vector4I5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, y, x); }
        public readonly Vector4I5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, y, y); }
        public readonly Vector4I5F27 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, y, z); }
        public readonly Vector4I5F27 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, z, x); }
        public readonly Vector4I5F27 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, z, y); }
        public readonly Vector4I5F27 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, z, z); }
        public readonly Vector4I5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, x, x); }
        public readonly Vector4I5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, x, y); }
        public readonly Vector4I5F27 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, x, z); }
        public readonly Vector4I5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, y, x); }
        public readonly Vector4I5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, y, y); }
        public readonly Vector4I5F27 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, y, z); }
        public readonly Vector4I5F27 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, z, x); }
        public readonly Vector4I5F27 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, z, y); }
        public readonly Vector4I5F27 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, z, z); }
        public readonly Vector4I5F27 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, x, x); }
        public readonly Vector4I5F27 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, x, y); }
        public readonly Vector4I5F27 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, x, z); }
        public readonly Vector4I5F27 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, y, x); }
        public readonly Vector4I5F27 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, y, y); }
        public readonly Vector4I5F27 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, y, z); }
        public readonly Vector4I5F27 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, z, x); }
        public readonly Vector4I5F27 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, z, y); }
        public readonly Vector4I5F27 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, z, z, z); }
        public readonly Vector4I5F27 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, x, x); }
        public readonly Vector4I5F27 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, x, y); }
        public readonly Vector4I5F27 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, x, z); }
        public readonly Vector4I5F27 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, y, x); }
        public readonly Vector4I5F27 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, y, y); }
        public readonly Vector4I5F27 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, y, z); }
        public readonly Vector4I5F27 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, z, x); }
        public readonly Vector4I5F27 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, z, y); }
        public readonly Vector4I5F27 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, x, z, z); }
        public readonly Vector4I5F27 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, x, x); }
        public readonly Vector4I5F27 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, x, y); }
        public readonly Vector4I5F27 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, x, z); }
        public readonly Vector4I5F27 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, y, x); }
        public readonly Vector4I5F27 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, y, y); }
        public readonly Vector4I5F27 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, y, z); }
        public readonly Vector4I5F27 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, z, x); }
        public readonly Vector4I5F27 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, z, y); }
        public readonly Vector4I5F27 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, y, z, z); }
        public readonly Vector4I5F27 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, x, x); }
        public readonly Vector4I5F27 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, x, y); }
        public readonly Vector4I5F27 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, x, z); }
        public readonly Vector4I5F27 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, y, x); }
        public readonly Vector4I5F27 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, y, y); }
        public readonly Vector4I5F27 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, y, z); }
        public readonly Vector4I5F27 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, z, x); }
        public readonly Vector4I5F27 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, z, y); }
        public readonly Vector4I5F27 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I5F27 lhs, Vector3I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I5F27 lhs, Vector3I5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I5F27({x}, {y}, {z})";

        // IEquatable<Vector3I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I5F27 other)
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
            return $"Vector3I5F27({x}, {y}, {z})";
        }
    }
}
