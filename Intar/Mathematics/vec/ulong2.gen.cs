using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct ulong2 : IEquatable<ulong2>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public ulong x;
        public ulong y;

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        // Constants
        // ---------------------------------------

        public static readonly ulong2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong x, ulong y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator +(ulong2 a, ulong2 b) => new ulong2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator -(ulong2 a, ulong2 b) => new ulong2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator *(ulong2 a, ulong2 b) => new ulong2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator *(ulong2 a, ulong b) => new ulong2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator *(ulong a, ulong2 b) => new ulong2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator /(ulong2 a, ulong2 b) => new ulong2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator /(ulong2 a, ulong b) => new ulong2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator /(ulong a, ulong2 b) => new ulong2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly ulong2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, x); }
        public readonly ulong2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(x, y); }
        public readonly ulong2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, x); }
        public readonly ulong2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong2(y, y); }
        public readonly ulong3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, x); }
        public readonly ulong3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, x, y); }
        public readonly ulong3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, x); }
        public readonly ulong3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(x, y, y); }
        public readonly ulong3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, x); }
        public readonly ulong3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, x, y); }
        public readonly ulong3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, x); }
        public readonly ulong3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong3(y, y, y); }
        public readonly ulong4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, x); }
        public readonly ulong4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, x, y); }
        public readonly ulong4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, x); }
        public readonly ulong4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, x, y, y); }
        public readonly ulong4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, x); }
        public readonly ulong4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, x, y); }
        public readonly ulong4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, x); }
        public readonly ulong4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(x, y, y, y); }
        public readonly ulong4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, x); }
        public readonly ulong4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, x, y); }
        public readonly ulong4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, x); }
        public readonly ulong4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, x, y, y); }
        public readonly ulong4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, x); }
        public readonly ulong4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, x, y); }
        public readonly ulong4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, x); }
        public readonly ulong4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new ulong4(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ulong2 lhs, ulong2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ulong2 lhs, ulong2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is ulong2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"ulong2({x}, {y})";

        // IEquatable<ulong2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(ulong2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"ulong2({x}, {y})";
        }
    }
}
