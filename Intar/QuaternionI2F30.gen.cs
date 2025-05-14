using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct QuaternionI2F30 : IEquatable<QuaternionI2F30>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector4Int32 Repr;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        QuaternionI2F30(Vector4Int32 repr) => Repr = repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30(I2F30 x, I2F30 y, I2F30 z, I2F30 w)
            : this(new Vector4Int32(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30(Vector4I2F30 xyzw)
            : this(new Vector4Int32(xyzw.X.Bits, xyzw.Y.Bits, xyzw.Z.Bits, xyzw.W.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30(Vector3I2F30 xyz, I2F30 w)
            : this(new Vector4Int32(xyz.X.Bits, xyz.Y.Bits, xyz.Z.Bits, w.Bits)) { }
        #endregion
        #region Components

        public I2F30 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }

        public I2F30 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }

        public I2F30 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }

        public I2F30 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
        }
        #endregion
        #region Conversion Operators

        public static explicit operator System.Numerics.Quaternion(QuaternionI2F30 q) {
            return new System.Numerics.Quaternion(
                (float)q.X,
                (float)q.Y,
                (float)q.Z,
                (float)q.W
            );
        }

#if UNITY_5_6_OR_NEWER
        public static explicit operator UnityEngine.Quaternion(QuaternionI2F30 q) {
            return new UnityEngine.Quaternion(
                (float)q.X,
                (float)q.Y,
                (float)q.Z,
                (float)q.W
            );
        }
