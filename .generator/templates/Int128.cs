namespace AgatePris.Intar {
    readonly struct Int128 {

#if BIGENDIAN

        private readonly ulong upper;
        private readonly ulong lower;

#else

        readonly ulong lower;
        readonly ulong upper;

#endif

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
            var overflow = Overflowing.OverflowingAdd(left.lower, right.lower, out var lower);
            var upper = left.upper + right.upper + (overflow ? 1UL : 0UL);
            return new Int128(upper, lower);
        }
    }
} // namespace AgatePris.Intar
