using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace Intar1991.Tests.Rand {
    public class Xoroshiro128StarStarTest {
        [Test]
        public static void NextTest() {
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
            var expected = new ulong[] {
                5760, 97769243520, 9706862127477703552, 9223447511460779954, 8358291023205304566,
                15695619998649302768, 8517900938696309774, 16586480348202605369,
                6959129367028440372, 16822147227405758281,
            };
            foreach (var e in expected) {
                Utility.AssertAreEqual(e, unchecked((ulong)rng.NextInt64()));
            }
        }

        [Test]
        public static void JumpTest() {
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
            rng.Jump();
            var expected = new ulong[] {
                2464231652016875657, 11602794600843324846, 733764001042591551, 5324733124812429005,
                14635935237425590731, 4722186862080112093, 16160338188616420244,
                5488700251982350304, 9830647176479810634, 6282991482565129712,
            };
            foreach (var e in expected) {
                Utility.AssertAreEqual(e, unchecked((ulong)rng.NextInt64()));
            }
        }

        [Test]
        public static void LongJumpTest() {
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
            rng.LongJump();
            var expected = new ulong[] {
                1154914562721061336, 6059381922964790418, 15458620134926953352, 6449629845481199462,
                16689757678599312554, 3412265672712362534, 15452021286289288989,
                14008746486977289672, 12513606066216797820, 17066077850955568493,
            };
            foreach (var e in expected) {
                Utility.AssertAreEqual(e, unchecked((ulong)rng.NextInt64()));
            }
        }

        [Test]
        public static void TestMinMax() {
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
            var Dictionary = new Dictionary<int, int>();
            for (var i = 0; i < 9999; ++i) {
                var x = rng.Next(9);
                if (Dictionary.ContainsKey(x)) {
                    Dictionary[x] += 1;
                } else {
                    Dictionary[x] = 1;
                }
            }
            foreach (var kv in Dictionary) {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
            Dictionary.Clear();
            Console.WriteLine("");
            for (var i = 0; i < 9999; ++i) {
                var x = rng.Next(5, 9);
                if (Dictionary.ContainsKey(x)) {
                    Dictionary[x] += 1;
                } else {
                    Dictionary[x] = 1;
                }
            }
            foreach (var kv in Dictionary) {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }
    }
}
