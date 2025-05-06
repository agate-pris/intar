{% import "macros.cs" as macros %}
{%- set bits = int_nbits+frac_nbits %}
{%- set bits_type  = macros::inttype(signed=signed, bits=bits) %}
{%- set fixed = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- if bits > 32 -%}
#if NET7_0_OR_GREATER

{% endif -%}
using NUnit.Framework;
using System;

namespace {{ namespace }}.Tests {
    public class {{ fixed }}Test {
        {%- for order in [2, 3, 9] %}
        {%- if bits < 64 and order == 9 %}{% continue %}{% endif %}
        static void TestAtan2P{{ order }}({{ bits_type }} y, {{ bits_type }} x) {
            {%- if int_nbits == 2 %}
            const double scale = Math.PI;
            {%- elif int_nbits - frac_nbits == 2 %}
            const double scale = Math.PI / 2;
            {%- endif %}
            var negativeY = -y;
            var negativeX = -x;
            var a = {{ fixed }}.Atan2P{{ order }}(y, x);
            var b = {{ fixed }}.Atan2P{{ order }}(x, y);
            var c = {{ fixed }}.Atan2P{{ order }}(x, negativeY);
            var d = {{ fixed }}.Atan2P{{ order }}(y, negativeX);
            var e = {{ fixed }}.Atan2P{{ order }}(negativeY, negativeX);
            var f = {{ fixed }}.Atan2P{{ order }}(negativeX, negativeY);
            var g = {{ fixed }}.Atan2P{{ order }}(negativeX, y);
            var h = {{ fixed }}.Atan2P{{ order }}(negativeY, x);
            const double delta = 4e-3;
            Utility.AssertAreEqual(Math.Atan2(y, x), (double)a * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, y), (double)b * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, negativeY), (double)c * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(y, negativeX), (double)d * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, negativeX), (double)e * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, negativeY), (double)f * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, y), (double)g * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, x), (double)h * scale, delta);
            {%- if int_nbits == 2 %}
            const {{ bits_type }} right = {{ fixed }}.OneRepr / 2;
            const {{ bits_type }} negativeRight = -right;
            if (right - a.Bits != b.Bits) {
                Assert.AreEqual(right - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if (right + a.Bits != c.Bits) {
                Assert.AreEqual(right + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if ({{ fixed }}.OneRepr - a.Bits != d.Bits) {
                Assert.AreEqual({{ fixed }}.OneRepr - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - {{ fixed }}.OneRepr != e.Bits) {
                Assert.AreEqual(a.Bits - {{ fixed }}.OneRepr, e.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight - a.Bits != f.Bits) {
                Assert.AreEqual(negativeRight - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight + a.Bits != g.Bits) {
                Assert.AreEqual(negativeRight + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
            {%- elif int_nbits - frac_nbits == 2 %}
            const {{ bits_type }} straight = {{ fixed }}.OneRepr * 2;
            if ({{ fixed }}.OneRepr - a.Bits != b.Bits) {
                Assert.AreEqual({{ fixed }}.OneRepr - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if ({{ fixed }}.OneRepr + a.Bits != c.Bits) {
                Assert.AreEqual({{ fixed }}.OneRepr + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if (straight - a.Bits != d.Bits) {
                Assert.AreEqual(straight - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - straight != e.Bits) {
                Assert.AreEqual(a.Bits - straight, e.Bits, $"y:{y} x:{x}");
            }
            if ({{ fixed }}.NegativeOneRepr - a.Bits != f.Bits) {
                Assert.AreEqual({{ fixed }}.NegativeOneRepr - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if ({{ fixed }}.NegativeOneRepr + a.Bits != g.Bits) {
                Assert.AreEqual({{ fixed }}.NegativeOneRepr + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
            {%- endif %}
        }
        [Test]
        public void TestAtan2P{{ order }}() {
            {
                var a = {{ fixed }}.Atan2P{{ order }}(0, 0);
                var b = {{ fixed }}.Atan2P{{ order }}(0, 1);
                var c = {{ fixed }}.Atan2P{{ order }}(1, 0);
                var d = {{ fixed }}.Atan2P{{ order }}(1, 1);
                var e = {{ fixed }}.Atan2P{{ order }}(0, -1);
                var f = {{ fixed }}.Atan2P{{ order }}(1, -1);
                var g = {{ fixed }}.Atan2P{{ order }}(-1, 0);
                var h = {{ fixed }}.Atan2P{{ order }}(-1, 1);
                var i = {{ fixed }}.Atan2P{{ order }}(-1, -1);
                {%- if int_nbits == 2 %}
                Assert.AreEqual({{ fixed }}.Zero, a);
                Assert.AreEqual({{ fixed }}.Zero, b);
                Assert.AreEqual({{ fixed }}.OneRepr / 2, c.Bits);
                Assert.AreEqual({{ fixed }}.OneRepr / 4, d.Bits);
                Assert.AreEqual({{ fixed }}.One, e);
                Assert.AreEqual({{ fixed }}.OneRepr / 4 * 3, f.Bits);
                Assert.AreEqual({{ fixed }}.NegativeOneRepr / 2, g.Bits);
                Assert.AreEqual({{ fixed }}.NegativeOneRepr / 4, h.Bits);
                Assert.AreEqual({{ fixed }}.NegativeOneRepr / 4 * 3, i.Bits);
                {%- elif int_nbits - frac_nbits == 2 %}
                Assert.AreEqual({{ fixed }}.Zero, a);
                Assert.AreEqual({{ fixed }}.Zero, b);
                Assert.AreEqual({{ fixed }}.One, c);
                Assert.AreEqual({{ fixed }}.OneRepr / 2, d.Bits);
                Assert.AreEqual({{ fixed }}.OneRepr * 2, e.Bits);
                Assert.AreEqual({{ fixed }}.OneRepr / 2 * 3, f.Bits);
                Assert.AreEqual({{ fixed }}.NegativeOne, g);
                Assert.AreEqual({{ fixed }}.NegativeOneRepr / 2, h.Bits);
                Assert.AreEqual({{ fixed }}.NegativeOneRepr / 2 * 3, i.Bits);
                {%- else %}
                    {{ throw(message="unexpected") }}
                {%- endif %}
            }
            for (var i = 1; i <= 1 << 15; i++) {
                TestAtan2P{{ order }}(i, 1 << 15);
            }
            var random = new Random();
            for (var i = 0; i < 100; i++) {
                var a = random.Next(0, int.MaxValue) + 1;
                var b = random.Next(0, int.MaxValue) + 1;
                if (a < b) {
                    TestAtan2P{{ order }}(a, b);
                } else {
                    TestAtan2P{{ order }}(b, a);
                }
            }
        }
        {%- endfor %}
    }
} // namespace {{ namespace }}.Tests
{%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
{%- endif %}
