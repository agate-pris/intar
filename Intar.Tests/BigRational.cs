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
}
