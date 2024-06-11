#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct uint2 : IEquatable<uint2>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public uint x;
        public uint y;

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        // Constants
        // ---------------------------------------

        public static readonly uint2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint x, uint y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator +(uint2 a, uint2 b) => new uint2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator -(uint2 a, uint2 b) => new uint2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator *(uint2 a, uint2 b) => new uint2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator *(uint2 a, uint b) => new uint2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator *(uint a, uint2 b) => new uint2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator /(uint2 a, uint2 b) => new uint2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator /(uint2 a, uint b) => new uint2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator /(uint a, uint2 b) => new uint2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly uint2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(x, x); }
        public readonly uint2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(x, y); }
        public readonly uint2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(y, x); }
        public readonly uint2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint2(y, y); }
        public readonly uint3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, x, x); }
        public readonly uint3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, x, y); }
        public readonly uint3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, y, x); }
        public readonly uint3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(x, y, y); }
        public readonly uint3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, x, x); }
        public readonly uint3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, x, y); }
        public readonly uint3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, y, x); }
        public readonly uint3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint3(y, y, y); }
        public readonly uint4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, x, x); }
        public readonly uint4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, x, y); }
        public readonly uint4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, y, x); }
        public readonly uint4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, x, y, y); }
        public readonly uint4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, x, x); }
        public readonly uint4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, x, y); }
        public readonly uint4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, y, x); }
        public readonly uint4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(x, y, y, y); }
        public readonly uint4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, x, x); }
        public readonly uint4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, x, y); }
        public readonly uint4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, y, x); }
        public readonly uint4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, x, y, y); }
        public readonly uint4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, x, x); }
        public readonly uint4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, x, y); }
        public readonly uint4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, y, x); }
        public readonly uint4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new uint4(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(uint2 lhs, uint2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(uint2 lhs, uint2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is uint2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"uint2({x}, {y})";

        // IEquatable<uint2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(uint2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"uint2({x}, {y})";
        }
    }
}

#endif
