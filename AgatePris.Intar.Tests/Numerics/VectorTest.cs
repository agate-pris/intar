using AgatePris.Intar.Numerics;
using AgatePris.Intar.Rand;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#if UNITY_5_6_OR_NEWER

using UnityEngine;

#else

using System.Text.Json.Serialization;

#endif

namespace AgatePris.Intar.Tests.Numerics {
    public class VectorTest {
        static bool IsInt(long x) => int.MinValue <= x && x <= int.MaxValue;
        static bool IsUInt(long x) => uint.MinValue <= x && x <= uint.MaxValue;
        static bool AllAreInt(long x, long y) => IsInt(x) && IsInt(y);
        static bool AllAreInt(long x, long y, long z) => AllAreInt(x, y) && IsInt(z);
        static bool AllAreInt(long x, long y, long z, long w) => AllAreInt(x, y, z) && IsInt(w);
        static bool AllAreUInt(long x, long y) => IsUInt(x) && IsUInt(y);
        static bool AllAreUInt(long x, long y, long z) => AllAreUInt(x, y) && IsUInt(z);
        static bool AllAreUInt(long x, long y, long z, long w) => AllAreUInt(x, y, z) && IsUInt(w);

        static int StrictToInt(long x) => checked((int)x);
        static uint StrictToUInt(long x) => checked((uint)x);
        static I17F15 StrictToI17F15(long x) => I17F15.FromBits(StrictToInt(x));
        static U17F15 StrictToU17F15(long x) => U17F15.FromBits(StrictToUInt(x));
        static Vector2I17F15 StrictToVector2I17F15(List<long> l) => new Vector2I17F15(
            StrictToI17F15(l[0]),
            StrictToI17F15(l[1]));
        static Vector3I17F15 StrictToVector3I17F15(List<long> l) => new Vector3I17F15(
            StrictToI17F15(l[0]),
            StrictToI17F15(l[1]),
            StrictToI17F15(l[2]));
        static Vector4I17F15 StrictToVector4I17F15(List<long> l) => new Vector4I17F15(
            StrictToI17F15(l[0]),
            StrictToI17F15(l[1]),
            StrictToI17F15(l[2]),
            StrictToI17F15(l[3]));
        static Vector2U17F15 StrictToVector2U17F15(List<long> l) => new Vector2U17F15(
            StrictToU17F15(l[0]),
            StrictToU17F15(l[1]));
        static Vector3U17F15 StrictToVector3U17F15(List<long> l) => new Vector3U17F15(
            StrictToU17F15(l[0]),
            StrictToU17F15(l[1]),
            StrictToU17F15(l[2]));
        static Vector4U17F15 StrictToVector4U17F15(List<long> l) => new Vector4U17F15(
            StrictToU17F15(l[0]),
            StrictToU17F15(l[1]),
            StrictToU17F15(l[2]),
            StrictToU17F15(l[3]));

        [Serializable]
        public struct UnaryCase {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

#if !UNITY_5_6_OR_NEWER
            [JsonInclude]
#endif
            public List<long> bits;

#if !UNITY_5_6_OR_NEWER
            [JsonInclude]
#endif
            public string lengthSquared;

#if !UNITY_5_6_OR_NEWER
            [JsonInclude]
#endif
            public uint length;

#if !UNITY_5_6_OR_NEWER
            [JsonInclude]
#endif
            public bool overflow;

#if !UNITY_5_6_OR_NEWER
            [JsonInclude]
#endif
            public List<long> normalized;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

            public bool AllBitsAreInt() => bits.All(IsInt);
            public bool AllBitsAreUInt() => bits.All(IsUInt);

