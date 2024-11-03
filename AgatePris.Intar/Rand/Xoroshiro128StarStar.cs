namespace AgatePris.Intar.Rand {
    public struct Xoroshiro128StarStar {
        ulong s0, s1;

        public Xoroshiro128StarStar(ulong s0, ulong s1) {
            this.s0 = s0;
            this.s1 = s1;
        }

        public ulong NextUInt64() {
            var s0 = this.s0;
            var s1 = this.s1;
            var result = unchecked(BitOperations.RotateLeft(s0 * 5, 7) * 9);
            s1 ^= s0;
            this.s0 = BitOperations.RotateLeft(s0, 24) ^ s1 ^ (s1 << 16);
            this.s1 = BitOperations.RotateLeft(s1, 37);
            return result;
        }
        public long NextInt64() {
            return unchecked((long)NextInt64());
        }
        public long NextInt64(long minValue, long maxValue) {
            var d = Mathi.AbsDiff(minValue, maxValue);
            var x = unchecked((ulong)NextInt64());
            while (ulong.MaxValue / d * d <= x) {
                x = unchecked((ulong)NextInt64());
            }
            return Overflowing.WrappingAddUnsigned(minValue, x % d);
        }
        public long NextInt64(long maxValue) => NextInt64(0, maxValue);
        public int Next() => unchecked((int)NextInt64());
        public int Next(int minValue, int maxValue) => unchecked((int)NextInt64(minValue, maxValue));
        public int Next(int maxValue) => Next(0, maxValue);

        public void Jump() {
            const ulong k1 = 0xdf900294d8f554a5UL;
            const ulong k2 = 0x170865df4b3201fcUL;
            var s0 = 0UL;
            var s1 = 0UL;
            for (var i = 0; i < 64; ++i) {
                if ((k1 & (1UL << i)) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                _ = NextInt64();
            }
            for (var i = 0; i < 64; ++i) {
                if ((k2 & (1UL << i)) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                _ = NextInt64();
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
                if ((k1 & (1UL << i)) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                _ = NextInt64();
            }
            for (var i = 0; i < 64; ++i) {
                if ((k2 & (1UL << i)) != 0) {
                    s0 ^= this.s0;
                    s1 ^= this.s1;
                }
                _ = NextInt64();
            }
            this.s0 = s0;
            this.s1 = s1;
        }
    }
}