#endif // UNITY_5_6_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.quaternion(QuaternionI2F30 q) {
            return new Unity.Mathematics.quaternion(
                (float)q.X,
                (float)q.Y,
                (float)q.Z,
                (float)q.W
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region Vector, Imaginary

        public Vector4I2F30 Vector {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector4I2F30.FromRepr(Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr = value.Repr;
        }

        public Vector3I2F30 Imaginary {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector3I2F30.FromRepr(Repr.XYZ());
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                Repr.X = value.X.Bits;
                Repr.Y = value.Y.Bits;
                Repr.Z = value.Z.Bits;
            }
        }
        #endregion
        #region Identity
        public static readonly QuaternionI2F30 Identity = new QuaternionI2F30(Vector4I2F30.UnitW);
        #endregion
        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(QuaternionI2F30 other) => Repr.Equals(other.Repr);
        #endregion
        #region Object

        public override bool Equals(object obj) => obj is QuaternionI2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"{{X:{X} Y:{Y} Z:{Z} W:{W}}}";
        #endregion
        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{X:{X.ToString(format, formatProvider)} Y:{Y.ToString(format, formatProvider)} Z:{Z.ToString(format, formatProvider)} W:{W.ToString(format, formatProvider)}}}";
        }
        #endregion
        #region IMultiplyOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 operator *(QuaternionI2F30 l, QuaternionI2F30 r) {
            var tmp = r.Repr.BigMul(l.Repr.W);
            tmp += r.Repr.WZYX().BigMul(l.Repr.X) * new Vector4Int64(+1, -1, +1, -1);
            tmp += r.Repr.ZWXY().BigMul(l.Repr.Y) * new Vector4Int64(+1, +1, -1, -1);
            tmp += r.Repr.YXWZ().BigMul(l.Repr.Z) * new Vector4Int64(-1, +1, +1, -1);
            return new QuaternionI2F30((Vector4Int32)(tmp / (1L << 30)));
        }
        #endregion
        #region Concatenate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30 Concatenate(QuaternionI2F30 other) => other * this;
        #endregion
        #region Rotate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Rotate(Vector3I17F15 v) {
            var imaginary = Imaginary.Repr;
            var tmp = (Vector3Int32)(2 * imaginary.Cross(v.Repr) / I2F30.OneRepr);
            tmp = (Vector3Int32)((tmp.BigMul(Repr.W) + imaginary.Cross(tmp)) / I2F30.OneRepr);
            return Vector3I17F15.FromRepr(tmp + v.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Rotate(Vector3I2F30 v) {
            var imaginary = Imaginary.Repr;
            var tmp = (Vector3Int32)(2 * imaginary.Cross(v.Repr) / I2F30.OneRepr);
            tmp = (Vector3Int32)((tmp.BigMul(Repr.W) + imaginary.Cross(tmp)) / I2F30.OneRepr);
            return Vector3I2F30.FromRepr(tmp + v.Repr);
        }
        #endregion
        #region Conjugate, Inverse, Dot, Length, LengthSquared, Normalize

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
        public QuaternionI2F30 Conjugate() {
            return new QuaternionI2F30(new Vector4Int32(
                -Repr.X, -Repr.Y, -Repr.Z, Repr.W
            ));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30? Inverse() {
            var lengthSquared = LengthSquared().Bits / U2F30.OneRepr;
            if (lengthSquared == 0) {
                return null;
            }
            var conjugate = Conjugate();
            var bits = conjugate.Repr.BigMul(I2F30.OneRepr) / (long)lengthSquared;
            return new QuaternionI2F30((Vector4Int32)bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 Dot(QuaternionI2F30 other) {
            return I4F60.FromBits(Repr.Dot(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 LengthSquared() {
            return U4F60.FromBits(Repr.LengthSquared());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 Length() {
            return U2F30.FromBits(Repr.Length());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30? Normalize() {
            var tmp = Vector4I2F30.Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new QuaternionI2F30(tmp.Value);
        }
        #endregion
        #region Lerp, Slerp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public QuaternionI2F30 Lerp(QuaternionI2F30 other, I17F15 t) {
            var a = Repr.BigMul((I17F15.One - t).Bits);
            var b = other.Repr.BigMul(t.Bits);
            var dot = Dot(other);
            a = (dot.Bits < 0) ? (a - b) : (a + b);
            var q = new QuaternionI2F30((Vector4Int32)(a / I17F15.OneRepr));
            return q.Normalize().Value;
        }

        public QuaternionI2F30 Slerp(QuaternionI2F30 other, I17F15 t) {
            var dot = Dot(other);
            if (dot.Bits < 0) {
                dot = -dot;
                other.Repr = -other.Repr;
            }

            // この値を変えると再現性が失われる他,
            // オーバーフローを引き起こす場合がある.
            // (invSin が 32 以上になる場合があるため)
            const long threshold = I4F60.OneRepr / 2000;

            if (dot.Bits < I4F60.OneRepr - threshold) {
                // ドット積の小数部の精度を 60 から 31 に変える.
                var d = U33F31.FromBits((ulong)dot.Bits >> 29);

                // ドット積の Arccos を計算する.
                // 後の計算のために小数部の精度を 15 ビットにする.
                var angle = I17F15.AcosP3((I33F31)d);

                // 閾値が 0.0005 の場合 invSin の最大値は
                // (1 - (1-0.0005)^2)^(-0.5)=31.6267301900746 となる.
                // 後の計算のために invSin の小数部のビット数が 32 ビットとなるように調製する.
                ulong invSin;
                {
                    var tmp = (1UL << 62) - (d.Bits * d.Bits);
                    invSin = (1UL << 63) / Mathi.Sqrt(tmp);
                }

                // w1, w2 の範囲は [0, 1] である.
                // 30 ビットの小数部を持つ Repr/other.Repr と乗算した時
                // 2 ビットの整数部と 62 ビットの小数部を持つよう
                // 32 ビットの小数部を持たせる.
                ulong w1, w2;
                {
                    w1 = (invSin * (ulong)(angle * (I17F15.One - t)).SinP5().Bits) >> 30;
                    w2 = (invSin * (ulong)(angle * t).SinP5().Bits) >> 30;
                }

                // 最後に足し合わせて終わり
                {
                    var a = (long)w1 * (Vector4Int64)Repr;
                    var b = (long)w2 * (Vector4Int64)other.Repr;
                    var q = (a + b) / (1L << 32);
                    return new QuaternionI2F30(new Vector4Int32(
                        (int)q.X, (int)q.Y, (int)q.Z, (int)q.W
                    ));
                }
            }
            return Lerp(other, t);
        }
        #endregion
        #region AxisAngle

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static QuaternionI2F30 AxisAngle(Vector3I2F30 axis, I2F30 sin, I2F30 cos) {
            return new QuaternionI2F30(axis * sin, cos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP2(Vector3I2F30 axis, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP2();
            var c = half.CosP2();
            return AxisAngle(axis, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP2(
            I2F30 axisX, I2F30 axisY, I2F30 axisZ, I17F15 angle
        ) => AxisAngleP2(new Vector3I2F30(axisX, axisY, axisZ), angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP3(Vector3I2F30 axis, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3();
            var c = half.CosP3();
            return AxisAngle(axis, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP3(
            I2F30 axisX, I2F30 axisY, I2F30 axisZ, I17F15 angle
        ) => AxisAngleP3(new Vector3I2F30(axisX, axisY, axisZ), angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP4(Vector3I2F30 axis, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4();
            var c = half.CosP4();
            return AxisAngle(axis, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP4(
            I2F30 axisX, I2F30 axisY, I2F30 axisZ, I17F15 angle
        ) => AxisAngleP4(new Vector3I2F30(axisX, axisY, axisZ), angle);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP5(Vector3I2F30 axis, I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5();
            var c = half.CosP5();
            return AxisAngle(axis, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 AxisAngleP5(
            I2F30 axisX, I2F30 axisY, I2F30 axisZ, I17F15 angle
        ) => AxisAngleP5(new Vector3I2F30(axisX, axisY, axisZ), angle);
        #endregion
        #region Euler

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP2(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP2();
                var c = half.CosP2();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP2(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP2(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP3(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP3();
                var c = half.CosP3();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP3(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP3(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP4(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP4();
                var c = half.CosP4();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP4(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP4(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXyzP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXyzP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerXzyP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerXzyP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYxzP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYxzP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerYzxP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerYzxP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZxyP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZxyP5(new Vector3I17F15(x, y, z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP5(Vector3I17F15 xyz) {
            long sx, sy, sz, cx, cy, cz;
            {
                var half = xyz.Half();
                var s = half.SinP5();
                var c = half.CosP5();

                // 3 乗してもオーバーフローが起きないように
                // 小数部のビット数を制限する。

                const int k = 1 << (30 - (((32 * 2) - 2) / 3));

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

                const long k = 1L << ((((32 * 2) - 2) / 3 * 3) - 30);
                return new QuaternionI2F30(
                    I2F30.FromBits((int)(x / k)),
                    I2F30.FromBits((int)(y / k)),
                    I2F30.FromBits((int)(z / k)),
                    I2F30.FromBits((int)(w / k)));
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 EulerZyxP5(
            I17F15 x, I17F15 y, I17F15 z
        ) => EulerZyxP5(new Vector3I17F15(x, y, z));
        #endregion
        #region Rotate X/Y/Z

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateXP2(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP2();
            var c = half.CosP2();
            return new QuaternionI2F30(s, I2F30.Zero, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateYP2(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP2();
            var c = half.CosP2();
            return new QuaternionI2F30(I2F30.Zero, s, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateZP2(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP2();
            var c = half.CosP2();
            return new QuaternionI2F30(I2F30.Zero, I2F30.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateXP3(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3();
            var c = half.CosP3();
            return new QuaternionI2F30(s, I2F30.Zero, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateYP3(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3();
            var c = half.CosP3();
            return new QuaternionI2F30(I2F30.Zero, s, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateZP3(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP3();
            var c = half.CosP3();
            return new QuaternionI2F30(I2F30.Zero, I2F30.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateXP4(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4();
            var c = half.CosP4();
            return new QuaternionI2F30(s, I2F30.Zero, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateYP4(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4();
            var c = half.CosP4();
            return new QuaternionI2F30(I2F30.Zero, s, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateZP4(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP4();
            var c = half.CosP4();
            return new QuaternionI2F30(I2F30.Zero, I2F30.Zero, s, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateXP5(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5();
            var c = half.CosP5();
            return new QuaternionI2F30(s, I2F30.Zero, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateYP5(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5();
            var c = half.CosP5();
            return new QuaternionI2F30(I2F30.Zero, s, I2F30.Zero, c);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static QuaternionI2F30 RotateZP5(I17F15 angle) {
            var half = angle.Half();
            var s = half.SinP5();
            var c = half.CosP5();
            return new QuaternionI2F30(I2F30.Zero, I2F30.Zero, s, c);
        }
        #endregion
    }
} // namespace Intar
