namespace Intar.Tests {
        readonly struct BigRational
        {
            readonly BigInteger numer;
            readonly BigInteger denom;
            public BigRational(BigInteger numer, BigInteger denom)
            {
                var gcd = BigInteger.GreatestCommonDivisor(numer, denom);
                numer /= gcd;
                denom /= gcd;
                this.numer = numer;
                this.denom = denom;
            }
            public BigRational(BigInteger numer) : this(numer, 1) { }
            public override string ToString()
            {
                return $"{numer}/{denom}";
            }
            public static BigRational operator *(BigRational left, int right)
            {
                return new BigRational(left.numer * right, left.denom);
            }
            public static BigRational operator *(BigRational left, BigRational right)
            {
                return new BigRational(left.numer * right.numer, left.denom * right.denom);
            }
            public static BigRational operator /(BigRational left, int right)
            {
                return new BigRational(left.numer, left.denom * right);
            }
            public static BigRational operator /(int left, BigRational right)
            {
                return new BigRational(left * right.denom, right.numer);
            }
            public static bool operator <(BigRational left, ulong right)
            {
                return left.numer < left.denom * right;
            }
            public static bool operator >(BigRational left, ulong right)
            {
                return left.numer > left.denom * right;
            }
            public static explicit operator int(BigRational v)
            {
                return (int)(v.numer / v.denom);
            }
            public static explicit operator ulong(BigRational v)
            {
                return (ulong)(v.numer / v.denom);
            }
            public BigRational Round()
            {
                BigInteger tmp;
                if (numer < 0 == denom < 0)
                {
                    tmp = 2 * numer + denom;
                }
                else
                {
                    tmp = 2 * numer - denom;
                }
                return new BigRational(tmp / (2 * denom));
            }
            public BigRational Pow(int exponent)
            {
                return new BigRational(BigInteger.Pow(numer, exponent), BigInteger.Pow(denom, exponent));
            }
        }
                static readonly BigRational piLower = ParseReal("3.1415926535897932384626433832795028841971");
        static readonly BigRational piUpper = ParseReal("3.1415926535897932384626433832795028841972");
        static readonly BigRational frac1PiLower = 1 / piUpper;
        static readonly BigRational frac1PiUpper = 1 / piLower;
        static readonly BigRational frac2PiLower = 2 / piUpper;
        static readonly BigRational frac2PiUpper = 2 / piLower;
        static readonly BigRational fracPi2Lower = piLower / 2;
        static readonly BigRational fracPi2Upper = piUpper / 2;
        static BigRational ParseReal(string s)
        {
            var i = s.IndexOf('.');
            if (i < 0)
            {
                return new BigRational(BigInteger.Parse(s));
            }
            else
            {
                var numer = s.Remove(i, 1);
                var denom = "1" + new string('0', s.Length - i - 1);
                return new BigRational(BigInteger.Parse(numer), BigInteger.Parse(denom));
            }
        }

