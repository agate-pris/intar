using AgatePris.Intar.Integer;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace AgatePris.Intar.Tests.Integer {
    public partial class BitOperationsTest {
        [Test]
        public static void RotateLeftTest() {
            for (var i = 0; i < 32; ++i) {
                AreEqual(0U, 0U.RotateLeft(i));
            }
            for (var i = 0; i < 64; ++i) {
                AreEqual(0UL, 0UL.RotateLeft(i));
            }
            {
                var k = new uint[] {
                    0x0000_FFFFU, 0x00FF_FF00U, 0xFFFF_0000U, 0xFF00_00FFU,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], k[i].RotateLeft(32));
                    AreEqual(k[(i + 1) % 4], k[i].RotateLeft(8));
                    AreEqual(k[(i + 2) % 4], k[i].RotateLeft(16));
                    AreEqual(k[(i + 3) % 4], k[i].RotateLeft(24));
                }
            }
            {
                var k = new ulong[] {
                    0x0000_0000_0000_FFFFUL, 0x0000_0000_FFFF_0000UL,
                    0x0000_FFFF_0000_0000UL, 0xFFFF_0000_0000_0000UL,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], k[i].RotateLeft(64));
                    AreEqual(k[(i + 1) % 4], k[i].RotateLeft(16));
                    AreEqual(k[(i + 2) % 4], k[i].RotateLeft(32));
                    AreEqual(k[(i + 3) % 4], k[i].RotateLeft(48));
                }
            }
        }

        [Test]
        public static void RotateRightTest() {
            for (var i = 0; i < 32; ++i) {
                AreEqual(0U, 0U.RotateRight(i));
            }
            for (var i = 0; i < 64; ++i) {
                AreEqual(0UL, 0UL.RotateRight(i));
            }
            {
                var k = new uint[] {
                    0xFFFF_0000U, 0x00FF_FF00U, 0x0000_FFFFU, 0xFF00_00FFU,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], k[i].RotateRight(32));
                    AreEqual(k[(i + 1) % 4], k[i].RotateRight(8));
                    AreEqual(k[(i + 2) % 4], k[i].RotateRight(16));
                    AreEqual(k[(i + 3) % 4], k[i].RotateRight(24));
                }
            }
            {
                var k = new ulong[] {
                    0xFFFF_0000_0000_0000UL, 0x0000_FFFF_0000_0000UL,
                    0x0000_0000_FFFF_0000UL, 0x0000_0000_0000_FFFFUL,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], k[i].RotateRight(64));
                    AreEqual(k[(i + 1) % 4], k[i].RotateRight(16));
                    AreEqual(k[(i + 2) % 4], k[i].RotateRight(32));
                    AreEqual(k[(i + 3) % 4], k[i].RotateRight(48));
                }
            }
        }
    }
}
