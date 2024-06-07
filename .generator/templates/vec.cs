{% macro dim_type(dim) %}
    {{- type }}{{ dim }}
{%- endmacro -%}

{% macro self_type() %}
    {{- self::dim_type(dim = dim) }}
{%- endmacro -%}

{% if unity %}#if !UNITY_2018_3_OR_NEWER

{% endif %}using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct {{ self::self_type() }} : IEquatable<{{ self::self_type() }}>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

        public {{ type }} x;
        public {{ type }} y;{% if dim > 2 %}
        public {{ type }} z;{% endif %}{% if dim > 3 %}
        public {{ type }} w;{% endif %}

        // Constants
        // ---------------------------------------

        public static readonly {{ self::self_type() }} zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            this.x = x;
            this.y = y;{% if dim > 2 %}
            this.z = z;{% endif %}{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y, {{ self::dim_type(dim = 2) }} zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 3) }} yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy, {{ self::dim_type(dim = 2) }} zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 4) }} xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        } {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 2) }} yz{% if dim > 3 %}, {{ type }} w{% endif %}) {
            this.x = x;
            y = yz.x;
            z = yz.y;{% if dim > 3 %}
            this.w = w;{% endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 3) }} xyz{% if dim > 3 %}, {{ type }} w{% endif %}) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            x = xy.x;
            y = xy.y;{% if dim > 2 %}
            this.z = z;{% endif %}{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- endif %}

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator +({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x + b.x,
            a.y + b.y{% if dim > 2 %},
            a.z + b.z{% endif %}{% if dim > 3 %},
            a.w + b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator -({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x - b.x,
            a.y - b.y{% if dim > 2 %},
            a.z - b.z{% endif %}{% if dim > 3 %},
            a.w - b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x * b.x,
            a.y * b.y{% if dim > 2 %},
            a.z * b.z{% endif %}{% if dim > 3 %},
            a.w * b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.x * b,
            a.y * b{% if dim > 2 %},
            a.z * b{% endif %}{% if dim > 3 %},
            a.w * b{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a * b.x,
            a * b.y{% if dim > 2 %},
            a * b.z{% endif %}{% if dim > 3 %},
            a * b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x / b.x,
            a.y / b.y{% if dim > 2 %},
            a.z / b.z{% endif %}{% if dim > 3 %},
            a.w / b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.x / b,
            a.y / b{% if dim > 2 %},
            a.z / b{% endif %}{% if dim > 3 %},
            a.w / b{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a / b.x,
            a / b.y{% if dim > 2 %},
            a / b.z{% endif %}{% if dim > 3 %},
            a / b.w{% endif %});

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly {{ self::dim_type(dim = 2) }} xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(x, x); }
        public readonly {{ self::dim_type(dim = 2) }} xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(x, y); }
        public readonly {{ self::dim_type(dim = 2) }} yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(y, x); }
        public readonly {{ self::dim_type(dim = 2) }} yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(y, y); }{% if dim > 2 %}
        public readonly {{ self::dim_type(dim = 2) }} xz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(x, z); }
        public readonly {{ self::dim_type(dim = 2) }} yz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(y, z); }
        public readonly {{ self::dim_type(dim = 2) }} zx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(z, x); }
        public readonly {{ self::dim_type(dim = 2) }} zy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(z, y); }
        public readonly {{ self::dim_type(dim = 2) }} zz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(z, z); }{% endif %}{% if dim > 3 %}
        public readonly {{ self::dim_type(dim = 2) }} xw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(x, w); }
        public readonly {{ self::dim_type(dim = 2) }} yw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(y, w); }
        public readonly {{ self::dim_type(dim = 2) }} zw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(z, w); }
        public readonly {{ self::dim_type(dim = 2) }} wx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(w, x); }
        public readonly {{ self::dim_type(dim = 2) }} wy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(w, y); }
        public readonly {{ self::dim_type(dim = 2) }} wz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(w, z); }
        public readonly {{ self::dim_type(dim = 2) }} ww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}(w, w); }{% endif %}
        public readonly {{ self::dim_type(dim = 3) }} xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, x, x); }
        public readonly {{ self::dim_type(dim = 3) }} xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, x, y); }
        public readonly {{ self::dim_type(dim = 3) }} xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, y, x); }
        public readonly {{ self::dim_type(dim = 3) }} xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, y, y); }
        public readonly {{ self::dim_type(dim = 3) }} yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, x, x); }
        public readonly {{ self::dim_type(dim = 3) }} yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, x, y); }
        public readonly {{ self::dim_type(dim = 3) }} yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, y, x); }
        public readonly {{ self::dim_type(dim = 3) }} yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, y, y); }{% if dim > 2 %}
        public readonly {{ self::dim_type(dim = 3) }} xxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, x, z); }
        public readonly {{ self::dim_type(dim = 3) }} xyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, y, z); }
        public readonly {{ self::dim_type(dim = 3) }} xzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, z, x); }
        public readonly {{ self::dim_type(dim = 3) }} xzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, z, y); }
        public readonly {{ self::dim_type(dim = 3) }} xzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, z, z); }
        public readonly {{ self::dim_type(dim = 3) }} yxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, x, z); }
        public readonly {{ self::dim_type(dim = 3) }} yyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, y, z); }
        public readonly {{ self::dim_type(dim = 3) }} yzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, z, x); }
        public readonly {{ self::dim_type(dim = 3) }} yzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, z, y); }
        public readonly {{ self::dim_type(dim = 3) }} yzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, z, z); }
        public readonly {{ self::dim_type(dim = 3) }} zxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, x, x); }
        public readonly {{ self::dim_type(dim = 3) }} zxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, x, y); }
        public readonly {{ self::dim_type(dim = 3) }} zxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, x, z); }
        public readonly {{ self::dim_type(dim = 3) }} zyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, y, x); }
        public readonly {{ self::dim_type(dim = 3) }} zyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, y, y); }
        public readonly {{ self::dim_type(dim = 3) }} zyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, y, z); }
        public readonly {{ self::dim_type(dim = 3) }} zzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, z, x); }
        public readonly {{ self::dim_type(dim = 3) }} zzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, z, y); }
        public readonly {{ self::dim_type(dim = 3) }} zzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, z, z); }{% endif %}{% if dim > 3 %}
        public readonly {{ self::dim_type(dim = 3) }} xxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, x, w); }
        public readonly {{ self::dim_type(dim = 3) }} xyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, y, w); }
        public readonly {{ self::dim_type(dim = 3) }} xzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, z, w); }
        public readonly {{ self::dim_type(dim = 3) }} xwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, w, x); }
        public readonly {{ self::dim_type(dim = 3) }} xwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, w, y); }
        public readonly {{ self::dim_type(dim = 3) }} xwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, w, z); }
        public readonly {{ self::dim_type(dim = 3) }} xww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(x, w, w); }
        public readonly {{ self::dim_type(dim = 3) }} yxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, x, w); }
        public readonly {{ self::dim_type(dim = 3) }} yyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, y, w); }
        public readonly {{ self::dim_type(dim = 3) }} yzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, z, w); }
        public readonly {{ self::dim_type(dim = 3) }} ywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, w, x); }
        public readonly {{ self::dim_type(dim = 3) }} ywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, w, y); }
        public readonly {{ self::dim_type(dim = 3) }} ywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, w, z); }
        public readonly {{ self::dim_type(dim = 3) }} yww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(y, w, w); }
        public readonly {{ self::dim_type(dim = 3) }} zxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, x, w); }
        public readonly {{ self::dim_type(dim = 3) }} zyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, y, w); }
        public readonly {{ self::dim_type(dim = 3) }} zzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, z, w); }
        public readonly {{ self::dim_type(dim = 3) }} zwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, w, x); }
        public readonly {{ self::dim_type(dim = 3) }} zwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, w, y); }
        public readonly {{ self::dim_type(dim = 3) }} zwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, w, z); }
        public readonly {{ self::dim_type(dim = 3) }} zww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(z, w, w); }
        public readonly {{ self::dim_type(dim = 3) }} wxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, x, x); }
        public readonly {{ self::dim_type(dim = 3) }} wxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, x, y); }
        public readonly {{ self::dim_type(dim = 3) }} wxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, x, z); }
        public readonly {{ self::dim_type(dim = 3) }} wxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, x, w); }
        public readonly {{ self::dim_type(dim = 3) }} wyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, y, x); }
        public readonly {{ self::dim_type(dim = 3) }} wyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, y, y); }
        public readonly {{ self::dim_type(dim = 3) }} wyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, y, z); }
        public readonly {{ self::dim_type(dim = 3) }} wyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, y, w); }
        public readonly {{ self::dim_type(dim = 3) }} wzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, z, x); }
        public readonly {{ self::dim_type(dim = 3) }} wzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, z, y); }
        public readonly {{ self::dim_type(dim = 3) }} wzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, z, z); }
        public readonly {{ self::dim_type(dim = 3) }} wzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, z, w); }
        public readonly {{ self::dim_type(dim = 3) }} wwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, w, x); }
        public readonly {{ self::dim_type(dim = 3) }} wwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, w, y); }
        public readonly {{ self::dim_type(dim = 3) }} wwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, w, z); }
        public readonly {{ self::dim_type(dim = 3) }} www { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}(w, w, w); }{% endif %}
        public readonly {{ self::dim_type(dim = 4) }} xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, y, y); }{% if dim > 2 %}
        public readonly {{ self::dim_type(dim = 4) }} xxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} xxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} xxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} xxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} xxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} xyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} xyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} xyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} xyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} xyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} xzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} xzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} xzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} xzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} xzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} xzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} xzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} xzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} xzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} yxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} yxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} yxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} yxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} yxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} yyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} yyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} yyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} yyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} yyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} yzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} yzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} yzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} yzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} yzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} yzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} yzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} yzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} yzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} zxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} zxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} zxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} zxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} zxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} zxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} zxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} zxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} zxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} zyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} zyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} zyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} zyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} zyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} zyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} zyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} zyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} zyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} zzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} zzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} zzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} zzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} zzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} zzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} zzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} zzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} zzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, z, z); }{% endif %}{% if dim > 3 %}
        public readonly {{ self::dim_type(dim = 4) }} xxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} xxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} xxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} xxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} xxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} xxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} xxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, x, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} xyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} xyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} xyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} xywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} xywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} xywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} xyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, y, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} xzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} xzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} xzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} xzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} xzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} xzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} xzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, z, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} xwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} xwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} xwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} xwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} xwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} xwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} xwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} xwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} xwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} xwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} xwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} xwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} xwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} xwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} xwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} xwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(x, w, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} yxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} yxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} yxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} yxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} yxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} yxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} yxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, x, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} yyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} yyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} yyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} yywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} yywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} yywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} yyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, y, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} yzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} yzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} yzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} yzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} yzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} yzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} yzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, z, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} ywxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} ywxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} ywxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} ywxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} ywyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} ywyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} ywyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} ywyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} ywzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} ywzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} ywzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} ywzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} ywwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} ywwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} ywwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} ywww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(y, w, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} zxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} zxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} zxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} zxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} zxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} zxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} zxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, x, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} zyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} zyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} zyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} zywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} zywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} zywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} zyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, y, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} zzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} zzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} zzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} zzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} zzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} zzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} zzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, z, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} zwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} zwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} zwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} zwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} zwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} zwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} zwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} zwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} zwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} zwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} zwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} zwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} zwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} zwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} zwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} zwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(z, w, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} wxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} wxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} wxxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} wxxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} wxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} wxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} wxyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} wxyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} wxzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} wxzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} wxzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} wxzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} wxwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} wxwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} wxwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} wxww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, x, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} wyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} wyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} wyxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} wyxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} wyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} wyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} wyyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} wyyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} wyzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} wyzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} wyzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} wyzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} wywx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} wywy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} wywz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} wyww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, y, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} wzxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} wzxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} wzxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} wzxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} wzyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} wzyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} wzyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} wzyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} wzzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} wzzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} wzzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} wzzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} wzwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} wzwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} wzwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} wzww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, z, w, w); }
        public readonly {{ self::dim_type(dim = 4) }} wwxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, x, x); }
        public readonly {{ self::dim_type(dim = 4) }} wwxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, x, y); }
        public readonly {{ self::dim_type(dim = 4) }} wwxz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, x, z); }
        public readonly {{ self::dim_type(dim = 4) }} wwxw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, x, w); }
        public readonly {{ self::dim_type(dim = 4) }} wwyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, y, x); }
        public readonly {{ self::dim_type(dim = 4) }} wwyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, y, y); }
        public readonly {{ self::dim_type(dim = 4) }} wwyz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, y, z); }
        public readonly {{ self::dim_type(dim = 4) }} wwyw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, y, w); }
        public readonly {{ self::dim_type(dim = 4) }} wwzx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, z, x); }
        public readonly {{ self::dim_type(dim = 4) }} wwzy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, z, y); }
        public readonly {{ self::dim_type(dim = 4) }} wwzz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, z, z); }
        public readonly {{ self::dim_type(dim = 4) }} wwzw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, z, w); }
        public readonly {{ self::dim_type(dim = 4) }} wwwx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, w, x); }
        public readonly {{ self::dim_type(dim = 4) }} wwwy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, w, y); }
        public readonly {{ self::dim_type(dim = 4) }} wwwz { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, w, z); }
        public readonly {{ self::dim_type(dim = 4) }} wwww { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}(w, w, w, w); }{% endif %}

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is {{ self::self_type() }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{{ self::self_type() }}({x}, {y}{% if dim > 2 %}, {z}{% endif %}{% if dim > 3 %}, {w}{% endif %})";

        // IEquatable<{{ self::self_type() }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self::self_type() }} rhs)
            => rhs.x == x
            && rhs.y == y{% if dim > 2 %}
            && rhs.z == z{% endif %}{% if dim > 3 %}
            && rhs.w == w{% endif %};

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);{% if dim > 2 %}
            var z = this.z.ToString(format, formatProvider);{% endif %}{% if dim > 3 %}
            var w = this.w.ToString(format, formatProvider);{% endif %}
            return $"{{ self::self_type() }}({x}, {y}{% if dim > 2 %}, {z}{% endif %}{% if dim > 3 %}, {w}{% endif %})";
        }
    }
} {%- if unity %}

#endif{% endif %}