        static void Check32(
            BigRational lower,
            BigRational upper,
            int epectedCount,
            uint expected,
            bool floor
        )
        {
            const ulong z = 1U << 31;
            {
                var count = 0;
                while (lower < z)
                {
                    count++;
                    lower *= 2;
                    upper *= 2;
                }
                Debug.Assert(31 + epectedCount == count, $"lower:{lower} epectedCount:{epectedCount} count:{count}");
            }
            if (!floor)
            {
                lower = lower.Round();
                upper = upper.Round();
            }
            var l = (uint)lower;
            var u = (uint)upper;
            Debug.Assert(l == u);
            Debug.Assert(expected == l);
        }
        static void Check64(
            BigRational lower,
            BigRational upper,
            int epectedCount,
            ulong expected,
            bool floor
        )
        {
            const ulong z = 1UL << 63;
            {
                var count = 0;
                while (lower < z)
                {
                    count++;
                    lower *= 2;
                    upper *= 2;
                }
                Debug.Assert(63 + epectedCount == count, $"lower:{lower} epectedCount:{epectedCount} count:{count}");
            }
            if (!floor)
            {
                lower = lower.Round();
                upper = upper.Round();
            }
            var l = (ulong)lower;
            var u = (ulong)upper;
            Debug.Assert(l == u);
            Debug.Assert(expected == l);
        }
        static void CheckAsin32(string v, int expectedCount, uint expected, bool floor)
        {
            var k = ParseReal(v);
            var lower = frac2PiLower * k;
            var upper = frac2PiUpper * k;
            Check32(lower, upper, expectedCount, expected, floor);
        }
        static void CheckAsin64(string v, int expectedCount, ulong expected, bool floor)
        {
            var k = ParseReal(v);
            var lower = frac2PiLower * k;
            var upper = frac2PiUpper * k;
            Check64(lower, upper, expectedCount, expected, floor);
        }
        static void CheckAtan32(string s, int expectedCount, uint expected, bool floor)
        {
            var k = ParseReal(s);
            var lower = frac1PiLower * k;
            var upper = frac1PiUpper * k;
            Check32(lower, upper, expectedCount, expected, floor);
        }
        static void CheckAtan64(string s, int expectedCount, ulong expected, bool floor)
        {
            var k = ParseReal(s);
            var lower = frac1PiLower * k;
            var upper = frac1PiUpper * k;
            Check64(lower, upper, expectedCount, expected, floor);
        }
        static void CheckSin32(string s, int exponent, int expectedCount, uint expected, bool floor)
        {
            var k = ParseReal(s);
            var lower = fracPi2Lower.Pow(exponent) * k;
            var upper = fracPi2Upper.Pow(exponent) * k;
            Check32(lower, upper, expectedCount, expected, floor);
        }
        static void CheckSin64(string s, int exponent, int expectedCount, ulong expected, bool floor)
        {
            var k = ParseReal(s);
            var lower = fracPi2Lower.Pow(exponent) * k;
            var upper = fracPi2Upper.Pow(exponent) * k;
            Check64(lower, upper, expectedCount, expected, floor);
        }

        [Test]
        public static void TestShift()
        {
            Debug.Assert(1U == 2U >> 1);
            Debug.Assert(0U == 0x7fffffffU >> 31);
            Debug.Assert(1U == 0x80000000U >> 31);
            var x = (F32)3.14F;
            Console.WriteLine((float)x);
            var y = (F32)2.5F;
            Console.WriteLine((float)y);
            Console.WriteLine((float)(x + y));
            var z = (F32)10.27F;
            Console.WriteLine((float)(x + z));
        }

