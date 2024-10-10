{%- set sin_methods = ["P2", "P3A16384", "P4A7032", "P4A7384", "P5A51472", "P5A51437"] -%}

using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER

using UnityEngine;

#endif

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct QuaternionI17F15 : IEquatable<QuaternionI17F15>, IFormattable {

        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4I17F15 IJKW;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Properties
        // ---------------------------------------

        {%- set i=['I', 'X'] %}
        {%- set j=['J', 'Y'] %}
        {%- set k=['K', 'Z'] %}
        {%- set w=['W', 'W'] %}
        {%- for c in [i, j, k, w] %}
        public I17F15 {{ c[0] }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.{{ c[1] }};
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => IJKW.{{ c[1] }} = value;
        }
        {%- endfor %}

        public Vector3I17F15 Imag {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.XYZ();
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => {
                IJKW.x = value.x;
                IJKW.y = value.y;
                IJKW.z = value.z;
            }
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(Vector4I17F15 ijkw) => IJKW = ijkw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(I17F15 w, I17F15 i, I17F15 j, I17F15 k)
            : this(new Vector4I17F15(i, j, k, w)) { }

        // Static Properties
        // ---------------------------------------

        public static QuaternionI17F15 Identity {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new QuaternionI17F15(Vector4I17F15.UnitW);
        }

        // Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(QuaternionI17F15 left, QuaternionI17F15 right) => left.Equals(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(QuaternionI17F15 left, QuaternionI17F15 right) => !(left == right);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is QuaternionI17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(I, J, K, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"{{ "{{W:{W} I:{I} J:{J} K:{K}}}" }}";

        // IEquatable<QuaternionI17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(QuaternionI17F15 other) => IJKW.Equals(other.IJKW);

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var i = I.ToString(format, formatProvider);
            var j = J.ToString(format, formatProvider);
            var k = K.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"{{ "{{W:{w} I:{i} J:{j} K:{k}}}" }}";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15 Normalize() => throw new NotImplementedException();

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
        public QuaternionI17F15 Conjugate() => new QuaternionI17F15(
            -IJKW.X,
            -IJKW.Y,
            -IJKW.Z,
            IJKW.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static QuaternionI17F15 AxisAngle(int axisX, int axisY, int axisZ, I2F30 sin, I2F30 cos) {
            I17F15 x, y, z;
            {
                var b0 = axisX < 0;
                var b1 = axisY < 0;
                var b2 = axisZ < 0;
                var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(axisX) : axisX));
                var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(axisY) : axisY));
                var a2 = unchecked((uint)(b2 ? Overflowing.WrappingNeg(axisZ) : axisZ));
                var max = a0.Max(a1).Max(a2);
                if (max == 0) {
                    return Identity;
                }

                ulong m = uint.MaxValue / max;
                var l0 = m * a0;
                var l1 = m * a1;
                var l2 = m * a2;
                var sum =
                    (l0 * l0 / 4) +
                    (l1 * l1 / 4) +
                    (l2 * l2 / 4);
                var ll = Mathi.Sqrt(sum);

                var denominator = (long)ll << 16;
                var y0 = (int)((long)l0 * sin.Bits / denominator);
                var y1 = (int)((long)l1 * sin.Bits / denominator);
                var y2 = (int)((long)l2 * sin.Bits / denominator);

                x = I17F15.FromBits(b0 ? -y0 : y0);
                y = I17F15.FromBits(b1 ? -y1 : y1);
                z = I17F15.FromBits(b2 ? -y2 : y2);
            }

            I17F15 w;
            {
                const int k = 1 << 15;
                w = I17F15.FromBits(cos.Bits / k);
            }

            return new QuaternionI17F15(x, y, z, w);
        }

        {%- for p in [2, 3, 4, 5] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP{{ p }}(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP{{ p }}();
            var c = half.CosP{{ p }}();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP{{ p }}(Vector3Int axis, I17F15 angle) {
            return AxisAngle{{ p }}(axis.x, axis.y, axis.z, angle);
        }

#endif

        {%- endfor %}

        {%- for p in [2, 3, 4, 5] %}
        {%- for order in ["Xyz", "Xzy", "Yxz", "Yzx", "Zxy", "Zyx"] %}
        {%- if   order == "Xyz" %}{%- set s = ['-', '+', '-', '+'] %}
        {%- elif order == "Xzy" %}{%- set s = ['+', '+', '-', '-'] %}
        {%- elif order == "Yxz" %}{%- set s = ['-', '+', '+', '-'] %}
        {%- elif order == "Yzx" %}{%- set s = ['-', '-', '+', '+'] %}
        {%- elif order == "Zxy" %}{%- set s = ['+', '-', '-', '+'] %}
        {%- elif order == "Zyx" %}{%- set s = ['+', '-', '+', '-'] %}
        {%- else %}{{ throw(message="Unknown order") }}{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 Euler{{ order }}P{{ p }}(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP{{ p }}();
                var c = half.CosP{{ p }}();
                const int k = 1 << 10;

                // Convert to 44 integer bits and 20 fractional bits.
                // It is commutative about the order of the multiplication
                // while ensuring maximum precision.
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

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 Euler{{ order }}P{{ p }}(
            I17F15 x, I17F15 y, I17F15 z
        ) => Euler{{ order }}P{{ p }}(new Vector3I17F15(x, y, z));

        {%- endfor %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP{{ p }}(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP{{ p }}(xyz);
                case RotationOrder.XZY: return EulerXzyP{{ p }}(xyz);
                case RotationOrder.YXZ: return EulerYxzP{{ p }}(xyz);
                case RotationOrder.YZX: return EulerYzxP{{ p }}(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP{{ p }}(xyz);
                case RotationOrder.ZYX: return EulerZyxP{{ p }}(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP{{ p }}(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP{{ p }}(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP{{ p }}(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP{{ p }}();
            var c = (I17F15)half.CosP{{ p }}();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP{{ p }}(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP{{ p }}();
            var c = (I17F15)half.CosP{{ p }}();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP{{ p }}(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP{{ p }}();
            var c = (I17F15)half.CosP{{ p }}();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        {%- endfor %}

    }
}
