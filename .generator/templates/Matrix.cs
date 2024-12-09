{% import "macros.cs" as macros %}
{%- set bits = int_nbits + frac_nbits %}
{%- set repr   = macros::vector_primitive(signed=true, dim=rows, bits=bits) %}
{%- set repr_3 = macros::vector_primitive(signed=true, dim=3,    bits=bits) %}
{%- set repr_4 = macros::vector_primitive(signed=true, dim=4,    bits=bits) %}
{%- set component = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set col = macros::vector_type(dim=rows, type=component) %}
{%- set row = macros::vector_type(dim=cols, type=component) %}
{%- set col_repr = macros::vector_primitive(signed=true, dim=rows, bits=bits) %}
{%- set row_repr = macros::vector_primitive(signed=true, dim=cols, bits=bits) %}
{%- if signed %}{%- set type = 'Matrix' ~ rows ~ 'x' ~ cols ~ 'I' ~ int_nbits ~ 'F' ~ frac_nbits %}
{%- else %}     {%- set type = 'Matrix' ~ rows ~ 'x' ~ cols ~ 'U' ~ int_nbits ~ 'F' ~ frac_nbits %}
{%- endif %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set vector_3 = macros::vector_type(dim=3, type=component) %}
{%- set vector_4 = macros::vector_type(dim=4, type=component) %}
{%- set angle = macros::fixed_type(s=true, i=bits/2 + 1, f=bits/2 - 1) %}
{%- set one = macros::one(signed=signed, bits=bits) %}
{%- if rows == 3 and cols == 3 and signed and int_nbits == 2 %}
    {%- set quaternion = macros::quaternion(i=int_nbits, f=frac_nbits) %}
{%- endif -%}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct {{ type }} : IEquatable<{{ type }}> {
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
        public {{ repr }} C{{ i }}Repr;
        {%- endfor %}
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(
            {%- for i in range(end=cols) -%}
            {{ repr }} c{{ i }}Repr{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        ) {
            {%- for i in range(end=cols) %}
            C{{ i }}Repr = c{{ i }}Repr;
            {%- endfor %}
        }
        #endregion
        #region Properties
        {%- for i in range(end=cols) %}
        public {{ col }} C{{ i }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ col }}(C{{ i }}Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C{{ i }}Repr = value.Repr;
        }
        {%- endfor %}
        {%- for i in range(end=rows) %}
        public {{ row }} R{{ i }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ row }}(new {{ row_repr }}(
                {%- for j in range(end=cols) -%}
                C{{ j }}Repr.{{ components[i] }}{%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            ));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                {%- for j in range(end=cols) %}
                C{{ j }}Repr.{{ components[i] }} = value.Repr.{{ components[j] }};
                {%- endfor %}
            }
        }
        {%- endfor %}
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is {{ type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            {%- for i in range(end=cols) -%}
            C{{ i }}Repr{%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        );
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) =>
            {%- for i in range(end=cols) %}
            C{{ i }}Repr.Equals(other.C{{ i }}Repr){%- if not loop.last %} &&{% endif %}
            {%- endfor %};
        #endregion
        {%- if rows == 3 and cols == 3 and signed and int_nbits == 2 %}
        #region Conversion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static operator {{ type }}({{ quaternion}} q) {
            var xx = ({{ wide_bits }})q.Repr.X * q.Repr.X;
            var yy = ({{ wide_bits }})q.Repr.Y * q.Repr.Y;
            var zz = ({{ wide_bits }})q.Repr.Z * q.Repr.Z;

            var xy = ({{ wide_bits }})q.Repr.X * q.Repr.Y;
            var wz = ({{ wide_bits }})q.Repr.Z * q.Repr.W;
            var xz = ({{ wide_bits }})q.Repr.Z * q.Repr.X;
            var wy = ({{ wide_bits }})q.Repr.Y * q.Repr.W;
            var yz = ({{ wide_bits }})q.Repr.Y * q.Repr.Z;
            var wx = ({{ wide_bits }})q.Repr.X * q.Repr.W;

            result.X = new {{ repr }}(
                ({{ bits }})(({{ wide_component }}.OneRepr - 2 * (yy + zz)) / ({{ component }}.OneRepr)),
                1.0f - 2.0f * (yy + zz),
                2.0f * (xy + wz),
                2.0f * (xz - wy),
            );
            result.Y = Vector4.Create(
                2.0f * (xy - wz),
                1.0f - 2.0f * (zz + xx),
                2.0f * (yz + wx),
            );
            result.Z = Vector4.Create(
                2.0f * (xz + wy),
                2.0f * (yz - wx),
                1.0f - 2.0f * (yy + xx),
            );

            return result;
        }
        #endregion
        #region AxisAngle
        {%- for o in [2, 3, 4, 5] %}

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
        {%- endif %}
    }
} // namespace {{ namespace }}