        [Test]
        public static void TestConstant()
        {
            Console.WriteLine("Test");
            Debug.Assert(1 == (ulong)new BigRational(5, 3));
            Debug.Assert(1 == (ulong)new BigRational(-5, -3));
            Assert.Throws<FormatException>(() => ParseReal("1.2.3"));
            Assert.Throws<OverflowException>(() =>
            {
                Debug.Assert(ulong.MaxValue == (ulong)new BigRational(5, -3));
            });
            Assert.Throws<OverflowException>(() =>
            {
                Debug.Assert(ulong.MaxValue == (ulong)new BigRational(-5, 3));
            });
            Debug.Assert(1 == (int)new BigRational(4, 3).Round());
            Debug.Assert(1 == (int)new BigRational(-4, -3).Round());
            Debug.Assert(-1 == (int)new BigRational(4, -3).Round());
            Debug.Assert(-1 == (int)new BigRational(-4, 3).Round());
            Debug.Assert(2 == (int)new BigRational(5, 3).Round());
            Debug.Assert(2 == (int)new BigRational(-5, -3).Round());
            Debug.Assert(-2 == (int)new BigRational(5, -3).Round());
            Debug.Assert(-2 == (int)new BigRational(-5, 3).Round());
            Debug.Assert(1 == (int)new BigRational(1, 2).Round());
            Debug.Assert(1 == (int)new BigRational(-1, -2).Round());
            Debug.Assert(-1 == (int)new BigRational(1, -2).Round());
            Debug.Assert(-1 == (int)new BigRational(-1, 2).Round());
            CheckAsin32("1.5707288", 1, 4294782660, false);
            CheckAsin64("1.5707288", 1, 18445951068606135392, false);
            CheckAsin32("0.2121144", 3, 2319904613, false);
            CheckAsin64("0.2121144", 3, 9963914441109755535, false);
            CheckAsin32("0.0742610", 5, 3248783419, false);
            CheckAsin64("0.0742610", 5, 13953418538510380357, false);
            CheckAsin32("0.0187293", 7, 3277490973, true);
            CheckAsin64("0.0187293", 7, 14076716544798613906, true);
            CheckAsin64("1.5707963050", 1, 18446743817759831598, false);
            CheckAsin64("0.2145988016", 3, 10080617338130213281, false);
            CheckAsin64("0.0889789874", 5, 16718884102355766130, false);
            CheckAsin64("0.0501743046", 5, 9427600920570779471, false);
            CheckAsin64("0.0308918810", 6, 11608983047221464490, false);
            CheckAsin64("0.0170881256", 7, 12843229610990092589, false);
            CheckAsin64("0.0066700901", 8, 10026318940480150471, false);
            CheckAsin64("0.0012624911", 11, 15181969944445121899, true);
            CheckAtan32("0.273", 4, 2985813123, true);
            CheckAtan64("0.273", 4, 12823969718335781357, true);
            CheckAtan32("0.2447", 4, 2676294767, false);
            CheckAtan64("0.2447", 4, 11494598498449691202, false);
            CheckAtan32("0.0663", 6, 2900504177, true);
            CheckAtan64("0.0663", 6, 12457570583526187604, true);
            CheckAtan64("0.9998660", 2, 11741988375818245753, false);
            CheckAtan64("0.3302995", 4, 15515570644620693826, false);
            CheckAtan64("0.1801410", 5, 16923976036855135454, false);
            CheckAtan64("0.0851330", 6, 15996234637818023067, false);
            CheckAtan64("0.0208351", 8, 15659410489582290881, true);
            Check32(fracPi2Lower, fracPi2Upper, 0, 3373259426, false);
            Check64(fracPi2Lower, fracPi2Upper, 0, 14488038916154245685, false);
            CheckSin32("0.16605", 3, 1, 2764129413, false);
            CheckSin64("0.16605", 3, 1, 11871845430268727827, false);
            CheckSin32("0.00761", 5, 4, 2500540483, true);
            CheckSin64("0.00761", 5, 4, 10739739599844454195, true);
            CheckSin32("0.49670", 2, 0, 2631866036, false);
            CheckSin64("0.49670", 2, 0, 11303778553548845368, false);
            CheckSin32("0.03705", 4, 3, 3875141568, true);
            CheckSin64("0.03705", 4, 3, 16643606305160959259, true);
            CheckSin64("0.1666666664", 3, 1, 11915934368436992009, false);
            CheckSin64("0.0083333315", 5, 4, 11760553260076371255, false);
            CheckSin64("0.0001984090", 7, 8, 11054273349336558994, false);
            CheckSin64("0.0000027526", 9, 13, 12108815703571716367, false);
            CheckSin64("0.0000000239", 11, 19, 16602603363585481494, true);
            CheckSin64("0.4999999963", 2, 0, 11378879071774596408, false);
            CheckSin64("0.0416666418", 4, 2, 9358747397805171131, false);
            CheckSin64("0.0013888397", 6, 6, 12315189113921640896, false);
            CheckSin64("0.0000247609", 8, 11, 17335849242745400440, false);
            CheckSin64("0.0000002605", 10, 16, 14400453044121993745, true);
        }
    }
}
