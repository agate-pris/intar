{% import "macros.cs" as macros %}
{%- set int_nbits  = 17 %}
{%- set frac_nbits = 15 %}
{%- set component   = macros::fixed_type(s=true,  i=int_nbits, f=frac_nbits) %}
{%- set component_u = macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) %}
{%- set bits = int_nbits+frac_nbits %}
{%- set bits_type = macros::inttype(signed=true, bits=bits) %}
{%- set dim = 2 %}
{%- set vector = macros::vector_type(dim=dim, type=component) %}
{%- set vector_repr = 'Vector' ~ dim ~ 'Int' ~ bits %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- if dim == 2 %}
{%- set circle_type = 'Circle' ~ component %}{% elif dim == 3 %}
{%- set circle_type = 'Sphere' ~ component %}{% else %}
{{- throw(message='not implemented') }}
{%- endif %}
{%- set segment_type = 'Segment' ~ dim ~ component %}
{%- set type = 'Aabb' ~ dim ~ component -%}
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    public struct {{ type }} {
        #region min, max
        {{ vector }} min;
        {{ vector }} max;
        #endregion
        #region Min, Max
        public {{ vector }} Min {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => min;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                min = value;
                max = max.Max(value);
            }
        }
        public {{ vector }} Max {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                max = value;
                min = min.Min(value);
            }
        }
        #endregion
        {%- for c in components %}
        #region Min{{ c }}, Max{{ c }}
        public {{ component }} Min{{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => min.{{ c }};
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                min.{{ c }} = value;
                max.{{ c }} = max.{{ c }}.Max(value);
            }
        }
        public {{ component }} Max{{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.{{ c }};
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                max.{{ c }} = value;
                min.{{ c }} = min.{{ c }}.Min(value);
            }
        }
        #endregion
        {%- endfor %}
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ type }}({{ vector }} min, {{ vector }} max) {
            this.min = min;
            this.max = max;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}({{ vector }} p) {
            min = p;
            max = p;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(Geometry.{{ circle_type }} circle)
            : this(
                circle.Center - ({{ component }})circle.Radius,
                circle.Center + ({{ component }})circle.Radius
            ) { }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(Geometry.{{ segment_type }} segment) {
            {%- for c in components %}
            {{ component }} min{{ c }}, max{{ c }};
            if (segment.P1.{{ c }} < segment.P2.{{ c }}) {
                min{{ c }} = segment.P1.{{ c }};
                max{{ c }} = segment.P2.{{ c }};
            } else {
                min{{ c }} = segment.P2.{{ c }};
                max{{ c }} = segment.P1.{{ c }};
            }
            {%- endfor %}
            min = new {{ vector }}(
                {%- for c in components -%}
                min{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
            max = new {{ vector }}(
                {%- for c in components -%}
                max{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        #endregion
        {%- for com in components %}
        #region Encapsulate{{ com }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate{{ com }}({{ component }} v) {
            if (v < min.{{ com }}) {
                min.{{ com }} = v;
            } else if (v > max.{{ com }}) {
                max.{{ com }} = v;
            }
        }
        #endregion
        {%- endfor %}
        #region Encapsulate
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate({{ type }} other) {
            min = min.Min(other.min);
            max = max.Max(other.max);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate({{ vector }} p) {
            {%- for c in components %}
            if (p.{{ c }} < min.{{ c }}) {
                min.{{ c }} = p.{{ c }};
            } else if (p.{{ c }} > max.{{ c }}) {
                max.{{ c }} = p.{{ c }};
            }
            {%- endfor %}
        }
        #endregion
        #region Intersects
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ vector }} p) {
            {%- for c in components %}
            if (p.{{ c }} < min.{{ c }} || max.{{ c }} < p.{{ c }}) { return false; }
            {%- endfor %}
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ type }} other) {
            {%- for c in components %}
            if (max.{{ c }} < other.min.{{ c }} || other.max.{{ c }} < min.{{ c }}) { return false; }
            {%- endfor %}
            return true;
        }
        #endregion
        #region Overlaps
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ vector }} p) {
            {%- for c in components %}
            if (p.{{ c }} <= min.{{ c }} || max.{{ c }} <= p.{{ c }}) { return false; }
            {%- endfor %}
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ type }} other) {
            {%- for c in components %}
            if (max.{{ c }} <= other.min.{{ c }} || other.max.{{ c }} <= min.{{ c }}) { return false; }
            {%- endfor %}
            return true;
        }
        #endregion
    }
} // namespace {{ namespace }}
