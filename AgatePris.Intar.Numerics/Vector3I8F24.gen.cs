using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I8F24 : IEquatable<Vector3I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

        public I8F24 x;
        public I8F24 y;
        public I8F24 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I8F24 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, I8F24 y, I8F24 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(I8F24 x, Vector2I8F24 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector3I8F24 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F24(Vector2I8F24 xy, I8F24 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator +(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator -(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator *(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(Vector3I8F24 a, I8F24 b) => new Vector3I8F24(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 operator /(I8F24 a, Vector3I8F24 b) => new Vector3I8F24(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I8F24 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, x); }
        public readonly Vector2I8F24 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, y); }
        public readonly Vector2I8F24 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, z); }
        public readonly Vector2I8F24 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, x); }
        public readonly Vector2I8F24 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, y); }
        public readonly Vector2I8F24 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, z); }
        public readonly Vector2I8F24 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, x); }
        public readonly Vector2I8F24 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, y); }
        public readonly Vector2I8F24 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(z, z); }
        public readonly Vector3I8F24 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, x); }
        public readonly Vector3I8F24 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, y); }
        public readonly Vector3I8F24 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, z); }
        public readonly Vector3I8F24 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, x); }
        public readonly Vector3I8F24 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, y); }
        public readonly Vector3I8F24 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, z); }
        public readonly Vector3I8F24 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, x); }
        public readonly Vector3I8F24 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, y); }
        public readonly Vector3I8F24 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, z, z); }
        public readonly Vector3I8F24 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, x); }
        public readonly Vector3I8F24 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, y); }
        public readonly Vector3I8F24 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, z); }
        public readonly Vector3I8F24 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, x); }
        public readonly Vector3I8F24 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, y); }
        public readonly Vector3I8F24 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, z); }
        public readonly Vector3I8F24 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, x); }
        public readonly Vector3I8F24 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, y); }
        public readonly Vector3I8F24 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, z, z); }
        public readonly Vector3I8F24 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, x); }
        public readonly Vector3I8F24 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, y); }
        public readonly Vector3I8F24 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, x, z); }
        public readonly Vector3I8F24 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, x); }
        public readonly Vector3I8F24 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, y); }
        public readonly Vector3I8F24 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, y, z); }
        public readonly Vector3I8F24 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, x); }
        public readonly Vector3I8F24 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, y); }
        public readonly Vector3I8F24 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(z, z, z); }
        public readonly Vector4I8F24 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, x); }
        public readonly Vector4I8F24 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, y); }
        public readonly Vector4I8F24 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, z); }
        public readonly Vector4I8F24 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, x); }
        public readonly Vector4I8F24 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, y); }
        public readonly Vector4I8F24 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, z); }
        public readonly Vector4I8F24 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, x); }
        public readonly Vector4I8F24 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, y); }
        public readonly Vector4I8F24 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, z, z); }
        public readonly Vector4I8F24 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, x); }
        public readonly Vector4I8F24 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, y); }
        public readonly Vector4I8F24 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, z); }
        public readonly Vector4I8F24 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, x); }
        public readonly Vector4I8F24 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, y); }
        public readonly Vector4I8F24 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, z); }
        public readonly Vector4I8F24 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, x); }
        public readonly Vector4I8F24 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, y); }
        public readonly Vector4I8F24 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, z, z); }
        public readonly Vector4I8F24 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, x); }
        public readonly Vector4I8F24 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, y); }
        public readonly Vector4I8F24 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, x, z); }
        public readonly Vector4I8F24 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, x); }
        public readonly Vector4I8F24 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, y); }
        public readonly Vector4I8F24 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, y, z); }
        public readonly Vector4I8F24 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, x); }
        public readonly Vector4I8F24 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, y); }
        public readonly Vector4I8F24 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, z, z, z); }
        public readonly Vector4I8F24 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, x); }
        public readonly Vector4I8F24 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, y); }
        public readonly Vector4I8F24 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, z); }
        public readonly Vector4I8F24 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, x); }
        public readonly Vector4I8F24 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, y); }
        public readonly Vector4I8F24 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, z); }
        public readonly Vector4I8F24 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, x); }
        public readonly Vector4I8F24 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, y); }
        public readonly Vector4I8F24 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, z, z); }
        public readonly Vector4I8F24 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, x); }
        public readonly Vector4I8F24 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, y); }
        public readonly Vector4I8F24 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, z); }
        public readonly Vector4I8F24 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, x); }
        public readonly Vector4I8F24 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, y); }
        public readonly Vector4I8F24 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, z); }
        public readonly Vector4I8F24 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, x); }
        public readonly Vector4I8F24 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, y); }
        public readonly Vector4I8F24 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, z, z); }
        public readonly Vector4I8F24 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, x); }
        public readonly Vector4I8F24 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, y); }
        public readonly Vector4I8F24 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, x, z); }
        public readonly Vector4I8F24 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, x); }
        public readonly Vector4I8F24 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, y); }
        public readonly Vector4I8F24 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, y, z); }
        public readonly Vector4I8F24 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, x); }
        public readonly Vector4I8F24 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, y); }
        public readonly Vector4I8F24 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, z, z, z); }
        public readonly Vector4I8F24 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, x); }
        public readonly Vector4I8F24 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, y); }
        public readonly Vector4I8F24 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, x, z); }
        public readonly Vector4I8F24 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, x); }
        public readonly Vector4I8F24 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, y); }
        public readonly Vector4I8F24 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, y, z); }
        public readonly Vector4I8F24 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, x); }
        public readonly Vector4I8F24 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, y); }
        public readonly Vector4I8F24 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, x, z, z); }
        public readonly Vector4I8F24 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, x); }
        public readonly Vector4I8F24 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, y); }
        public readonly Vector4I8F24 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, x, z); }
        public readonly Vector4I8F24 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, x); }
        public readonly Vector4I8F24 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, y); }
        public readonly Vector4I8F24 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, y, z); }
        public readonly Vector4I8F24 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, x); }
        public readonly Vector4I8F24 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, y); }
        public readonly Vector4I8F24 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, y, z, z); }
        public readonly Vector4I8F24 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, x); }
        public readonly Vector4I8F24 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, y); }
        public readonly Vector4I8F24 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, x, z); }
        public readonly Vector4I8F24 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, x); }
        public readonly Vector4I8F24 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, y); }
        public readonly Vector4I8F24 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, y, z); }
        public readonly Vector4I8F24 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, x); }
        public readonly Vector4I8F24 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, y); }
        public readonly Vector4I8F24 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I8F24 lhs, Vector3I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I8F24 lhs, Vector3I8F24 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I8F24({x}, {y}, {z})";

        // IEquatable<Vector3I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I8F24 other)
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
            return $"Vector3I8F24({x}, {y}, {z})";
        }
    }
}
