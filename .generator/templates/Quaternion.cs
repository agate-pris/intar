{% import "macros.cs" as macros %}
{%- set sin = [2, 3, 4, 5] -%}
{%- set quaternion = macros::quaternion(i=int_nbits, f=frac_nbits) %}
{%- set      bits   = macros::inttype(signed=true,  bits=   int_nbits+frac_nbits ) %}
{%- set wide_bits   = macros::inttype(signed=true,  bits=2*(int_nbits+frac_nbits)) %}
{%- set wide_bits_u = macros::inttype(signed=false, bits=2*(int_nbits+frac_nbits)) %}
{%- set      repr   = macros::vector_primitive(dim=4, signed=true, bits =    int_nbits+frac_nbits)  %}
{%- set      repr_3 = macros::vector_primitive(dim=3, signed=true, bits =    int_nbits+frac_nbits)  %}
{%- set wide_repr   = macros::vector_primitive(dim=4, signed=true, bits = 2*(int_nbits+frac_nbits)) %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set component   = macros::fixed_type(s=true,  i=int_nbits, f=frac_nbits) %}
{%- set component_u = macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) %}
{%- set angle = macros::fixed_type(s=true, i=int_nbits + frac_nbits/2, f=frac_nbits/2) %}
{%- set time  = macros::fixed_type(s=true, i=int_nbits + frac_nbits/2, f=frac_nbits/2) %}
{%- set wide_component   = macros::fixed_type(s=true,  i=int_nbits*2, f=frac_nbits*2) %}
{%- set wide_component_u = macros::fixed_type(s=false, i=int_nbits*2, f=frac_nbits*2) %}
{%- set vector_3 = macros::vector_type(dim=3, type=component) %}
{%- set vector_4 = macros::vector_type(dim=4, type=component) %}
{%- set angles   = macros::vector_type(dim=3, type=angle    ) %}
{%- set wide_one   = macros::one(signed=true,  bits=2*(int_nbits+frac_nbits)) %}
{%- set wide_one_u = macros::one(signed=false, bits=2*(int_nbits+frac_nbits)) %}
{#- -#}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct {{ quaternion }} : IEquatable<{{ quaternion }}>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public {{ repr }} Repr;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ quaternion }}({{ repr }} repr) => Repr = repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }}(
            {%- for c in components -%}
                {{ component }} {{ c|lower }}{% if not loop.last %}, {% endif %}
            {%- endfor %})
            : this(new {{ repr }}({%- for c in components -%}
                {{ c|lower }}.Bits{% if not loop.last %}, {% endif %}
            {%- endfor %})) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }}({{ vector_4 }} xyzw)
            : this(new {{ repr }}({%- for c in components -%}
                xyzw.{{ c }}.Bits{% if not loop.last %}, {% endif %}
            {%- endfor %})) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }}({{ vector_3 }} xyz, {{ component }} w)
            : this(new {{ repr }}(
                {%- for c in components|slice(end=3) -%}
                xyz.{{ c }}.Bits, {# #}
                {%- endfor -%}
                w.Bits
                {#- -#}
            )) { }
        #endregion
        #region Components
        {%- for c in components %}

        public {{ component }} {{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr.{{ c }});
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.{{ c }} = value.Bits;
        }
        {%- endfor %}
        #endregion
        #region Conversion Operators

        public static explicit operator System.Numerics.Quaternion({{ quaternion }} q) {
            return new System.Numerics.Quaternion(
                {%- for c in components %}
                q.{{ c }}.LossyToSingle(){% if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }

#if UNITY_5_6_OR_NEWER
        public static explicit operator UnityEngine.Quaternion({{ quaternion }} q) {
            return new UnityEngine.Quaternion(
                {%- for c in components %}
                q.{{ c }}.LossyToSingle(){% if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
#endif // UNITY_5_6_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.quaternion({{ quaternion }} q) {
            return new Unity.Mathematics.quaternion(
                {%- for c in components %}
                q.{{ c }}.LossyToSingle(){% if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region Vector, Imaginary

        public {{ vector_4 }} Vector {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ vector_4 }}(Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr = value.Repr;
        }

        public {{ vector_3 }} Imaginary {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ vector_3 }}(Repr.XYZ());
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                {%- for c in components|slice(end=3) %}
                Repr.{{ c }} = value.{{ c }}.Bits;
                {%- endfor %}
            }
        }
        #endregion
        #region Identity
        public static readonly {{ quaternion }} Identity = new {{ quaternion }}({{ vector_4 }}.UnitW);
        #endregion
        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ quaternion }} other) => Repr.Equals(other.Repr);
        #endregion
        #region Object

        public override bool Equals(object obj) => obj is {{ quaternion }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => {{ '$"{{' }}{% for c in components -%}
            {{ c }}:{ {{- c -}} }{% if not loop.last %} {% endif %}
        {%- endfor %}{{ '}}"' }};
        #endregion
        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return {{ '$"{{' }}{% for c in components -%}
                {{ c }}:{ {{- c }}.ToString(format, formatProvider)}{% if not loop.last %} {% endif %}
            {%- endfor %}{{ '}}"' }};
        }
        #endregion
        #region IMultiplyOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} operator *({{ quaternion }} l, {{ quaternion }} r) {
            var tmp = r.Repr.BigMul(l.Repr.W);
            tmp += r.Repr.WZYX().BigMul(l.Repr.X) * new Vector4Int64(+1, -1, +1, -1);
            tmp += r.Repr.ZWXY().BigMul(l.Repr.Y) * new Vector4Int64(+1, +1, -1, -1);
            tmp += r.Repr.YXWZ().BigMul(l.Repr.Z) * new Vector4Int64(-1, +1, +1, -1);
            return new {{ quaternion }}((Vector4Int32)(tmp / ({{ wide_one }} << {{ frac_nbits }})));
        }
        #endregion
        #region Concatenate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }} Concatenate({{ quaternion }} other) => other * this;
        #endregion
        #region Rotate
        {%- for d in [1, 2] %}
        {%- set f = d * frac_nbits / 2 %}
        {%- set c = macros::fixed_type(s=true, i=int_nbits+frac_nbits-f, f=f) %}
        {%- set v = macros::vector_type(dim=3, type=c) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ v }} Rotate({{ v }} v) {
            var imaginary = Imaginary.Repr;
            var tmp = ({{ repr_3 }})(2 * imaginary.Cross(v.Repr) / {{ component }}.OneRepr);
            tmp = ({{ repr_3 }})((tmp.BigMul(Repr.W) + imaginary.Cross(tmp)) / {{ component }}.OneRepr);
            return new {{ v }}(tmp + v.Repr);
        }
        {%- endfor %}
        #endregion
        #region Conjugate, Inverse, Dot, Length, LengthSquared, Normalize

        /// <summary>
        /// <para>Returns the conjugate of a quaternion value.</para>
        /// <para>四元数の共役を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// </div></remarks>
        /// </summary>
        /// <returns>
        /// <para>The conjugate of the self.</para>
        /// <para>自身の共役｡</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }} Conjugate() {
            return new {{ quaternion }}(new {{ repr }}(
                {% for c in components|slice(end=3) -%}
                -Repr.{{ c }}, {# #}
                {%- endfor %}
                {%- for c in components|slice(start=3) -%}
                Repr.{{ c }}
                {%- endfor %}
            ));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }}? Inverse() {
            var lengthSquared = UncheckedLengthSquared();
            if (lengthSquared == {{ wide_component_u }}.Zero) {
                return null;
            }
            var conjugate = Conjugate();
            return new QuaternionI2F30(conjugate.Vector / I2F30.UncheckedLossyFrom(lengthSquared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component }} UncheckedDot({{ quaternion }} other) {
            return {{ wide_component }}.FromBits(Repr.Dot(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component_u }} UncheckedLengthSquared() {
            return {{ wide_component_u }}.FromBits(Repr.UncheckedLengthSquared());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} UncheckedLength() {
            return {{ component_u }}.FromBits(Repr.UncheckedLength());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }}? Normalize() {
            var tmp = {{ vector_4 }}.Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new {{ quaternion }}(tmp.Value);
        }
        #endregion
        #region UncheckedLerp, UncheckedSlerp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ quaternion }} UncheckedLerp({{ quaternion }} other, {{ time }} t) {
            var a = Repr.BigMul(({{ time }}.One - t).Bits);
            var b = other.Repr.BigMul(t.Bits);
            var dot = UncheckedDot(other);
            a = (dot.Bits < 0) ? (a - b) : (a + b);
            var q = new {{ quaternion }}(({{ repr }})(a / {{ time }}.OneRepr));
            return q.Normalize().Value;
        }

        public {{ quaternion }} UncheckedSlerp({{ quaternion }} other, {{ time }} t) {
            var dot = UncheckedDot(other);
            if (dot.Bits < 0) {
                dot = -dot;
                other.Repr = -other.Repr;
            }

            // この値を変えると再現性が失われる他,
            // オーバーフローを引き起こす場合がある.
            // (invSin が 32 以上になる場合があるため)
            const {{ wide_bits }} threshold = {{ wide_component }}.OneRepr / 2000;

            if (dot.Bits < {{ wide_component }}.OneRepr - threshold) {
                // ドット積の小数部の精度を {{ 2*frac_nbits }} から {{ int_nbits+frac_nbits-1 }} に変える.
                {%- set s = frac_nbits - int_nbits + 1 %}
                var d = {{ macros::fixed_type(s=false, i=int_nbits+frac_nbits+1, f=int_nbits+frac_nbits-1)
                }}.FromBits(({{ wide_bits_u }})dot.Bits
                    {%-   if s > 0 %} >> {{     s }}
                    {%- elif s < 0 %} << {{ 0 - s }}
                    {%- endif -%}
                );

                // ドット積の Arccos を計算する.
                // その後, 後の計算のために小数部の精度を {{ (int_nbits+frac_nbits-2)/2 }} ビットにする.
                {#- 32 ビットのクォータニオンには AcosP3(long) を,
                    64 ビットのクォータニオンには AcosP7(Int128) を使用する. #}
                var angle = {{
                    macros::fixed_type(s=true, i=(int_nbits+frac_nbits)/2 + 1, f=(int_nbits+frac_nbits)/2 - 1)
                }}.LossyFrom({{
                    macros::fixed_type(s=true, i=int_nbits+frac_nbits+1, f=int_nbits+frac_nbits-1)
                }}.AcosP{%
                    if   int_nbits + frac_nbits == 32 %}3{%
                    elif int_nbits + frac_nbits == 64 %}7{%
                    else %}{{ throw(message='unimplemented') }}{%
                    endif %}(({{ wide_bits }})d.Bits));

                // 閾値が 0.0005 の場合 invSin の最大値は
                // (1 - (1-0.0005)^2)^(-0.5)=31.6267301900746 となる.
                // 後の計算のために invSin の小数部のビット数が {{ int_nbits+frac_nbits }} ビットとなるように調製する.
                {{ wide_bits_u }} invSin;
                {
                    var tmp = ({{ wide_one_u }} << {{ 2*(int_nbits+frac_nbits  - 1) }}) - (d.Bits * d.Bits);
                    invSin = ({{  wide_one_u }} << {{ 2*(int_nbits+frac_nbits) - 1  }}) / Mathi.Sqrt(tmp);
                }

                // w1, w2 の範囲は [0, 1] である.
                // {{ frac_nbits }} ビットの小数部を持つ Repr/other.Repr と乗算した時
                // 2 ビットの整数部と {{ 2*(int_nbits+frac_nbits-1) }} ビットの小数部を持つよう
                // {{ 2*int_nbits - 2 + frac_nbits }} ビットの小数部を持たせる.
                {{ wide_bits_u }} w1, w2;
                {
                    w1 = (invSin * ({{ wide_bits_u }})(angle * ({{ time }}.One - t)).SinP5().Bits) >> {{ int_nbits+frac_nbits-2 }};
                    w2 = (invSin * ({{ wide_bits_u }})(angle * t).SinP5().Bits) >> {{ int_nbits+frac_nbits-2 }};
                }

                // 最後に足し合わせて終わり
                {
                    var a = ({{ wide_bits }})w1 * ({{ wide_repr }})Repr;
                    var b = ({{ wide_bits }})w2 * ({{ wide_repr }})other.Repr;
                    var q = (a + b) / ({{ wide_one }} << {{ 2*int_nbits + frac_nbits - 2 }});
                    return new {{ quaternion }}(new {{ repr }}(
                        {% for c in components -%}
                        ({{ bits }})q.{{ c }}{% if not loop.last %}, {% endif %}
                        {%- endfor %}
                    ));
                }
            }
            return UncheckedLerp(other, t);
        }
        #endregion
        #region AxisAngle

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static {{ quaternion }} AxisAngle({{ vector_3 }} axis, {{ component }} sin, {{ component }} cos) {
            return new {{ quaternion }}(axis * sin, cos);
        }

        {%- for p in sin %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} AxisAngleP{{ p }}({{ vector_3 }} axis, {{ angle }} angle) {
            var half = angle.Half();
            var s = half.SinP{{ p }}();
            var c = half.CosP{{ p }}();
            return AxisAngle(axis, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} AxisAngleP{{ p }}(
            {{ component }} axisX, {{ component }} axisY, {{ component }} axisZ, {{ angle }} angle
        ) => AxisAngleP{{ p }}(new {{ vector_3 }}(axisX, axisY, axisZ), angle);
        {%- endfor %}
        #endregion
        #region Euler

        {%- for p in sin %}
        {%- for order in ["Xyz", "Xzy", "Yxz", "Yzx", "Zxy", "Zyx"] %}
        {%- if   order == "Xyz" %}{%- set s = ['-', '+', '-', '+'] %}
        {%- elif order == "Xzy" %}{%- set s = ['+', '+', '-', '-'] %}
        {%- elif order == "Yxz" %}{%- set s = ['-', '+', '+', '-'] %}
        {%- elif order == "Yzx" %}{%- set s = ['-', '-', '+', '+'] %}
        {%- elif order == "Zxy" %}{%- set s = ['+', '-', '-', '+'] %}
        {%- elif order == "Zyx" %}{%- set s = ['+', '-', '+', '-'] %}
        {%- else %}{{ throw(message="Unknown order") }}{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} Euler{{ order }}P{{ p }}({{ angles }} xyz) {
            {{ wide_bits }} sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP{{ p }}();
                var c = half.CosP{{ p }}();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const {{ bits }} k = 1 << ({{ frac_nbits }} - ((({{ int_nbits + frac_nbits }} * 2) - 2) / 3));

                sx = s.X.Bits / k;
                sy = s.Y.Bits / k;
                sz = s.Z.Bits / k;
                cx = c.X.Bits / k;
                cy = c.Y.Bits / k;
                cz = c.Z.Bits / k;
            }

            {
                var x = (sx * cy * cz) {{ s[0] }} (sy * sz * cx);
                var y = (sy * cz * cx) {{ s[1] }} (sz * sx * cy);
                var z = (sz * cx * cy) {{ s[2] }} (sx * sy * cz);
                var w = (cx * cy * cz) {{ s[3] }} (sy * sz * sx);

                const {{ wide_bits }} k = 1L << (((({{ int_nbits + frac_nbits }} * 2) - 2) / 3 * 3) - {{ frac_nbits }});
                return new {{ quaternion }}(
                    {{ component }}.FromBits(({{ bits }})(x / k)),
                    {{ component }}.FromBits(({{ bits }})(y / k)),
                    {{ component }}.FromBits(({{ bits }})(z / k)),
                    {{ component }}.FromBits(({{ bits }})(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} Euler{{ order }}P{{ p }}(
            {{ angle }} x, {{ angle }} y, {{ angle }} z
        ) => Euler{{ order }}P{{ p }}(new {{ angles }}(x, y, z));
        {%- endfor %}
        {%- endfor %}
        #endregion
        #region Rotate X/Y/Z

        {%- for p in sin %}
        {%- for i in range(end=3) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ quaternion }} Rotate{{ components[i] }}P{{ p }}({{ angle }} angle) {
            var half = angle.Half();
            var s = half.SinP{{ p }}();
            var c = half.CosP{{ p }}();
            return new {{ quaternion }}(
                {%- for j in range(end=3) %}
                    {%- if i == j -%}
                        s
                    {%- else -%}
                        {{ component}}.Zero
                    {%- endif -%}
                    , {# #}
                {%- endfor -%}
                c);
        }
        {%- endfor %}
        {%- endfor %}
        #endregion
    }
} // namespace {{ namespace }}
