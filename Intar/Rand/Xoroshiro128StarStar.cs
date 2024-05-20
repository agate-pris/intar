using static AgatePris.Intar.BitOperations;

namespace AgatePris.Intar.Rand {
    public struct Xoroshiro128StarStar {
        ulong s0, s1;

        public Xoroshiro128StarStar(ulong s0, ulong s1) {
            this.s0 = s0;
            this.s1 = s1;
        }

        public ulong Next() {
            var s0 = this.s0;
            var s1 = this.s1;
            var result = unchecked(RotateLeft(s0 * 5, 7) * 9);
            s1 ^= s0;
            this.s0 = RotateLeft(s0, 24) ^ s1 ^ (s1 << 16);
            this.s1 = RotateLeft(s1, 37);
            return result;
        }

        public void Jump() {
            const ulong k1 = 0xdf900294d8f554a5UL;
            const ulong k2 = 0x170865df4b3201fcUL;
            var s0 = 0UL;
            var s1 = 0UL;
            for (var i = 0; i < 64; ++i) {
                if ((k1 & 1UL << i) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                Next();
            }
            for (var i = 0; i < 64; ++i) {
                if ((k2 & 1UL << i) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                Next();
            }
            this.s0 = s0;
            this.s1 = s1;
        }

        public void LongJump() {
            const ulong k1 = 0xd2a98b26625eee7bUL;
            const ulong k2 = 0xdddf9b1090aa7ac1UL;
            var s0 = 0UL;
            var s1 = 0UL;
            for (var i = 0; i < 64; ++i) {
                if ((k1 & 1UL << i) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                Next();
            }
            for (var i = 0; i < 64; ++i) {
                if ((k2 & 1UL << i) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                Next();
            }
            this.s0 = s0;
            this.s1 = s1;
        }
    }
}
