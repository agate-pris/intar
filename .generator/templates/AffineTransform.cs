{% import "macros.cs" as macros %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
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
        #region Fields
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator System.Numerics.Matrix4x4({{ type }} a) {
            return new System.Numerics.Matrix4x4(
                {%- for i in range(end=dim) %}
                {% for j in range(end=dim) -%}
                a.RotationScale.C{{ i }}.{{ components[j] }}.LossyToSingle(), {# #}
                {%- endfor -%}0,
                {%- endfor %}
                {% for i in range(end=dim) -%}
                a.Translation.{{ components[i] }}.LossyToSingle(), {# #}
                {%- endfor %}1
            );
        }

#if UNITY_5_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Matrix4x4({{ type }} a) {
            return new UnityEngine.Matrix4x4(
                {%- for i in range(end=dim) %}
                new UnityEngine.Vector4(
                {%- for j in range(end=dim) -%}
                a.RotationScale.C{{ i }}.{{ components[j] }}.LossyToSingle(), {# #}
                {%- endfor -%}0),
                {%- endfor %}
                new UnityEngine.Vector4(
                {%- for i in range(end=dim) -%}
                a.Translation.{{ components[i] }}.LossyToSingle(), {# #}
                {%- endfor %}1)
            );
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float4x4({{ type }} a) {
            return new Unity.Mathematics.float4x4(
                {%- for i in range(end=dim) %}
                {% for j in range(end=dim) -%}
                a.RotationScale.C{{ j }}.{{ components[i] }}.LossyToSingle(), {# #}
                {%- endfor -%}
                a.Translation.{{ components[i] }}.LossyToSingle(),
                {%- endfor %}
                0, 0, 0, 1
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ type }} left, {{ type }} right) {
            return new {{ type }}(
                left.RotationScale * right.RotationScale,
                left.RotationScale * right.Translation + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ translation }} operator *({{ type }} left, {{ translation }} right) {
            return left.RotationScale * right + left.Translation;
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Trs({{ translation }} translation, {{ rotation }} rotation, {{ translation }} scale) {
            // クォータニオンから行列への変換時
            // 内部的に long を経由するが,
            // 小数部の精度が大きいまま更にスケールを乗算すると
            // オーバーフローを引き起こすため,
            // 素直に一度小数部の精度を減らしてから乗算する.
            var r = ({{ macros::matrix_type(r=dim, c=dim, type=macros::fixed_type(s=true, i=2, f=2*frac_nbits)) }})rotation;
            {%- for i in range(end=dim) %}
            var c{{ i }} = new {{ translation }}((Vector3Int{{ bits }})(r.C{{ i }}.Repr.BigMul(scale.Repr.{{ components[i] }}) / (1 << {{ 2 * frac_nbits }})));
            {%- endfor %}
            return new {{ type }}(new {{ rotation_scale }}(c0, c1, c2), translation);
        }
        #endregion
        #region DecomposeScale
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ translation }} DecomposeScale() => new {{ translation }}(
            {%- for i in range(end=dim) %}
            {{ component }}.UncheckedFrom(RotationScale.C{{ i }}.Length()){% if not loop.last %},{% endif %}
            {%- endfor %}
        );
        #endregion
    }
} // namespace {{ namespace }}
