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

        public Vector4I17F15 XYZW;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Properties
        // ---------------------------------------
        public I17F15 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => XYZW.X;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.X = value;
        }
        public I17F15 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => XYZW.Y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.Y = value;
        }
        public I17F15 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => XYZW.Z;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.Z = value;
        }
        public I17F15 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => XYZW.W;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => XYZW.W = value;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(Vector4I17F15 xyzw) => XYZW = xyzw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI17F15(I17F15 x, I17F15 y, I17F15 z, I17F15 w)
            : this(new Vector4I17F15(x, y, z, w)) { }

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
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"{{X:{X} Y:{Y} Z:{Z} W:{W}}}";

        // IEquatable<QuaternionI17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(QuaternionI17F15 other) => XYZW.Equals(other.XYZW);

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"{{X:{x} Y:{y} Z:{z} W:{w}}}";
        }

        // Methods
        // ---------------------------------------

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
            -XYZW.X,
            -XYZW.Y,
            -XYZW.Z,
            XYZW.W);

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
        public static QuaternionI17F15 AxisAngleP3A16384(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3A16384();
            var c = half.CosP3A16384();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP3A16384(Vector3Int axis, I17F15 angle) {
            return AxisAngleP3A16384(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4A7032(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4A7032();
            var c = half.CosP4A7032();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4A7032(Vector3Int axis, I17F15 angle) {
            return AxisAngleP4A7032(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4A7384(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4A7384();
            var c = half.CosP4A7384();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP4A7384(Vector3Int axis, I17F15 angle) {
            return AxisAngleP4A7384(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5A51472(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5A51472();
            var c = half.CosP5A51472();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5A51472(Vector3Int axis, I17F15 angle) {
            return AxisAngleP5A51472(axis.x, axis.y, axis.z, angle);
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5A51437(int axisX, int axisY, int axisZ, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5A51437();
            var c = half.CosP5A51437();
            return AxisAngle(axisX, axisY, axisZ, s, c);
        }

#if UNITY_5_6_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 AxisAngleP5A51437(Vector3Int axis, I17F15 angle) {
            return AxisAngleP5A51437(axis.x, axis.y, axis.z, angle);
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
        public static QuaternionI17F15 EulerXyzP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerXyzP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP3A16384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerXzyP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP3A16384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerYxzP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP3A16384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerYzxP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP3A16384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerZxyP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP3A16384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP3A16384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3A16384();
                var c = half.CosP3A16384();
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
        public static QuaternionI17F15 EulerZyxP3A16384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP3A16384(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP3A16384(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP3A16384(xyz);
                case RotationOrder.XZY: return EulerXzyP3A16384(xyz);
                case RotationOrder.YXZ: return EulerYxzP3A16384(xyz);
                case RotationOrder.YZX: return EulerYzxP3A16384(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP3A16384(xyz);
                case RotationOrder.ZYX: return EulerZyxP3A16384(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP3A16384(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP3A16384(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP3A16384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3A16384();
            var c = (I17F15)half.CosP3A16384();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP3A16384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3A16384();
            var c = (I17F15)half.CosP3A16384();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP3A16384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP3A16384();
            var c = (I17F15)half.CosP3A16384();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerXyzP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP4A7032(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerXzyP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP4A7032(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerYxzP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP4A7032(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerYzxP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP4A7032(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerZxyP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP4A7032(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP4A7032(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7032();
                var c = half.CosP4A7032();
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
        public static QuaternionI17F15 EulerZyxP4A7032(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP4A7032(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4A7032(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP4A7032(xyz);
                case RotationOrder.XZY: return EulerXzyP4A7032(xyz);
                case RotationOrder.YXZ: return EulerYxzP4A7032(xyz);
                case RotationOrder.YZX: return EulerYzxP4A7032(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP4A7032(xyz);
                case RotationOrder.ZYX: return EulerZyxP4A7032(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4A7032(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP4A7032(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP4A7032(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7032();
            var c = (I17F15)half.CosP4A7032();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP4A7032(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7032();
            var c = (I17F15)half.CosP4A7032();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP4A7032(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7032();
            var c = (I17F15)half.CosP4A7032();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerXyzP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP4A7384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerXzyP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP4A7384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerYxzP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP4A7384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerYzxP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP4A7384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerZxyP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP4A7384(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP4A7384(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4A7384();
                var c = half.CosP4A7384();
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
        public static QuaternionI17F15 EulerZyxP4A7384(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP4A7384(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4A7384(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP4A7384(xyz);
                case RotationOrder.XZY: return EulerXzyP4A7384(xyz);
                case RotationOrder.YXZ: return EulerYxzP4A7384(xyz);
                case RotationOrder.YZX: return EulerYzxP4A7384(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP4A7384(xyz);
                case RotationOrder.ZYX: return EulerZyxP4A7384(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP4A7384(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP4A7384(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP4A7384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7384();
            var c = (I17F15)half.CosP4A7384();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP4A7384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7384();
            var c = (I17F15)half.CosP4A7384();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP4A7384(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP4A7384();
            var c = (I17F15)half.CosP4A7384();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerXyzP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP5A51472(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerXzyP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP5A51472(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerYxzP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP5A51472(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerYzxP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP5A51472(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerZxyP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP5A51472(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP5A51472(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51472();
                var c = half.CosP5A51472();
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
        public static QuaternionI17F15 EulerZyxP5A51472(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP5A51472(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5A51472(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP5A51472(xyz);
                case RotationOrder.XZY: return EulerXzyP5A51472(xyz);
                case RotationOrder.YXZ: return EulerYxzP5A51472(xyz);
                case RotationOrder.YZX: return EulerYzxP5A51472(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP5A51472(xyz);
                case RotationOrder.ZYX: return EulerZyxP5A51472(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5A51472(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP5A51472(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP5A51472(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51472();
            var c = (I17F15)half.CosP5A51472();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP5A51472(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51472();
            var c = (I17F15)half.CosP5A51472();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP5A51472(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51472();
            var c = (I17F15)half.CosP5A51472();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXyzP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerXyzP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP5A51437(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerXzyP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerXzyP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP5A51437(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYxzP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerYxzP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP5A51437(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerYzxP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerYzxP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP5A51437(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZxyP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerZxyP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP5A51437(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerZyxP5A51437(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5A51437();
                var c = half.CosP5A51437();
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
        public static QuaternionI17F15 EulerZyxP5A51437(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP5A51437(new Vector3I17F15(x, y, z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5A51437(Vector3I17F15 xyz, RotationOrder order) {
            switch (order) {
                case RotationOrder.XYZ: return EulerXyzP5A51437(xyz);
                case RotationOrder.XZY: return EulerXzyP5A51437(xyz);
                case RotationOrder.YXZ: return EulerYxzP5A51437(xyz);
                case RotationOrder.YZX: return EulerYzxP5A51437(xyz);
                default:
                case RotationOrder.ZXY: return EulerZxyP5A51437(xyz);
                case RotationOrder.ZYX: return EulerZyxP5A51437(xyz);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 EulerP5A51437(
            I17F15 x, I17F15 y, I17F15 z, RotationOrder order
        ) => EulerP5A51437(new Vector3I17F15(x, y, z), order);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateXP5A51437(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51437();
            var c = (I17F15)half.CosP5A51437();
            return new QuaternionI17F15(s, I17F15.Zero, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateYP5A51437(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51437();
            var c = (I17F15)half.CosP5A51437();
            return new QuaternionI17F15(I17F15.Zero, s, I17F15.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI17F15 RotateZP5A51437(I17F15 angle) {
            var half = angle.Half();
            var s = (I17F15)half.SinP5A51437();
            var c = (I17F15)half.CosP5A51437();
            return new QuaternionI17F15(I17F15.Zero, I17F15.Zero, s, c);
        }

    }
}
