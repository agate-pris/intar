#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct int2 : IEquatable<int2>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public int x;
        public int y;

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        // Constants
        // ---------------------------------------

        public static readonly int2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator +(int2 a, int2 b) => new int2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int2 a, int2 b) => new int2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int2 a, int2 b) => new int2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int2 a, int b) => new int2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int a, int2 b) => new int2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int2 a, int2 b) => new int2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int2 a, int b) => new int2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int a, int2 b) => new int2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly int2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, x); }
        public readonly int2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(x, y); }
        public readonly int2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, x); }
        public readonly int2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int2(y, y); }
        public readonly int3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, x); }
        public readonly int3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, x, y); }
        public readonly int3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, x); }
        public readonly int3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(x, y, y); }
        public readonly int3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, x); }
        public readonly int3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, x, y); }
        public readonly int3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, x); }
        public readonly int3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int3(y, y, y); }
        public readonly int4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, x); }
        public readonly int4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, x, y); }
        public readonly int4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, x); }
        public readonly int4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, x, y, y); }
        public readonly int4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, x); }
        public readonly int4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, x, y); }
        public readonly int4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, x); }
        public readonly int4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(x, y, y, y); }
        public readonly int4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, x); }
        public readonly int4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, x, y); }
        public readonly int4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, x); }
        public readonly int4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, x, y, y); }
        public readonly int4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, x); }
        public readonly int4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, x, y); }
        public readonly int4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, x); }
        public readonly int4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new int4(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(int2 lhs, int2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(int2 lhs, int2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is int2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"int2({x}, {y})";

        // IEquatable<int2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(int2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"int2({x}, {y})";
        }
    }
}

#endif
