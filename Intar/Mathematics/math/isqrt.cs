using System.Runtime.CompilerServices;
using AgatePris.Intar.Integer;

namespace AgatePris.Intar.Mathematics {

#pragma warning disable IDE1006 // 命名スタイル

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。

    public static partial class math {

#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint isqrt(uint x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(int) * 4;
            var k = halfBits - ((x - 1).LeadingZeroCount() >> 1);
            var s = 1U << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong isqrt(ulong x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(long) * 4;
            var k = halfBits - ((x - 1).LeadingZeroCount() >> 1);
            var s = 1UL << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }
    }

#pragma warning restore IDE1006 // 命名スタイル

}
