{% import "macros.cs" as macros %}
{%- set component   = macros::fixed_type(s=true,  i=int_nbits, f=frac_nbits) %}
{%- set component_u = macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) %}
{%- set rotation = macros::quaternion(i=int_nbits-frac_nbits, f=2*frac_nbits) %}
{%- set rotation_scale = macros::matrix_type(r=dim, c=dim, type=component) %}
{%- set translation = macros::vector_type(dim=dim, type=component) %}
{%- set bits = int_nbits + frac_nbits %}
{%- set components = ['X', 'Y', 'Z', 'W'] %}
{%- set type = 'AffineTransform' ~ dim ~ component -%}
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
        #region RotationScale, Translation

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ rotation_scale }} RotationScale;
        public {{ translation }} Translation;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Constructors
        public {{ type }}({{ rotation_scale }} rotationScale, {{ translation }} translation) {
            RotationScale = rotationScale;
            Translation = translation;
        }
        #endregion
        #region IEquatable
        public bool Equals({{ type }} other) {
            return RotationScale.Equals(other.RotationScale) && Translation.Equals(other.Translation);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is {{ type }} o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            RotationScale, Translation
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{ '{{' }}RotationScale:{RotationScale} Translation:{Translation}{{ '}}' }}";
        }
        #endregion
        #region IFormattable
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ '{{' }}RotationScale:{RotationScale.ToString(format, formatProvider)} Translation:{Translation.ToString(format, formatProvider)}{{ '}}' }}";
        }
        #endregion
        #region Conversions
        {%- if dim == 3 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator System.Numerics.Matrix4x4({{ type }} a) {
            return new System.Numerics.Matrix4x4(
                {%- for i in range(end=dim) %}
                {% for j in range(end=dim) -%}
                (float)a.RotationScale.C{{ i }}.{{ components[j] }}, {# #}
                {%- endfor -%}0,
                {%- endfor %}
                {% for i in range(end=dim) -%}
                (float)a.Translation.{{ components[i] }}, {# #}
                {%- endfor %}1
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ type }}(System.Numerics.Matrix4x4 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                {%- for i in range(end=dim) %}
                a.M{{ i+1 }}4 == 0 &&
                {%- endfor %}
                a.M44 == 1
            );

#endif // UNITY_ASSERTIONS

            return new {{ type }}(
                new {{ rotation_scale }}(
                    {%- for i in range(end=dim) %}
                    new {{ translation }}(
                        {%- for j in range(end=dim) -%}
                        ({{ component }})a.M{{ i+1 }}{{ j+1 }}{% if not loop.last %}, {% endif %}
                        {%- endfor -%}
                    ){% if not loop.last %},{% endif %}
                    {%- endfor %}
                ),
                new {{ translation }}(
                    {%- for i in range(end=dim) -%}
                    ({{ component }})a.M4{{ i+1 }}{%- if not loop.last %}, {% endif %}
                    {%- endfor -%}
                )
            );
        }

#if UNITY_5_3_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Matrix4x4({{ type }} a) {
            return new UnityEngine.Matrix4x4(
                {%- for i in range(end=dim) %}
                new UnityEngine.Vector4(
                {%- for j in range(end=dim) -%}
                (float)a.RotationScale.C{{ i }}.{{ components[j] }}, {# #}
                {%- endfor -%}0),
                {%- endfor %}
                new UnityEngine.Vector4(
                {%- for i in range(end=dim) -%}
                (float)a.Translation.{{ components[i] }}, {# #}
                {%- endfor %}1)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ type }}(UnityEngine.Matrix4x4 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                {%- for i in range(end=dim) %}
                a.m3{{ i }} == 0 &&
                {%- endfor %}
                a.m33 == 1
            );

#endif // UNITY_ASSERTIONS

            return new {{ type }}(
                new {{ rotation_scale }}(
                    {%- for i in range(end=dim) %}
                    new {{ translation }}(
                        {%- for j in range(end=dim) -%}
                        ({{ component }})a.m{{ j }}{{ i }}{% if not loop.last %}, {% endif %}
                        {%- endfor -%}
                    ){% if not loop.last %},{% endif %}
                    {%- endfor %}
                ),
                new {{ translation }}(
                    {%- for i in range(end=dim) -%}
                    ({{ component }})a.m{{ i }}3{%- if not loop.last %}, {% endif %}
                    {%- endfor -%}
                )
            );
        }

#endif // UNITY_5_3_OR_NEWER
        {%- endif %}

#if UNITY_2018_1_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float{{ dim+1 }}x{{ dim+1 }}({{ type }} a) {
            return new Unity.Mathematics.float{{ dim+1 }}x{{ dim+1 }}(
                {%- for i in range(end=dim) %}
                {% for j in range(end=dim) -%}
                (float)a.RotationScale.C{{ j }}.{{ components[i] }}, {# #}
                {%- endfor -%}
                (float)a.Translation.{{ components[i] }},
                {%- endfor %}
                {% for i in range(end=dim) %}0, {% endfor %}1
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ type }}(Unity.Mathematics.float{{ dim+1 }}x{{ dim+1 }} a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                {%- for i in range(end=dim) %}
                a.c{{ i }}.{{ components[dim]|lower }} == 0 &&
                {%- endfor %}
                a.c{{ dim }}.{{ components[dim]|lower }} == 1
            );

#endif // UNITY_ASSERTIONS

            return new {{ type }}(
                new {{ rotation_scale }}(
                    {%- for i in range(end=dim) %}
                    new {{ translation }}(
                        {%- for j in range(end=dim) -%}
                        ({{ component }})a.c{{ i }}.{{ components[j]|lower }}{% if not loop.last %}, {% endif %}
                        {%- endfor -%}
                    ){% if not loop.last %},{% endif %}
                    {%- endfor %}
                ),
                new {{ translation }}(
                    {%- for i in range(end=dim) -%}
                    ({{ component }})a.c{{ dim }}.{{ components[i]|lower }}{%- if not loop.last %}, {% endif %}
                    {%- endfor -%}
                )
            );
        }

#endif // UNITY_2018_1_OR_NEWER

        #endregion
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ type }} left, {{ type }} right) {
            return new {{ type }}(
                left.RotationScale * right.RotationScale,
                (left.RotationScale * right.Translation) + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ translation }} operator *({{ type }} left, {{ translation }} right) {
            return (left.RotationScale * right) + left.Translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ type }} left, {{ rotation_scale }} right) {
            return new {{ type }}(
                left.RotationScale * right, left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ rotation_scale }} left, {{ type }} right) {
            return new {{ type }}(
                left * right.RotationScale,
                left * right.Translation
            );
        }
        #endregion
        #region Trs
        {%- if dim == 3 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Trs({{ translation }} translation, {{ macros::matrix_type(r=dim, c=dim, type=macros::fixed_type(s=true, i=2, f=2*frac_nbits)) }} rotation, {{ translation }} scale) {
            {%- for i in range(end=dim) %}
            var c{{ i }} = {{ translation }}.FromRepr((Vector3Int{{ bits }})(rotation.C{{ i }}.Repr.BigMul(scale.Repr.{{ components[i] }}) / (1 << {{ 2 * frac_nbits }})));
            {%- endfor %}
            return new {{ type }}(new {{ rotation_scale }}(c0, c1, c2), translation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Trs({{ translation }} translation, {{ rotation }} rotation, {{ translation }} scale) {
            // クォータニオンから行列への変換時
            // 内部的に long を経由するが,
            // 小数部の精度が大きいまま更にスケールを乗算すると
            // オーバーフローを引き起こすため,
            // 素直に一度小数部の精度を減らしてから乗算する.
            var r = ({{ macros::matrix_type(r=dim, c=dim, type=macros::fixed_type(s=true, i=2, f=2*frac_nbits)) }})rotation;
            return Trs(translation, r, scale);
        }
        {%- elif dim == 2 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static {{ type }} Trs({{
            translation }} translation, {{
            macros::fixed_type(s=true, i=int_nbits-frac_nbits, f=2*frac_nbits) }} s, {{
            macros::fixed_type(s=true, i=int_nbits-frac_nbits, f=2*frac_nbits) }} c, {{
            translation }} scale) {
            var c0 = new Vector2Int{{ bits }}(c.Bits, s.Bits);
            var c1 = new Vector2Int{{ bits }}(-s.Bits, c.Bits);
            var rotationScale = new {{ rotation_scale }}(
                {%- for i in range(end=2) %}
                {{ translation }}.FromRepr((Vector2Int{{ bits }})(c{{ i }}.BigMul(scale.Repr.{{ components[i] }}) / (1 << {{ 2 * frac_nbits }})))
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
            return new {{ type }}(rotationScale, translation);
        }
        {%- for deg in [2, 3, 4, 5, 10, 11] %}
        {%- if bits < 64 and deg > 5 %}{% continue %}{% endif %}

        /// <summary>
        /// Create a new <see cref="{{ type }}"/> instance with the specified translation, rotation, and scale.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} TrsP{{ deg }}({{ translation }} translation, {{ component }} rotation, {{ translation }} scale) {
            var s = rotation.SinP{{ deg }}();
            var c = rotation.CosP{{ deg }}();
            return Trs(translation, s, c, scale);
        }
        {%- endfor %}
        {%- else %}
        {{ throw(message='not implemented') }}
        {%- endif %}
        #endregion
        #region {% for i in range(end=dim) %}DecomposeScale{{ components[i] }}{% if not loop.last %}, {% endif %}{% endfor %}
        {%- for i in range(end=dim) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} DecomposeScale{{ components[i] }}() => RotationScale.C{{ i }}.Length();
        {%- endfor %}
        #endregion
    }
} // namespace {{ namespace }}
