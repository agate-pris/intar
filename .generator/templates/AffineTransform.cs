{% import "macros.cs" as macros %}
{%- set type = 'AffineTransformI' ~ int_nbits ~ 'F' ~ frac_nbits %}
{%- set component = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set rotation = macros::quaternion(i=int_nbits-frac_nbits, f=2*frac_nbits) %}
{%- set rotation_scale = 'Matrix3x3I' ~ int_nbits ~ 'F' ~ frac_nbits %}
{%- set translation = macros::vector_type(dim=3, type=component) %}
{#- -#}
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
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *({{ type }} left, {{ type }} right) {
            return new {{ type }}(
                left.RotationScale * right.RotationScale,
                left.RotationScale * right.Translation + left.Translation
            );
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ translation }} operator *({{ type }} left, {{ translation }} right) {
            return left.RotationScale * right + left.Translation;
        }
        #endregion
        #region TRS
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} TRS({{ translation }} translation, {{ rotation }} rotation, {{ translation }} scale) {
            throw new NotImplementedException();
        }
        #endregion
    }
} // namespace {{ namespace }}
