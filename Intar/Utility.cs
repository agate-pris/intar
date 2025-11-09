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
    }
}
