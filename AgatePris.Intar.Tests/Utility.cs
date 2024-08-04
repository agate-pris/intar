using System.Collections.Generic;
using System.IO;

#if !UNITY_5_6_OR_NEWER
using System;
#endif

namespace AgatePris.Intar.Tests {
    public class Utility {
        internal static string MakeUpPath(string path) {
#if UNITY_5_6_OR_NEWER
            return Path.GetFullPath(
                Path.Combine(
                    "Packages/dev.agate-pris.intar/.data",
                    path
                )
            );
#else
            return Path.Combine(
                Environment.GetEnvironmentVariable("Data"),
                path
            );
#endif
        }

        internal static List<int> ReadInts(string path) {
            var ints = new List<int>();
            foreach (var line in File.ReadLines(path)) {
                foreach (var s in line.Split(',')) {
                    if (int.TryParse(s, out var v)) {
                        ints.Add(v);
                    }
                }
            }
            return ints;
        }
    }
}
