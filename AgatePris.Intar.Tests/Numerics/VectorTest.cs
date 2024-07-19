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
        public static bool IsInt(long x) => int.MinValue <= x && x <= int.MaxValue;
        public static bool IsUInt(long x) => uint.MinValue <= x && x <= uint.MaxValue;
        public static bool AllAreInt(long x, long y) => IsInt(x) && IsInt(y);
        public static bool AllAreInt(long x, long y, long z) => AllAreInt(x, y) && IsInt(z);
        public static bool AllAreInt(long x, long y, long z, long w) => AllAreInt(x, y, z) && IsInt(w);
        public static bool AllAreUInt(long x, long y) => IsUInt(x) && IsUInt(y);
        public static bool AllAreUInt(long x, long y, long z) => AllAreUInt(x, y) && IsUInt(z);
        public static bool AllAreUInt(long x, long y, long z, long w) => AllAreUInt(x, y, z) && IsUInt(w);

#if NET5_0_OR_GREATER || UNITY_2021_2_OR_NEWER
#pragma warning disable IDE0004 // 不要なキャストの削除
#endif

        public static int? CheckedToInt(long x) => IsInt(x) ? (int)x : (int?)null;
        public static uint? CheckedToUInt(long x) => IsUInt(x) ? (uint)x : (uint?)null;
        public static I17F15? CheckedToI17F15(long x) => IsInt(x) ? I17F15.FromBits((int)x) : (I17F15?)null;
        public static U17F15? CheckedToU17F15(long x) => IsUInt(x) ? U17F15.FromBits((uint)x) : (U17F15?)null;
        public static Vector2I17F15? CheckedToVector2I17F15(List<long> l) => l.Count == 2 && l.All(IsInt)
            ? Generator.Vector(
                CheckedToI17F15(l[0]).Value,
                CheckedToI17F15(l[1]).Value)
            : (Vector2I17F15?)null;
        public static Vector3I17F15? CheckedToVector3I17F15(List<long> l) => l.Count == 3 && l.All(IsInt)
            ? Generator.Vector(
                CheckedToI17F15(l[0]).Value,
                CheckedToI17F15(l[1]).Value,
                CheckedToI17F15(l[2]).Value)
            : (Vector3I17F15?)null;
        public static Vector4I17F15? CheckedToVector4I17F15(List<long> l) => l.Count == 4 && l.All(IsInt)
            ? Generator.Vector(
                CheckedToI17F15(l[0]).Value,
                CheckedToI17F15(l[1]).Value,
                CheckedToI17F15(l[2]).Value,
                CheckedToI17F15(l[3]).Value)
            : (Vector4I17F15?)null;
        public static Vector2U17F15? CheckedToVector2U17F15(List<long> l) => l.Count == 2 && l.All(IsUInt)
            ? Generator.Vector(
                CheckedToU17F15(l[0]).Value,
                CheckedToU17F15(l[1]).Value)
            : (Vector2U17F15?)null;
        public static Vector3U17F15? CheckedToVector3U17F15(List<long> l) => l.Count == 3 && l.All(IsUInt)
            ? Generator.Vector(
                CheckedToU17F15(l[0]).Value,
                CheckedToU17F15(l[1]).Value,
                CheckedToU17F15(l[2]).Value)
            : (Vector3U17F15?)null;
        public static Vector4U17F15? CheckedToVector4U17F15(List<long> l) => l.Count == 4 && l.All(IsUInt)
            ? Generator.Vector(
                CheckedToU17F15(l[0]).Value,
                CheckedToU17F15(l[1]).Value,
                CheckedToU17F15(l[2]).Value,
                CheckedToU17F15(l[3]).Value)
            : (Vector4U17F15?)null;

