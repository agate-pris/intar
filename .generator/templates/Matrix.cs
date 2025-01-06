{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set      component_repr = macros::inttype(bits=  bits, signed=signed) %}
{%- set wide_component_repr = macros::inttype(bits=2*bits, signed=signed) %}
{%- set repr   = macros::vector_primitive(signed=true, dim=rows, bits=bits) %}
{%- set repr_3 = macros::vector_primitive(signed=true, dim=3,    bits=bits) %}
{%- set repr_4 = macros::vector_primitive(signed=true, dim=4,    bits=bits) %}
{%- set wide_repr = macros::vector_primitive(signed=true, dim=rows, bits=2*bits) %}
{%- set component      = macros::fixed_type(s=signed, i = int_nbits,   f=  frac_nbits) %}
{%- set wide_component = macros::fixed_type(s=signed, i = int_nbits*2, f=2*frac_nbits) %}
{%- set angle          = macros::fixed_type(s=true,   i = bits/2 + 1,  f=bits/2 - 1  ) %}
{%- set col      = macros::vector_type(dim=rows, type=component) %}
{%- set row      = macros::vector_type(dim=cols, type=component) %}
{%- set vector_3 = macros::vector_type(dim=3,    type=component) %}
{%- set vector_4 = macros::vector_type(dim=4,    type=component) %}
{%- set angle_3  = macros::vector_type(dim=3,    type=angle    ) %}
{%- set col_repr = macros::vector_primitive(signed=true, dim=rows, bits=bits) %}
{%- set row_repr = macros::vector_primitive(signed=true, dim=cols, bits=bits) %}
{%- set type = macros::matrix_type(r=rows, c=cols, type=component) %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set one = macros::one(signed=signed, bits=bits) %}
{%- if rows == 3 and cols == 3 and signed and int_nbits == 2 %}
    {%- set quaternion = macros::quaternion(i=int_nbits, f=frac_nbits) %}
{%- endif -%}
{%- set sin = [2, 3, 4, 5] -%}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct {{ type }} : IEquatable<{{ type }}>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        {%- for i in range(end=cols) %}
        public {{ col }} C{{ i }};
        {%- endfor %}
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ type }}(
            {%- for i in range(end=cols) -%}
            {{ repr }} c{{ i }}Repr{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        ) {
            {%- for i in range(end=cols) %}
            C{{ i }} = new {{ col }}(c{{ i }}Repr);
            {%- endfor %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(
            {%- for i in range(end=cols) -%}
            {{ col }} c{{ i }}{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        )
            : this(
            {%- for i in range(end=cols) -%}
            c{{ i }}.Repr{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        ) { }
        #endregion
        {%- if rows == cols %}
        #region Identity
        public static readonly {{ type }} Identity = new {{ type }}(
            {%- for i in range(end=cols) %}
            new {{ repr }}(
                {%- for j in range(end=rows) -%}
                {% if i == j %}{{ component }}.OneRepr{% else %}0{% endif %}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            ){% if not loop.last %},{% endif %}
            {%- endfor %}
        );
        #endregion
        {%- endif %}
        #region Zero
        public static readonly {{ type }} Zero = new {{ type }}(
            {%- for i in range(end=cols) %}
            new {{ repr }}(
                {%- for j in range(end=rows) -%}
                0{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            ){% if not loop.last %},{% endif %}
            {%- endfor %}
        );
        #endregion
        #region Properties
        {%- for i in range(end=rows) %}
        public {{ row }} R{{ i }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ row }}(new {{ row_repr }}(
                {%- for j in range(end=cols) -%}
                C{{ j }}.Repr.{{ components[i] }}{%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            ));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                {%- for j in range(end=cols) %}
                C{{ j }}.Repr.{{ components[i] }} = value.Repr.{{ components[j] }};
                {%- endfor %}
            }
        }
        {%- endfor %}
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) =>
            {%- for i in range(end=cols) %}
            C{{ i }}.Equals(other.C{{ i }}){%- if not loop.last %} &&{% endif %}
            {%- endfor %};
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is {{ type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            {%- for i in range(end=cols) -%}
            C{{ i }}{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return {{ '$"{{' }}
            {%- for r in range(end=rows) %}
            {{- ' {{' }}
            {%- for c in range(end=cols) -%}
            C{{ c }}.{{ components[r] -}}:{C{{ c }}.{{ components[r] -}} }{% if not loop.last %} {% endif %}
            {%- endfor -%}
            {{- '}}' }}
            {%- endfor %}
            {{- ' }}"' }};
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return {{ '$"{{' }}
            {%- for r in range(end=rows) %}
            {{- ' {{' }}
            {%- for c in range(end=cols) -%}
            C{{ c }}.{{ components[r] -}}:{C{{ c }}.{{ components[r] }}.ToString(format, formatProvider)}{% if not loop.last %} {% endif %}
            {%- endfor -%}
            {{- '}}' }}
            {%- endfor %}
            {{- ' }}"' }};
        }
        #endregion
        #region Conversions
        {%- if rows == 3 and cols == 2 or rows == 2 and cols == 3 %}

        // System.Numerics.Matrix3x2 への変換は
        // 行優先・列優先の違いによる混乱を防ぐため定義しない.
        {%- endif %}
        {%- if rows == 4 and cols == 4 %}

        // System.Numerics.Matrix4x4 への変換は
        // 行優先・列優先の違いによる混乱を防ぐため定義しない.

#if UNITY_5_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Matrix4x4({{ type }} a) {
            return new UnityEngine.Matrix4x4(
                {%- for i in range(end=3) %}
                new UnityEngine.Vector4(
                {%- for j in range(end=3) -%}
                (float)a.C{{ j }}.{{ components[i] }}, {# #}
                {%- endfor -%}0),
                {%- endfor %}
                new UnityEngine.Vector4(
                {%- for i in range(end=3) -%}
                (float)a.C3.{{ components[i] }}, {# #}
                {%- endfor %}1)
            );
        }
#endif // UNITY_5_3_OR_NEWER
        {%- endif %}
#if UNITY_2018_1_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float{{ rows }}x{{ cols }}({{ type }} a) {
            return new Unity.Mathematics.float{{ rows }}x{{ cols }}(
                {%- for i in range(end=rows) %}
                {% for j in range(end=cols) -%}
                (float)a.C{{ j }}.{{ components[i] }}{% if not loop.last %}, {% endif %}
                {%- endfor %}
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        {%- for o in ['+', '-'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o }}({{ type }} left, {{ type }} right) {
            return new {{ type }}(
                {%- for i in range(end=cols) %}
                left.C{{ i }} {{ o }} right.C{{ i }}{%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
        {%- endfor %}
        #endregion
        #region IMultiplyOperators
        {%- if rows != cols %}
        {{ throw(message='Matrix product for rows != cols is not implemented.') }}
        {%- endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ type }} left, {{ type }} right) {
            return new {{ type }}(
                {%- for i in range(end=cols) %}
                new {{ col }}(
                    {%- for j in range(end=rows) %}
                    ({{ component }})left.R{{ j }}.Dot(right.C{{ i }})
                    {%- if not loop.last %},{% endif %}
                    {%- endfor %}
                ){%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
        public static {{ row }} operator *({{ type }} left, {{ row }} right) {
            {%- for i in range(end=rows) %}
            var {{ components[i]|lower }} = left.R{{ i }} * right;
            {%- endfor %}
            return new {{ row }}(
                {%- for r in range(end=rows) %}
                {% for c in range(end=cols) -%}
                {{ components[r]|lower }}.{{ components[c] }}{% if not loop.last %} + {% endif %}
                {%- endfor %}
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
        #endregion
        {%- if rows == cols %}
        #region Transpose
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Transpose() {
            return new {{ type }}(
                {%- for i in range(end=cols) %}
                new {{ repr }}(
                {%- for j in range(end=rows) -%}
                C{{ j }}.Repr.{{ components[i] }}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
                ){%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
        #endregion
        {%- else %}
        {{ throw(message='Transpose for rows != cols is not implemented.') }}
        {%- endif %}
        {%- if rows == 3 and cols == 3 and signed and int_nbits == 2 %}
        #region Conversion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ type }}({{ quaternion }} q) {
            var pnn = new {{ repr_3 }}(+2, -2, -2);
            var npn = new {{ repr_3 }}(-2, +2, -2);
            var nnp = new {{ repr_3 }}(-2, -2, +2);
            return new {{ type }}(
                ({{ repr_3 }})((((q.Repr.YXW().BigMul(q.Repr.Y) * npn) - (q.Repr.ZWX().BigMul(q.Repr.Z) * pnn)) / {{ component }}.OneRepr) + {{ vector_3 }}.UnitX.Repr),
                ({{ repr_3 }})((((q.Repr.WZY().BigMul(q.Repr.Z) * nnp) - (q.Repr.YXW().BigMul(q.Repr.X) * npn)) / {{ component }}.OneRepr) + {{ vector_3 }}.UnitY.Repr),
                ({{ repr_3 }})((((q.Repr.ZWX().BigMul(q.Repr.X) * pnn) - (q.Repr.WZY().BigMul(q.Repr.Y) * nnp)) / {{ component }}.OneRepr) + {{ vector_3 }}.UnitZ.Repr)
            );
        }
        #endregion
        {%- endif %}
        {%- if rows == 3 and cols == 3 and signed and int_nbits == 2 %}
        #region Rotate X/Y/Z
        {%- for o in sin %}
        {%- for i in range(end=3) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Rotate{{ components[i] }}P{{ o }}({{ angle }} angle) {
            var s = Mathi.SinP{{ o }}(angle.Bits);
            var c = Mathi.CosP{{ o }}(angle.Bits);
            return new {{ type }}(
                {%- for r in range(end=rows) %}
                new {{ repr }}(
                {%- for c in range(end=cols) %}
                {%- if r == i and c == i %}{{ component }}.OneRepr
                {%- elif r == i or c == i %}0
                {%- elif r == c %}c
                {%- elif (c + 1) % 3 == i %}s
                {%- else %}-s
                {%- endif %}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
                ){%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }
        {%- endfor %}
        {%- endfor %}
        #endregion
        #region Euler
        {#- d (degree) #}
        {%- for d in sin %}
        {%- for order in ['Xyz', 'Xzy', 'Yxz', 'Yzx', 'Zxy', 'Zyx'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Euler{{ order }}P{{ d }}({{ angle_3 }} xyz) {
            {#- 15, 30,  60, 20 = ( 64-2)/3 #}
            {#- 31, 62, 124, 42 = (128-2)/3 #}
            var s1 = ({{ wide_repr }})xyz.SinP{{ d }}().Repr;
            var c1 = ({{ wide_repr }})xyz.CosP{{ d }}().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            {%- set shift = (bits * 2 - 2) / 3 | round(method='floor') %}
            var s2 = s1 / ({{ one }} << {{ bits - 2 - shift }});
            var c2 = c1 / ({{ one }} << {{ bits - 2 - shift }});
            var k1 = ({{ wide_component_repr }})1 << {{ bits - 2 }};
            var k2 = ({{ wide_component_repr }})1 << {{ shift * 3 - bits + 2 }};
            {%- if order == 'Xyz' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(c1.Y * c1.Z / k1),
                    ({{ component_repr }})(c1.Y * s1.Z / k1),
                    -({{ component_repr }})s1.Y),
                new {{ repr }}(
                    ({{ component_repr }})(s2.X * s2.Y * c2.Z / k2) - ({{ component_repr }})(c1.X * s1.Z / k1),
                    ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2) + ({{ component_repr }})(c1.X * c1.Z / k1),
                    ({{ component_repr }})(s1.X * c1.Y / k1)),
                new {{ repr }}(
                    ({{ component_repr }})(c2.X * s2.Y * c2.Z / k2) + ({{ component_repr }})(s1.X * s1.Z / k1),
                    ({{ component_repr }})(c2.X * s2.Y * s2.Z / k2) - ({{ component_repr }})(s1.X * c1.Z / k1),
                    ({{ component_repr }})(c1.X * c1.Y / k1)));
            {%- elif order == 'Xzy' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(c1.Y * c1.Z / k1),
                    ({{ component_repr }})s1.Z,
                    -({{ component_repr }})(s1.Y * c1.Z / k1)),
                new {{ repr }}(
                    ({{ component_repr }})(s1.X * s1.Y / k1) - ({{ component_repr }})(c2.X * c2.Y * s2.Z / k2),
                    ({{ component_repr }})(c1.X * c1.Z / k1),
                    ({{ component_repr }})(s1.X * c1.Y / k1) + ({{ component_repr }})(c2.X * s2.Y * s2.Z / k2)),
                new {{ repr }}(
                    ({{ component_repr }})(c1.X * s1.Y / k1) + ({{ component_repr }})(s2.X * c2.Y * s2.Z / k2),
                    -({{ component_repr }})(s1.X * c1.Z / k1),
                    ({{ component_repr }})(c1.X * c1.Y / k1) - ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2)));
            {%- elif order == 'Yxz' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(c1.Y * c1.Z / k1) - ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2),
                    ({{ component_repr }})(c1.Y * s1.Z / k1) + ({{ component_repr }})(s2.X * s2.Y * c2.Z / k2),
                    -({{ component_repr }})(c1.X * s1.Y / k1)),
                new {{ repr }}(
                    -({{ component_repr }})(c1.X * s1.Z / k1),
                    ({{ component_repr }})(c1.X * c1.Z / k1),
                    ({{ component_repr }})s1.X),
                new {{ repr }}(
                    ({{ component_repr }})(s1.Y * c1.Z / k1) + ({{ component_repr }})(s2.X * c2.Y * s2.Z / k2),
                    ({{ component_repr }})(s1.Y * s1.Z / k1) - ({{ component_repr }})(s2.X * c2.Y * c2.Z / k2),
                    ({{ component_repr }})(c1.X * c1.Y / k1)));
            {%- elif order == 'Yzx' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(c1.Y * c1.Z / k1),
                    ({{ component_repr }})(c2.X * c2.Y * s2.Z / k2) + ({{ component_repr }})(s1.X * s1.Y / k1),
                    ({{ component_repr }})(s2.X * c2.Y * s2.Z / k2) - ({{ component_repr }})(c1.X * s1.Y / k1)),
                new {{ repr }}(
                    -({{ component_repr }})s1.Z,
                    ({{ component_repr }})(c1.X * c1.Z / k1),
                    ({{ component_repr }})(s1.X * c1.Z / k1)),
                new {{ repr }}(
                    ({{ component_repr }})(s1.Y * c1.Z / k1),
                    ({{ component_repr }})(c2.X * s2.Y * s2.Z / k2) - ({{ component_repr }})(s1.X * c1.Y / k1),
                    ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2) + ({{ component_repr }})(c1.X * c1.Y / k1)));
            {%- elif order == 'Zxy' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2) + ({{ component_repr }})(c1.Y * c1.Z / k1),
                    ({{ component_repr }})(c1.X * s1.Z / k1),
                    ({{ component_repr }})(s2.X * c2.Y * s2.Z / k2) - ({{ component_repr }})(s1.Y * c1.Z / k1)),
                new {{ repr }}(
                    ({{ component_repr }})(s2.X * s2.Y * c2.Z / k2) - ({{ component_repr }})(c1.Y * s1.Z / k1),
                    ({{ component_repr }})(c1.X * c1.Z / k1),
                    ({{ component_repr }})(s2.X * c2.Y * c2.Z / k2) + ({{ component_repr }})(s1.Y * s1.Z / k1)),
                new {{ repr }}(
                    ({{ component_repr }})(c1.X * s1.Y / k1),
                    -({{ component_repr }})s1.X,
                    ({{ component_repr }})(c1.X * c1.Y / k1)));
            {%- elif order == 'Zyx' %}
            return new {{ type }}(
                new {{ repr }}(
                    ({{ component_repr }})(c1.Y * c1.Z / k1),
                    ({{ component_repr }})(c1.X * s1.Z / k1) + ({{ component_repr }})(s2.X * s2.Y * c2.Z / k2),
                    ({{ component_repr }})(s1.X * s1.Z / k1) - ({{ component_repr }})(c2.X * s2.Y * c2.Z / k2)),
                new {{ repr }}(
                    -({{ component_repr }})(c1.Y * s1.Z / k1),
                    ({{ component_repr }})(c1.X * c1.Z / k1) - ({{ component_repr }})(s2.X * s2.Y * s2.Z / k2),
                    ({{ component_repr }})(s1.X * c1.Z / k1) + ({{ component_repr }})(c2.X * s2.Y * s2.Z / k2)),
                new {{ repr }}(
                    ({{ component_repr }})s1.Y,
                    -({{ component_repr }})(s1.X * c1.Y / k1),
                    ({{ component_repr }})(c1.X * c1.Y / k1)));
            {%- endif %}
        }
        {%- endfor %}
        {%- endfor %}
        #endregion
        #region AxisAngle
        {%- for o in sin %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} AxisAngleP{{ o }}({{ vector_3 }} axis, {{ angle }} angle) {
            var sin = angle.SinP{{ o }}();
            var cos = angle.CosP{{ o }}();

            var perpendicularComponent = axis - (axis * cos);

            {{ vector_4 }} rotationHelper;
            {
                var xyz = axis * sin;
                rotationHelper = new {{ vector_4 }}(xyz.X, xyz.Y, xyz.Z, cos);
            }

            var ppn = new {{ repr_3 }}(+1, +1, -1);
            var npp = new {{ repr_3 }}(-1, +1, +1);
            var pnp = new {{ repr_3 }}(+1, -1, +1);

            return new {{ type }}(
                ({{ repr_3 }})((perpendicularComponent.Repr.BigMul(axis.Repr.X) / {{ component }}.OneRepr) + rotationHelper.Repr.WZY().BigMul(ppn)),
                ({{ repr_3 }})((perpendicularComponent.Repr.BigMul(axis.Repr.Y) / {{ component }}.OneRepr) + rotationHelper.Repr.ZWX().BigMul(npp)),
                ({{ repr_3 }})((perpendicularComponent.Repr.BigMul(axis.Repr.Z) / {{ component }}.OneRepr) + rotationHelper.Repr.YXW().BigMul(pnp))
            );
        }
        {%- endfor %}
        #endregion
        #region LookRotation, LookRotationSafe
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} LookRotation(
            {{- vector_3 }} forward, {{ vector_3 }} up) {
            var c0 = new {{ vector_3 }}(({{ repr }})(up.Cross(forward).Repr / {{ component }}.OneRepr)).Normalize().Value;
            var c1 = new {{ vector_3 }}(({{ repr }})(forward.Cross(c0).Repr / {{ component }}.OneRepr));
            return new {{ type }}(c0.Repr, c1.Repr, forward.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }}? LookRotationSafe(
            {{- vector_3 }} forward, {{ vector_3 }} up) {
            var f = forward.Normalize();
            var u = up.Normalize();
            if (!f.HasValue || !u.HasValue) {
                return null;
            }
            var c0 = new {{ vector_3 }}(({{ repr }})(u.Value.Cross(f.Value).Repr / {{ component }}.OneRepr)).Normalize();
            if (!c0.HasValue) {
                return null;
            }

            var c1 = new {{ vector_3 }}(({{ repr }})(f.Value.Cross(c0.Value).Repr / {{ component }}.OneRepr));
            return new {{ type }}(c0.Value.Repr, c1.Repr, f.Value.Repr);
        }
        #endregion
        {%- endif %}
    }
} // namespace {{ namespace }}
