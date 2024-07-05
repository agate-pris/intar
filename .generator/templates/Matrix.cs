{%- set self_type = "Matrix4x4" ~ self_fixed_type -%}
{%- set self_vector_type = "Vector4" ~ self_fixed_type -%}

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

        public {{ self_vector_type }} C0;
        public {{ self_vector_type }} C1;
        public {{ self_vector_type }} C2;
        public {{ self_vector_type }} C3;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}(
            {{ self_vector_type }} c0, {{ self_vector_type }} c1, {{ self_vector_type }} c2, {{ self_vector_type }} c3
        ) {
            C0 = c0;
            C1 = c1;
            C2 = c2;
            C3 = c3;
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} left, {{ self_type }} right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} left, {{ self_type }} right) => !(left == right);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(C0, C1, C2);

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self_type }} other) =>
            C0 == other.C0 &&
            C1 == other.C1 &&
            C2 == other.C2 &&
            C3 == other.C3;

    }
}
