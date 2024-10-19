namespace AgatePris.Intar {
    readonly struct Int128 {

#if BIGENDIAN

        private readonly ulong upper;
        private readonly ulong lower;

#else

        readonly ulong lower;
        readonly ulong upper;

#endif

        public static Int128 MinValue => new Int128(1UL << 63, 0);
        public static Int128 MaxValue => new Int128((1UL << 63) - 1, ulong.MaxValue);

        public Int128(ulong upper, ulong lower) {
            this.lower = lower;
            this.upper = upper;
        }
{% for t in ['uint', 'ulong', 'ushort', 'byte'] %}
        public static implicit operator Int128({{ t }} value) => new Int128(0, value);
{%- endfor %}

{%- for t in ['int', 'long', 'short', 'sbyte'] %}

        public static implicit operator Int128({{ t }} value) {

            // 符号付き整数型からの変換。
            // 算術シフトを利用して上位ビットを埋める。
    {%- if t == 'long' %}

            return unchecked(new Int128((ulong)(value >> 63), (ulong)value));
    {%- else %}

            long lower = value;
            return unchecked(new Int128((ulong)(lower >> 63), (ulong)lower));
    {%- endif %}
        }
{%- endfor %}

        public static Int128 operator +(Int128 left, Int128 right) {

            // 下位ビットの加算でオーバーフローが起きたら上位ビットに 1 加算する。
            // 001 + 001 = 010 ( 1 +  1 =  2)
            // 111 + 001 = 000 (-1 +  1 =  0)
            // 111 + 111 = 110 (-1 + -1 = -2)

            var overflow = Overflowing.OverflowingAdd(left.lower, right.lower, out var lower);
            var upper = unchecked(left.upper + right.upper + (overflow ? 1UL : 0UL));
            return new Int128(upper, lower);
        }
    }
} // namespace AgatePris.Intar
