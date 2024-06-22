using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I25F7 : IEquatable<Vector3I25F7>, IFormattable {
        // Fields
        // ---------------------------------------

        public I25F7 x;
        public I25F7 y;
        public I25F7 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I25F7 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(I25F7 x, I25F7 y, I25F7 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(I25F7 x, Vector2I25F7 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(Vector3I25F7 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I25F7(Vector2I25F7 xy, I25F7 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator +(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator -(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(Vector3I25F7 a, I25F7 b) => new Vector3I25F7(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator *(I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(Vector3I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(Vector3I25F7 a, I25F7 b) => new Vector3I25F7(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 operator /(I25F7 a, Vector3I25F7 b) => new Vector3I25F7(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(x, x); }
        public readonly Vector2I25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(x, y); }
        public readonly Vector2I25F7 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(x, z); }
        public readonly Vector2I25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(y, x); }
        public readonly Vector2I25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(y, y); }
        public readonly Vector2I25F7 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(y, z); }
        public readonly Vector2I25F7 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(z, x); }
        public readonly Vector2I25F7 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(z, y); }
        public readonly Vector2I25F7 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(z, z); }
        public readonly Vector3I25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, x, x); }
        public readonly Vector3I25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, x, y); }
        public readonly Vector3I25F7 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, x, z); }
        public readonly Vector3I25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, y, x); }
        public readonly Vector3I25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, y, y); }
        public readonly Vector3I25F7 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, y, z); }
        public readonly Vector3I25F7 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, z, x); }
        public readonly Vector3I25F7 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, z, y); }
        public readonly Vector3I25F7 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(x, z, z); }
        public readonly Vector3I25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, x, x); }
        public readonly Vector3I25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, x, y); }
        public readonly Vector3I25F7 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, x, z); }
        public readonly Vector3I25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, y, x); }
        public readonly Vector3I25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, y, y); }
        public readonly Vector3I25F7 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, y, z); }
        public readonly Vector3I25F7 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, z, x); }
        public readonly Vector3I25F7 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, z, y); }
        public readonly Vector3I25F7 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(y, z, z); }
        public readonly Vector3I25F7 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, x, x); }
        public readonly Vector3I25F7 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, x, y); }
        public readonly Vector3I25F7 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, x, z); }
        public readonly Vector3I25F7 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, y, x); }
        public readonly Vector3I25F7 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, y, y); }
        public readonly Vector3I25F7 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, y, z); }
        public readonly Vector3I25F7 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, z, x); }
        public readonly Vector3I25F7 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, z, y); }
        public readonly Vector3I25F7 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(z, z, z); }
        public readonly Vector4I25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, x, x); }
        public readonly Vector4I25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, x, y); }
        public readonly Vector4I25F7 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, x, z); }
        public readonly Vector4I25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, y, x); }
        public readonly Vector4I25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, y, y); }
        public readonly Vector4I25F7 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, y, z); }
        public readonly Vector4I25F7 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, z, x); }
        public readonly Vector4I25F7 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, z, y); }
        public readonly Vector4I25F7 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, x, z, z); }
        public readonly Vector4I25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, x, x); }
        public readonly Vector4I25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, x, y); }
        public readonly Vector4I25F7 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, x, z); }
        public readonly Vector4I25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, y, x); }
        public readonly Vector4I25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, y, y); }
        public readonly Vector4I25F7 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, y, z); }
        public readonly Vector4I25F7 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, z, x); }
        public readonly Vector4I25F7 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, z, y); }
        public readonly Vector4I25F7 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, y, z, z); }
        public readonly Vector4I25F7 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, x, x); }
        public readonly Vector4I25F7 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, x, y); }
        public readonly Vector4I25F7 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, x, z); }
        public readonly Vector4I25F7 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, y, x); }
        public readonly Vector4I25F7 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, y, y); }
        public readonly Vector4I25F7 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, y, z); }
        public readonly Vector4I25F7 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, z, x); }
        public readonly Vector4I25F7 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, z, y); }
        public readonly Vector4I25F7 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(x, z, z, z); }
        public readonly Vector4I25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, x, x); }
        public readonly Vector4I25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, x, y); }
        public readonly Vector4I25F7 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, x, z); }
        public readonly Vector4I25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, y, x); }
        public readonly Vector4I25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, y, y); }
        public readonly Vector4I25F7 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, y, z); }
        public readonly Vector4I25F7 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, z, x); }
        public readonly Vector4I25F7 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, z, y); }
        public readonly Vector4I25F7 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, x, z, z); }
        public readonly Vector4I25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, x, x); }
        public readonly Vector4I25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, x, y); }
        public readonly Vector4I25F7 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, x, z); }
        public readonly Vector4I25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, y, x); }
        public readonly Vector4I25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, y, y); }
        public readonly Vector4I25F7 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, y, z); }
        public readonly Vector4I25F7 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, z, x); }
        public readonly Vector4I25F7 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, z, y); }
        public readonly Vector4I25F7 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, y, z, z); }
        public readonly Vector4I25F7 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, x, x); }
        public readonly Vector4I25F7 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, x, y); }
        public readonly Vector4I25F7 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, x, z); }
        public readonly Vector4I25F7 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, y, x); }
        public readonly Vector4I25F7 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, y, y); }
        public readonly Vector4I25F7 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, y, z); }
        public readonly Vector4I25F7 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, z, x); }
        public readonly Vector4I25F7 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, z, y); }
        public readonly Vector4I25F7 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(y, z, z, z); }
        public readonly Vector4I25F7 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, x, x); }
        public readonly Vector4I25F7 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, x, y); }
        public readonly Vector4I25F7 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, x, z); }
        public readonly Vector4I25F7 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, y, x); }
        public readonly Vector4I25F7 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, y, y); }
        public readonly Vector4I25F7 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, y, z); }
        public readonly Vector4I25F7 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, z, x); }
        public readonly Vector4I25F7 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, z, y); }
        public readonly Vector4I25F7 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, x, z, z); }
        public readonly Vector4I25F7 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, x, x); }
        public readonly Vector4I25F7 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, x, y); }
        public readonly Vector4I25F7 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, x, z); }
        public readonly Vector4I25F7 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, y, x); }
        public readonly Vector4I25F7 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, y, y); }
        public readonly Vector4I25F7 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, y, z); }
        public readonly Vector4I25F7 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, z, x); }
        public readonly Vector4I25F7 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, z, y); }
        public readonly Vector4I25F7 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, y, z, z); }
        public readonly Vector4I25F7 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, x, x); }
        public readonly Vector4I25F7 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, x, y); }
        public readonly Vector4I25F7 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, x, z); }
        public readonly Vector4I25F7 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, y, x); }
        public readonly Vector4I25F7 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, y, y); }
        public readonly Vector4I25F7 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, y, z); }
        public readonly Vector4I25F7 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, z, x); }
        public readonly Vector4I25F7 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, z, y); }
        public readonly Vector4I25F7 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I25F7 lhs, Vector3I25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I25F7 lhs, Vector3I25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I25F7({x}, {y}, {z})";

        // IEquatable<Vector3I25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I25F7 other)
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
            return $"Vector3I25F7({x}, {y}, {z})";
        }
    }
}
