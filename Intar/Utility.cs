using System;
using System.Collections.Generic;

namespace Intar {
    /// <summary>
    /// 主に実装用のユーティリティクラス
    /// </summary>
    static class Utility {
        internal static void InsertionSort<T>(IList<T> list, Comparison<T> comparison) {
            var count = list.Count;
            for (var i = 1; i < count; i++) {
                var key = list[i];
                var j = i - 1;
                while (0 <= j && 0 < comparison(list[j], key)) {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }

        // https://en.wikipedia.org/wiki/Modulo
        // https://en.wikipedia.org/wiki/Rounding
        // https://en.wikipedia.org/wiki/Remainder
        // https://en.wikipedia.org/wiki/Division_(mathematics)

        internal static int TruncatedRem(int a, int n) {
            return a % n;
        }
        internal static int FlooredRem(int a, int n) {
            var r = a % n;
            if ((r != 0) && ((n < 0) != (r < 0))) {
                r += n;
            }
            return r;
        }
        internal static int EuclideanRem(int a, int n) {
            var r = a % n;
            if (r < 0) {
                r += (n < 0) ? -n : n;
            }
            return r;
        }
        internal static I17F15 TruncatedRem(I17F15 a, I17F15 n) {
            return I17F15.FromBits(TruncatedRem(a.Bits, n.Bits));
        }
        internal static I17F15 FlooredRem(I17F15 a, I17F15 n) {
            return I17F15.FromBits(FlooredRem(a.Bits, n.Bits));
        }
        internal static I17F15 EuclideanRem(I17F15 a, I17F15 n) {
            return I17F15.FromBits(EuclideanRem(a.Bits, n.Bits));
        }
    }
}
