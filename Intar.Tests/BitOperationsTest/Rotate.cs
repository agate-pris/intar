using NUnit.Framework;
using static AgatePris.Intar.BitOperations;
using static NUnit.Framework.Assert;

namespace AgatePris.Intar.Tests {
    public partial class BitOperationsTest {
        [Test]
        public static void RotateLeftTest() {
            for (var i = 0; i < 32; ++i) {
                AreEqual(0U, RotateLeft(0U, i));
            }
            for (var i = 0; i < 64; ++i) {
                AreEqual(0UL, RotateLeft(0UL, i));
            }
            {
                var k = new uint[] {
                    0x0000_FFFFU, 0x00FF_FF00U, 0xFFFF_0000U, 0xFF00_00FFU,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], RotateLeft(k[i], 32));
                    AreEqual(k[(i + 1) % 4], RotateLeft(k[i], 8));
                    AreEqual(k[(i + 2) % 4], RotateLeft(k[i], 16));
                    AreEqual(k[(i + 3) % 4], RotateLeft(k[i], 24));
                }
            }
            {
                var k = new ulong[] {
                    0x0000_0000_0000_FFFFUL, 0x0000_0000_FFFF_0000UL,
                    0x0000_FFFF_0000_0000UL, 0xFFFF_0000_0000_0000UL,
                };
                for (var i = 0; i < 4; ++i) {
                    AreEqual(k[i], RotateLeft(k[i], 64));
                    AreEqual(k[(i + 1) % 4], RotateLeft(k[i], 16));
                    AreEqual(k[(i + 2) % 4], RotateLeft(k[i], 32));
                    AreEqual(k[(i + 3) % 4], RotateLeft(k[i], 48));
                }
            }
        }
    }
}