#if NET5_0_OR_GREATER || UNITY_2021_2_OR_NEWER
#pragma warning restore IDE0004 // 不要なキャストの削除
#endif

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

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

            public bool AllBitsAreInt() => bits.All(IsInt);
            public bool AllBitsAreUInt() => bits.All(IsUInt);

            public Vector2I17F15? Vector2Signed() => CheckedToVector2I17F15(bits);
            public Vector3I17F15? Vector3Signed() => CheckedToVector3I17F15(bits);
            public Vector4I17F15? Vector4Signed() => CheckedToVector4I17F15(bits);
            public Vector2U17F15? Vector2Unsigned() => CheckedToVector2U17F15(bits);
            public Vector3U17F15? Vector3Unsigned() => CheckedToVector3U17F15(bits);
            public Vector4U17F15? Vector4Unsigned() => CheckedToVector4U17F15(bits);

            public UnaryCase(List<long> bits) {
                this.bits = new List<long>();
                foreach (var item in bits) {
                    this.bits.Add(item);
                }
                var signed = bits.All(IsInt);
                var unsigned = bits.All(IsUInt);

                IVector<U36F28, I36F28, U18F14, I18F14> v;

                if (signed) {
                    switch (bits.Count) {
                        case 2: {
                            v = CheckedToVector2I17F15(bits).Value;
                            break;
                        }
                        case 3: {
                            v = CheckedToVector3I17F15(bits).Value;
                            break;
                        }
                        case 4: {
                            v = CheckedToVector4I17F15(bits).Value;
                            break;
                        }
                        default: {
                            throw new NotImplementedException();
                        }
                    }
                } else if (unsigned) {
                    switch (bits.Count) {
                        case 2: {
                            v = CheckedToVector2U17F15(bits).Value;
                            break;
                        }
                        case 3: {
                            v = CheckedToVector3U17F15(bits).Value;
                            break;
                        }
                        case 4: {
                            v = CheckedToVector4U17F15(bits).Value;
                            break;
                        }
                        default: {
                            throw new NotImplementedException();
                        }
                    }
                } else {
                    throw new NotImplementedException();
                }

                lengthSquared = $"{v.LengthSquaredUnsigned().Bits}";
                length = v.LengthUnsigned().Bits;
                try {
                    _ = v.LengthSigned().Bits;
                    overflow = false;
                } catch (OverflowException) {
                    overflow = true;
                }
            }

            void Test<T>(
                T v, double lengthSquaredExpected, double lengthExpected
            ) where T : IVector<U36F28, I36F28, U18F14, I18F14> {
                const double deltaRate = 1e-6;
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
                switch (bits.Count) {
                    case 2: {
                        var v = new System.Numerics.Vector2(k * bits[0], k * bits[1]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        break;
                    }
                    case 3: {
                        var v = new System.Numerics.Vector3(k * bits[0], k * bits[1], k * bits[2]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        break;
                    }
                    case 4: {
                        var v = new System.Numerics.Vector4(k * bits[0], k * bits[1], k * bits[2], k * bits[3]);
                        lengthSquaredExpected = v.LengthSquared();
                        lengthExpected = v.Length();
                        break;
                    }
                    default: throw new NotImplementedException();
                }

                if (allBitsAreInt) {
                    switch (bits.Count) {
                        case 2: {
                            var v = CheckedToVector2I17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        case 3: {
                            var v = CheckedToVector3I17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        case 4: {
                            var v = CheckedToVector4I17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        default: throw new NotImplementedException();
                    }
                }
                if (allBitsAreUInt) {
                    switch (bits.Count) {
                        case 2: {
                            var v = CheckedToVector2U17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        case 3: {
                            var v = CheckedToVector3U17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        case 4: {
                            var v = CheckedToVector4U17F15(bits).Value;
                            Test(v, lengthSquaredExpected, lengthExpected);
                            break;
                        }
                        default: throw new NotImplementedException();
                    }
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
                        testCase.Test();
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
                        foreach (var z in l) {
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
                        foreach (var z in l) {
                            foreach (var w in l) {
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
                        var x = rng.Next();
                        var y = rng.Next();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        var c = new UnaryCase(list);
                        var s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.Next();
                        y = rng.Next();
                        list.Add(unchecked((uint)x));
                        list.Add(unchecked((uint)y));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.Next();
                        y = rng.Next();
                        var z = rng.Next();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        list.Add(unchecked((int)z));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.Next();
                        y = rng.Next();
                        z = rng.Next();
                        list.Add(unchecked((uint)x));
                        list.Add(unchecked((uint)y));
                        list.Add(unchecked((uint)z));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.Next();
                        y = rng.Next();
                        z = rng.Next();
                        var w = rng.Next();
                        list.Add(unchecked((int)x));
                        list.Add(unchecked((int)y));
                        list.Add(unchecked((int)z));
                        list.Add(unchecked((int)w));
                        c = new UnaryCase(list);
                        s = SerializeUnaryCase(c);
                        file.Write(s);
                        file.WriteLine(",");
                        list.Clear();

                        x = rng.Next();
                        y = rng.Next();
                        z = rng.Next();
                        w = rng.Next();
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
