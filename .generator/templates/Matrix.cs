{%- set self_type = "Matrix" ~ row ~ "x" ~ column ~ self_fixed_type -%}
{%- set self_vector_type = "Vector" ~ row ~ self_fixed_type -%}
{%- set self_rows = row -%}
{%- set self_columns = column -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}> {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
{% for i in range(end=column) %}
        public {{ self_vector_type }} C{{ loop.index0 }};
{%- endfor %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}(
{%- for i in range(end=column) %}
            {{ self_vector_type }} c{{ loop.index0 }}
            {%- if not loop.last %},{% endif %}
{%- endfor %}
        ) {
{%- for i in range(end=column) %}
            C{{ loop.index0 }} = c{{ loop.index0 }};
{%- endfor %}
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} left, {{ self_type }} right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} left, {{ self_type }} right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
{%- for i in range(end=column) -%}
            C{{ loop.index0 }}
            {%- if not loop.last %}, {% endif %}
{%- endfor -%}
        );

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other) =>
{%- for i in range(end=column) %}
            C{{ loop.index0 }} == other.C{{ loop.index0 }}
            {%- if loop.last %};{% else %} &&{% endif %}
{%- endfor -%}

        {%- if row == 4 and column == 4 and self_fixed_type == "I17F15" %}
        {#- 現時点ではメソッドは TRS のみなので､ コメントは条件の内側に入れる #}

        // Methods
        // ---------------------------------------

        /// Prerequisite: q is normalized (to prevent overflow)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4I17F15 TRS(
            Vector3I17F15 translation, QuaternionI17F15 rotation, Vector3I17F15 scale
        ) {
            var v = rotation.XYZW;
            var vXNeg = -rotation.X;
            var vYNeg = -rotation.Y;
            var vZNeg = -rotation.Z;
            var vWNeg = -rotation.W;
            var v2 = v.Twice();
            var c0 = Vector3I17F15.UnitX + (v2.Y * new Vector3I17F15(vYNeg, v.X, vWNeg)) - (v2.Z * new Vector3I17F15(v.Z, vWNeg, vXNeg));
            var c1 = Vector3I17F15.UnitY + (v2.Z * new Vector3I17F15(vWNeg, vZNeg, v.Y)) - (v2.X * new Vector3I17F15(vYNeg, v.X, vWNeg));
            var c2 = Vector3I17F15.UnitZ + (v2.X * new Vector3I17F15(v.Z, vWNeg, vXNeg)) - (v2.Y * new Vector3I17F15(vWNeg, vZNeg, v.Y));
            return new Matrix4x4I17F15(
                new Vector4I17F15(c0.SaturatingMul(scale.X), I17F15.Zero),
                new Vector4I17F15(c1.SaturatingMul(scale.Y), I17F15.Zero),
                new Vector4I17F15(c2.SaturatingMul(scale.Z), I17F15.Zero),
                new Vector4I17F15(translation, I17F15.One));
        }

        {%- endif %}

    }
}