            public UnaryCase(List<long> bits) {
                this.bits = new List<long>();
                foreach (var item in bits) {
                    this.bits.Add(item);
                }
                var signed = bits.All(IsInt);
                var unsigned = bits.All(IsUInt);

                IVector<U36F28, I36F28, U18F14, I18F14> vector;

                if (signed) {
                    switch (bits.Count) {
                        case 2: {
                            var v = StrictToVector2I17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        case 3: {
                            var v = StrictToVector3I17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits,
                                    normalized.Value.Z.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        case 4: {
                            var v = StrictToVector4I17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits,
                                    normalized.Value.Z.Bits,
                                    normalized.Value.W.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        default: {
                            throw new NotImplementedException();
                        }
                    }
                } else if (unsigned) {
                    switch (bits.Count) {
                        case 2: {
                            var v = StrictToVector2U17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        case 3: {
                            var v = StrictToVector3U17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits,
                                    normalized.Value.Z.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        case 4: {
                            var v = StrictToVector4U17F15(bits);
                            var normalized = v.Normalize();
                            this.normalized = normalized.HasValue
                                ? new List<long> {
                                    normalized.Value.X.Bits,
                                    normalized.Value.Y.Bits,
                                    normalized.Value.Z.Bits,
                                    normalized.Value.W.Bits
                                }
                                : new List<long>();
                            vector = v;
                            break;
                        }
                        default: {
                            throw new NotImplementedException();
                        }
                    }
                } else {
                    throw new NotImplementedException();
                }

                lengthSquared = $"{vector.LengthSquaredUnsigned().Bits}";
                length = vector.LengthUnsigned().Bits;
                try {
                    _ = vector.LengthSigned();
                    overflow = false;
                } catch (OverflowException) {
                    overflow = true;
                }
            }

            static void Test(List<long> expected, List<long> actual) {
                if (expected.Count != actual.Count) {
                    Assert.Fail();
                }
                for (var i = 0; i < actual.Count; ++i) {
                    if (expected[i] != actual[i]) {
                        Assert.Fail($"expected[i]: {expected[i]}, actual[i]: {actual[i]}");
                    }
                }
            }
            static void Test(List<float> expected, List<long> actual, double delta) {
                if (expected.Count != actual.Count) {
                    if (actual.Count != 0) {
                        Assert.Fail();
                    }
                    Assert.IsTrue(expected.All(float.IsNaN));
                } else {
                    for (var i = 0; i < actual.Count; ++i) {
                        const double k = 1.0 / (1 << 15);
                        Assert.AreEqual(expected[i], k * actual[i], delta);
                    }
                }
            }

            void Test<T>(
                T v, double lengthSquaredExpected, double lengthExpected
            ) where T : IVector<U36F28, I36F28, U18F14, I18F14> {
                const double deltaRate = 2e-7;
                const double minDelta = 7e-5;

                {
                    var lengthSquared = ulong.Parse(this.lengthSquared, null);
                    var actual = v.LengthSquaredUnsigned();
                    if (lengthSquared != actual.Bits) {
                        Assert.Fail();
                    }
                    Assert.AreEqual(
                        lengthSquaredExpected,
                        (double)v.LengthSquaredUnsigned(),
                        Math.Max(minDelta, deltaRate * lengthSquaredExpected));
                }

                {
                    var actual = v.LengthUnsigned();
                    if (length != actual.Bits) {
                        Assert.Fail();
                    }
                    Assert.AreEqual(
                        lengthExpected,
                        (double)actual,
                        Math.Max(minDelta, deltaRate * lengthExpected));
                }

                if (overflow) {
                    _ = Assert.Throws<OverflowException>(() => v.LengthSigned());
                } else {
                    _ = v.LengthSigned();
                }
            }

            public void Test() {
                var allBitsAreInt = AllBitsAreInt();
                var allBitsAreUInt = AllBitsAreUInt();
                if (!allBitsAreInt && !allBitsAreUInt) {
                    throw new NotImplementedException();
                }

                const float k = 1.0F / (1 << 15);
                double lengthSquaredExpected;
                double lengthExpected;
                List<float> normalizedExpected;
                switch (bits.Count) {
                    case 2: {
                        var v = new System.Numerics.Vector2(
                            k * bits[0],
                            k * bits[1]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        var n = System.Numerics.Vector2.Normalize(v);
                        normalizedExpected = new List<float> {
                            n.X,
                            n.Y };
                        break;
                    }
                    case 3: {
                        var v = new System.Numerics.Vector3(
                            k * bits[0],
                            k * bits[1],
                            k * bits[2]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        var n = System.Numerics.Vector3.Normalize(v);
                        normalizedExpected = new List<float> {
                            n.X,
                            n.Y,
                            n.Z };
                        break;
                    }
                    case 4: {
                        var v = new System.Numerics.Vector4(
                            k * bits[0],
                            k * bits[1],
                            k * bits[2],
                            k * bits[3]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        var n = System.Numerics.Vector4.Normalize(v);
                        normalizedExpected = new List<float> {
                            n.X,
                            n.Y,
                            n.Z,
                            n.W };
                        break;
                    }
                    default: throw new NotImplementedException();
                }

                if (allBitsAreInt) {
                    List<long> normalizedActual;
                    switch (bits.Count) {
                        case 2: {
                            var v = StrictToVector2I17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits }
                                : new List<long>();
                            break;
                        }
                        case 3: {
                            var v = StrictToVector3I17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits,
                                    n.Value.Z.Bits }
                                : new List<long>();
                            break;
                        }
                        case 4: {
                            var v = StrictToVector4I17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits,
                                    n.Value.Z.Bits,
                                    n.Value.W.Bits }
                                : new List<long>();
                            break;
                        }
                        default: throw new NotImplementedException();
                    }

                    Test(normalized, normalizedActual);
                    Test(normalizedExpected, normalizedActual, 4e-5);
                }
                if (allBitsAreUInt) {
                    List<long> normalizedActual;
                    switch (bits.Count) {
                        case 2: {
                            var v = StrictToVector2U17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits }
                                : new List<long>();
                            break;
                        }
                        case 3: {
                            var v = StrictToVector3U17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits,
                                    n.Value.Z.Bits }
                                : new List<long>();
                            break;
                        }
                        case 4: {
                            var v = StrictToVector4U17F15(bits);
                            Test(v, lengthSquaredExpected, lengthExpected);
                            var n = v.Normalize();
                            normalizedActual = n.HasValue
                                ? new List<long> {
                                    n.Value.X.Bits,
                                    n.Value.Y.Bits,
                                    n.Value.Z.Bits,
                                    n.Value.W.Bits }
                                : new List<long>();
                            break;
                        }
                        default: throw new NotImplementedException();
                    }

                    Test(normalized, normalizedActual);
                    Test(normalizedExpected, normalizedActual, 4e-5);
                }
            }
        }

        public static string SerializeUnaryCase(UnaryCase testCase) {
#if UNITY_5_6_OR_NEWER
            return JsonUtility.ToJson(testCase);
#else
            return System.Text.Json.JsonSerializer.Serialize(testCase);
#endif
        }

        [TestCase("vector_unary.json")]
        public static void TestVectorUnary(string path) {
            path = Utility.MakeUpPath(path);
            if (File.Exists(path)) {
                var file = File.OpenText(path);
                var line = file.ReadLine();
                while (line != null) {
                    if (line == "[" || line == "]" || line == "") {
                        line = file.ReadLine();
                        continue;
                    }
                    if (line.StartsWith("{", StringComparison.Ordinal)) {
                        if (line.EndsWith("},", StringComparison.Ordinal)) {
                            line = line.Substring(0, line.Length - 1);
                        } else if (!line.EndsWith("}", StringComparison.Ordinal)) {
                            throw new NotImplementedException();
                        }

#if UNITY_5_6_OR_NEWER
                        var testCase = JsonUtility.FromJson<UnaryCase>(line);
#else
                        var testCase = System.Text.Json.JsonSerializer.Deserialize<UnaryCase>(line);
#endif
                        long nx = 0, ny = 0, nz = 0, nw = 0;
                        switch (testCase.bits.Count) {
                            case 2: {
                                var indices = new List<List<int>> {
                                    new List<int> { 0, 1 },
                                    new List<int> { 1, 0 },
                                };
                                var x = testCase.bits[0];
                                var y = testCase.bits[1];
                                if (testCase.normalized.Count != 0) {
                                    nx = testCase.normalized[0];
                                    ny = testCase.normalized[1];
                                }
                                foreach (var index in indices) {
                                    testCase.bits[index[0]] = x;
                                    testCase.bits[index[1]] = y;
                                    if (testCase.normalized.Count != 0) {
                                        testCase.normalized[index[0]] = nx;
                                        testCase.normalized[index[1]] = ny;
                                    }
                                    testCase.Test();
                                }
                                break;
                            }
                            case 3: {
                                var indices = new List<List<int>> {
                                    new List<int> { 0, 1, 2 },
                                    new List<int> { 0, 2, 1 },
                                    new List<int> { 1, 2, 0 },
                                    new List<int> { 1, 0, 2 },
                                    new List<int> { 2, 0, 1 },
                                    new List<int> { 2, 1, 0 },
                                };
                                var x = testCase.bits[0];
                                var y = testCase.bits[1];
                                var z = testCase.bits[2];
                                if (testCase.normalized.Count != 0) {
                                    nx = testCase.normalized[0];
                                    ny = testCase.normalized[1];
                                    nz = testCase.normalized[2];
                                }
                                foreach (var index in indices) {
                                    testCase.bits[index[0]] = x;
                                    testCase.bits[index[1]] = y;
                                    testCase.bits[index[2]] = z;
                                    if (testCase.normalized.Count != 0) {
                                        testCase.normalized[index[0]] = nx;
                                        testCase.normalized[index[1]] = ny;
                                        testCase.normalized[index[2]] = nz;
                                    }
                                    testCase.Test();
                                }
                                break;
                            }
                            case 4: {
                                var indices = new List<List<int>> {
                                    new List<int> { 0, 1, 2, 3 },
                                    new List<int> { 0, 1, 3, 2 },
                                    new List<int> { 0, 2, 3, 1 },
                                    new List<int> { 0, 2, 1, 3 },
                                    new List<int> { 0, 3, 1, 2 },
                                    new List<int> { 0, 3, 2, 1 },
                                    new List<int> { 1, 2, 3, 0 },
                                    new List<int> { 1, 2, 0, 3 },
                                    new List<int> { 1, 3, 0, 2 },
                                    new List<int> { 1, 3, 2, 0 },
                                    new List<int> { 1, 0, 2, 3 },
                                    new List<int> { 1, 0, 3, 2 },
                                    new List<int> { 2, 3, 0, 1 },
                                    new List<int> { 2, 3, 1, 0 },
                                    new List<int> { 2, 0, 1, 3 },
                                    new List<int> { 2, 0, 3, 1 },
                                    new List<int> { 2, 1, 3, 0 },
                                    new List<int> { 2, 1, 0, 3 },
                                    new List<int> { 3, 0, 1, 2 },
                                    new List<int> { 3, 0, 2, 1 },
                                    new List<int> { 3, 1, 2, 0 },
                                    new List<int> { 3, 1, 0, 2 },
                                    new List<int> { 3, 2, 0, 1 },
                                    new List<int> { 3, 2, 1, 0 },
                                };
                                var x = testCase.bits[0];
                                var y = testCase.bits[1];
                                var z = testCase.bits[2];
                                var w = testCase.bits[3];
                                if (testCase.normalized.Count != 0) {
                                    nx = testCase.normalized[0];
                                    ny = testCase.normalized[1];
                                    nz = testCase.normalized[2];
                                    nw = testCase.normalized[3];
                                }
                                foreach (var index in indices) {
                                    testCase.bits[index[0]] = x;
                                    testCase.bits[index[1]] = y;
                                    testCase.bits[index[2]] = z;
                                    testCase.bits[index[3]] = w;
                                    if (testCase.normalized.Count != 0) {
                                        testCase.normalized[index[0]] = nx;
                                        testCase.normalized[index[1]] = ny;
                                        testCase.normalized[index[2]] = nz;
                                        testCase.normalized[index[3]] = nw;
                                    }
                                    testCase.Test();
                                }
                                break;
                            }
                            default: {
                                throw new NotImplementedException();
                            }
                        }
                    } else {
                        throw new NotImplementedException();
                    }
                    line = file.ReadLine();
                }
            } else {
                var file = File.CreateText(path);
                file.WriteLine("[");
                var l = new List<long> {
                    -2, -1, 0, 1, 2,
                    int.MinValue,
                    int.MinValue + 1,
                    int.MaxValue - 1,
                    int.MaxValue,
                    int.MaxValue + 1L,
                    int.MaxValue + 2L,
                    uint.MaxValue - 1L,
                    uint.MaxValue
                };

                foreach (var x in l) {
                    foreach (var y in l) {
                        if (x < y) {
                            continue;
                        }
                        var signed = AllAreInt(x, y);
                        var unsigned = AllAreUInt(x, y);
                        if (signed || unsigned) {
                            var c = new UnaryCase(new List<long> { x, y });
                            var s = SerializeUnaryCase(c);
                            file.Write(s);
                            file.WriteLine(",");
                        }
                    }
                }
                foreach (var x in l) {
                    foreach (var y in l) {
                        if (x < y) {
                            continue;
                        }
                        foreach (var z in l) {
                            if (y < z) {
                                continue;
                            }
                            var signed = AllAreInt(x, y, z);
                            var unsigned = AllAreUInt(x, y, z);
                            if (signed || unsigned) {
                                var c = new UnaryCase(new List<long> { x, y, z });
                                var s = SerializeUnaryCase(c);
                                file.Write(s);
                                file.WriteLine(",");
                            }
                        }
                    }
                }
                foreach (var x in l) {
                    foreach (var y in l) {
                        if (x < y) {
                            continue;
                        }
                        foreach (var z in l) {
                            if (y < z) {
                                continue;
                            }
                            foreach (var w in l) {
                                if (z < w) {
                                    continue;
                                }
                                var signed = AllAreInt(x, y, z, w);
                                var unsigned = AllAreUInt(x, y, z, w);
                                if (signed || unsigned) {
                                    var c = new UnaryCase(new List<long> { x, y, z, w });
                                    var s = SerializeUnaryCase(c);
                                    file.Write(s);
                                    file.WriteLine(",");
                                }
                            }
                        }
                    }
                }

                {
                    var rng = new Xoroshiro128StarStar(1, 2);
                    var list = new List<long>();
                    for (var i = 0; i < 99; ++i) {
                        var x = rng.NextInt64();
                        var y = rng.NextInt64();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        var c = new UnaryCase(list);
                        var s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.NextInt64();
                        y = rng.NextInt64();
                        list.Add(unchecked((uint)x));
                        list.Add(unchecked((uint)y));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.NextInt64();
                        y = rng.NextInt64();
                        var z = rng.NextInt64();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        list.Add(unchecked((int)z));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.NextInt64();
                        y = rng.NextInt64();
                        z = rng.NextInt64();
                        list.Add(unchecked((uint)x));
                        list.Add(unchecked((uint)y));
                        list.Add(unchecked((uint)z));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.NextInt64();
                        y = rng.NextInt64();
                        z = rng.NextInt64();
                        var w = rng.NextInt64();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        list.Add(unchecked((int)z));
                        list.Add(unchecked((int)w));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.NextInt64();
                        y = rng.NextInt64();
                        z = rng.NextInt64();
                        w = rng.NextInt64();
                        list.Add(unchecked((uint)x));
                        list.Add(unchecked((uint)y));
                        list.Add(unchecked((uint)z));
                        list.Add(unchecked((uint)w));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        if (i == 98) {
                            file.WriteLine();
                        } else {
                            file.WriteLine(",");
                        }
                        list.Clear();
                    }
                }

                file.WriteLine("]");
                file.Close();
            }
        }
    }
}
