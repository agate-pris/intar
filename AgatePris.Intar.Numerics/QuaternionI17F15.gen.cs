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
        public I17F15 I {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.X;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => IJKW.X = value;
        }
        public I17F15 J {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.Y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => IJKW.Y = value;
        }
        public I17F15 K {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.Z;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => IJKW.Z = value;
        }
        public I17F15 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.W;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => IJKW.W = value;
        }

        public Vector3I17F15 Imag {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IJKW.XYZ();
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                IJKW.X = value.X;
                IJKW.Y = value.Y;
                IJKW.Z = value.Z;
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
        public override string ToString() => $"{{W:{W} I:{I} J:{J} K:{K}}}";

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
            return $"{{W:{w} I:{i} J:{j} K:{k}}}";
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
        public QuaternionI17F15 Lerp(QuaternionI17F15 other, I17F15 t) {
            return new QuaternionI17F15((IJKW * (I17F15.One - t)) + (other.IJKW * t));
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP2(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP2();
            var c = half.CosP2();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP2(Vector3Int axis, I17F15 angle) {
            return AxisAngleP2(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP3(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3();
            var c = half.CosP3();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP3(Vector3Int axis, I17F15 angle) {
            return AxisAngleP3(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4();
            var c = half.CosP4();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4(Vector3Int axis, I17F15 angle) {
            return AxisAngleP4(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5();
            var c = half.CosP5();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5(Vector3Int axis, I17F15 angle) {
            return AxisAngleP5(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP2(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP2(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP2(xyz);
                case RotationOrder.XZY: return EulerXzyP2(xyz);
                case RotationOrder.YXZ: return EulerYxzP2(xyz);
                case RotationOrder.YZX: return EulerYzxP2(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP2(xyz);
                case RotationOrder.ZYX: return EulerZyxP2(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP2(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP2(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP2(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP2();
            var c = (I17F15)half.CosP2();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP2(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP2();
            var c = (I17F15)half.CosP2();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP2(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP2();
            var c = (I17F15)half.CosP2();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP3(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP3(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP3(xyz);
                case RotationOrder.XZY: return EulerXzyP3(xyz);
                case RotationOrder.YXZ: return EulerYxzP3(xyz);
                case RotationOrder.YZX: return EulerYzxP3(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP3(xyz);
                case RotationOrder.ZYX: return EulerZyxP3(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP3(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP3(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP3(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3();
            var c = (I17F15)half.CosP3();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP3(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3();
            var c = (I17F15)half.CosP3();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP3(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3();
            var c = (I17F15)half.CosP3();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP4(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP4(xyz);
                case RotationOrder.XZY: return EulerXzyP4(xyz);
                case RotationOrder.YXZ: return EulerYxzP4(xyz);
                case RotationOrder.YZX: return EulerYzxP4(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP4(xyz);
                case RotationOrder.ZYX: return EulerZyxP4(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP4(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP4(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4();
            var c = (I17F15)half.CosP4();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP4(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4();
            var c = (I17F15)half.CosP4();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP4(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4();
            var c = (I17F15)half.CosP4();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) + (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) - (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) - (sx * sy * cz);
                var w = (cx * cy * cz) + (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();
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
                var x = (sx * cy * cz) + (sy * sz * cx);
                var y = (sy * cz * cx) - (sz * sx * cy);
                var z = (sz * cx * cy) + (sx * sy * cz);
                var w = (cx * cy * cz) - (sy * sz * sx);

                const long k = 1L << 45;
                return new QuaternionI17F15(
                    I17F15.FromBits((int)(x / k)),
                    I17F15.FromBits((int)(y / k)),
                    I17F15.FromBits((int)(z / k)),
                    I17F15.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP5(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP5(xyz);
                case RotationOrder.XZY: return EulerXzyP5(xyz);
                case RotationOrder.YXZ: return EulerYxzP5(xyz);
                case RotationOrder.YZX: return EulerYzxP5(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP5(xyz);
                case RotationOrder.ZYX: return EulerZyxP5(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP5(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP5(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5();
            var c = (I17F15)half.CosP5();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP5(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5();
            var c = (I17F15)half.CosP5();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP5(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5();
            var c = (I17F15)half.CosP5();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

    }
}
