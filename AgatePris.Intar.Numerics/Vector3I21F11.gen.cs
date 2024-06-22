using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector3I21F11 : IEquatable<Vector3I21F11>, IFormattable {
        // Fields
        // ---------------------------------------

        public I21F11 x;
        public I21F11 y;
        public I21F11 z;

        // Constants
        // ---------------------------------------

        public static readonly Vector3I21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I21F11(I21F11 x, I21F11 y, I21F11 z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I21F11(I21F11 x, Vector2I21F11 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I21F11(Vector3I21F11 xyz) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I21F11(Vector2I21F11 xy, I21F11 z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator +(Vector3I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a.x + b.x,
            a.y + b.y,
            a.z + b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator -(Vector3I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a.x - b.x,
            a.y - b.y,
            a.z - b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator *(Vector3I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a.x * b.x,
            a.y * b.y,
            a.z * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator *(Vector3I21F11 a, I21F11 b) => new Vector3I21F11(
            a.x * b,
            a.y * b,
            a.z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator *(I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a * b.x,
            a * b.y,
            a * b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator /(Vector3I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a.x / b.x,
            a.y / b.y,
            a.z / b.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator /(Vector3I21F11 a, I21F11 b) => new Vector3I21F11(
            a.x / b,
            a.y / b,
            a.z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 operator /(I21F11 a, Vector3I21F11 b) => new Vector3I21F11(
            a / b.x,
            a / b.y,
            a / b.z);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, x); }
        public readonly Vector2I21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, y); }
        public readonly Vector2I21F11 xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(x, z); }
        public readonly Vector2I21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, x); }
        public readonly Vector2I21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, y); }
        public readonly Vector2I21F11 yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(y, z); }
        public readonly Vector2I21F11 zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, x); }
        public readonly Vector2I21F11 zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, y); }
        public readonly Vector2I21F11 zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(z, z); }
        public readonly Vector3I21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, x); }
        public readonly Vector3I21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, y); }
        public readonly Vector3I21F11 xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, x, z); }
        public readonly Vector3I21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, x); }
        public readonly Vector3I21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, y); }
        public readonly Vector3I21F11 xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, y, z); }
        public readonly Vector3I21F11 xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, x); }
        public readonly Vector3I21F11 xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, y); }
        public readonly Vector3I21F11 xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(x, z, z); }
        public readonly Vector3I21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, x); }
        public readonly Vector3I21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, y); }
        public readonly Vector3I21F11 yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, x, z); }
        public readonly Vector3I21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, x); }
        public readonly Vector3I21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, y); }
        public readonly Vector3I21F11 yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, y, z); }
        public readonly Vector3I21F11 yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, x); }
        public readonly Vector3I21F11 yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, y); }
        public readonly Vector3I21F11 yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(y, z, z); }
        public readonly Vector3I21F11 zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, x); }
        public readonly Vector3I21F11 zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, y); }
        public readonly Vector3I21F11 zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, x, z); }
        public readonly Vector3I21F11 zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, x); }
        public readonly Vector3I21F11 zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, y); }
        public readonly Vector3I21F11 zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, y, z); }
        public readonly Vector3I21F11 zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, x); }
        public readonly Vector3I21F11 zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, y); }
        public readonly Vector3I21F11 zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(z, z, z); }
        public readonly Vector4I21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, x); }
        public readonly Vector4I21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, y); }
        public readonly Vector4I21F11 xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, x, z); }
        public readonly Vector4I21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, x); }
        public readonly Vector4I21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, y); }
        public readonly Vector4I21F11 xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, y, z); }
        public readonly Vector4I21F11 xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, x); }
        public readonly Vector4I21F11 xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, y); }
        public readonly Vector4I21F11 xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, x, z, z); }
        public readonly Vector4I21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, x); }
        public readonly Vector4I21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, y); }
        public readonly Vector4I21F11 xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, x, z); }
        public readonly Vector4I21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, x); }
        public readonly Vector4I21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, y); }
        public readonly Vector4I21F11 xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, y, z); }
        public readonly Vector4I21F11 xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, x); }
        public readonly Vector4I21F11 xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, y); }
        public readonly Vector4I21F11 xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, y, z, z); }
        public readonly Vector4I21F11 xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, x); }
        public readonly Vector4I21F11 xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, y); }
        public readonly Vector4I21F11 xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, x, z); }
        public readonly Vector4I21F11 xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, x); }
        public readonly Vector4I21F11 xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, y); }
        public readonly Vector4I21F11 xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, y, z); }
        public readonly Vector4I21F11 xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, x); }
        public readonly Vector4I21F11 xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, y); }
        public readonly Vector4I21F11 xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(x, z, z, z); }
        public readonly Vector4I21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, x); }
        public readonly Vector4I21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, y); }
        public readonly Vector4I21F11 yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, x, z); }
        public readonly Vector4I21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, x); }
        public readonly Vector4I21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, y); }
        public readonly Vector4I21F11 yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, y, z); }
        public readonly Vector4I21F11 yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, x); }
        public readonly Vector4I21F11 yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, y); }
        public readonly Vector4I21F11 yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, x, z, z); }
        public readonly Vector4I21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, x); }
        public readonly Vector4I21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, y); }
        public readonly Vector4I21F11 yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, x, z); }
        public readonly Vector4I21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, x); }
        public readonly Vector4I21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, y); }
        public readonly Vector4I21F11 yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, y, z); }
        public readonly Vector4I21F11 yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, x); }
        public readonly Vector4I21F11 yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, y); }
        public readonly Vector4I21F11 yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, y, z, z); }
        public readonly Vector4I21F11 yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, x); }
        public readonly Vector4I21F11 yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, y); }
        public readonly Vector4I21F11 yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, x, z); }
        public readonly Vector4I21F11 yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, x); }
        public readonly Vector4I21F11 yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, y); }
        public readonly Vector4I21F11 yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, y, z); }
        public readonly Vector4I21F11 yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, x); }
        public readonly Vector4I21F11 yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, y); }
        public readonly Vector4I21F11 yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(y, z, z, z); }
        public readonly Vector4I21F11 zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, x); }
        public readonly Vector4I21F11 zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, y); }
        public readonly Vector4I21F11 zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, x, z); }
        public readonly Vector4I21F11 zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, x); }
        public readonly Vector4I21F11 zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, y); }
        public readonly Vector4I21F11 zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, y, z); }
        public readonly Vector4I21F11 zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, x); }
        public readonly Vector4I21F11 zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, y); }
        public readonly Vector4I21F11 zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, x, z, z); }
        public readonly Vector4I21F11 zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, x); }
        public readonly Vector4I21F11 zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, y); }
        public readonly Vector4I21F11 zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, x, z); }
        public readonly Vector4I21F11 zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, x); }
        public readonly Vector4I21F11 zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, y); }
        public readonly Vector4I21F11 zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, y, z); }
        public readonly Vector4I21F11 zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, x); }
        public readonly Vector4I21F11 zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, y); }
        public readonly Vector4I21F11 zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, y, z, z); }
        public readonly Vector4I21F11 zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, x); }
        public readonly Vector4I21F11 zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, y); }
        public readonly Vector4I21F11 zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, x, z); }
        public readonly Vector4I21F11 zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, x); }
        public readonly Vector4I21F11 zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, y); }
        public readonly Vector4I21F11 zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, y, z); }
        public readonly Vector4I21F11 zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, x); }
        public readonly Vector4I21F11 zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, y); }
        public readonly Vector4I21F11 zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(z, z, z, z); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I21F11 lhs, Vector3I21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I21F11 lhs, Vector3I21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector3I21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector3I21F11({x}, {y}, {z})";

        // IEquatable<Vector3I21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector3I21F11 other)
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
            return $"Vector3I21F11({x}, {y}, {z})";
        }
    }
}
