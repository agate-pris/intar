using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class QuaternionTest {
        #region

        const float toRad = (float)Math.PI / 2;

        public static QuaternionI2F30 RandomQuaternion(ref Xoroshiro128StarStar rng) {
            var axis = Utility.RandomAxis(ref rng);
            var angle = Utility.RandomI17F15(ref rng);
            return QuaternionI2F30.AxisAngleP5(axis, angle);
        }

        public static double Delta(System.Numerics.Quaternion e, QuaternionI2F30 a) {
            var x = Math.Abs(a.X.ToDouble() - e.X);
            var y = Math.Abs(a.Y.ToDouble() - e.Y);
            var z = Math.Abs(a.Z.ToDouble() - e.Z);
            var w = Math.Abs(a.W.ToDouble() - e.W);
            return Math.Max(Math.Max(x, y), Math.Max(z, w));
        }

#if UNITY_5_6_OR_NEWER
        public static double Delta(UnityEngine.Quaternion e, QuaternionI2F30 a) {
            var x = Math.Abs(a.X.ToDouble() - e.x);
            var y = Math.Abs(a.Y.ToDouble() - e.y);
            var z = Math.Abs(a.Z.ToDouble() - e.z);
            var w = Math.Abs(a.W.ToDouble() - e.w);
            return Math.Max(Math.Max(x, y), Math.Max(z, w));
        }
#endif // UNITY_5_6_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static double Delta(Unity.Mathematics.quaternion e, QuaternionI2F30 a) {
            var x = Math.Abs(a.X.ToDouble() - e.value.x);
            var y = Math.Abs(a.Y.ToDouble() - e.value.y);
            var z = Math.Abs(a.Z.ToDouble() - e.value.z);
            var w = Math.Abs(a.W.ToDouble() - e.value.w);
            return Math.Max(Math.Max(x, y), Math.Max(z, w));
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region TestMul, TestRotate
        [Test]
        public static void TestMul() {
            const double delta = 0.0000002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm = 0.0;
            for (var i = 0; i < 32768; i++) {
                var a = RandomQuaternion(ref rng);
                var b = RandomQuaternion(ref rng);
                var a1 = a * b;
                var a2 = a.Concatenate(b);

                {
                    var af = (System.Numerics.Quaternion)a;
                    var bf = (System.Numerics.Quaternion)b;
                    var e1 = af * bf;
                    var e2 = System.Numerics.Quaternion.Concatenate(af, bf);
                    var d1 = Delta(e1, a1);
                    var d2 = Delta(e2, a2);
                    if (d1 > delta) {
                        Utility.LogError($"d1:{d1} a:{a} b:{b} e1:{e1} a1:{a1}");
                    }
                    if (d2 > delta) {
                        Utility.LogError($"d2:{d2} a:{a} b:{b} e2:{e2} a2:{a2}");
                    }
                    dm = Math.Max(dm, d1);
                    dm = Math.Max(dm, d2);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = (UnityEngine.Quaternion)a * (UnityEngine.Quaternion)b;
                    var d = Delta(e, a1);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} e:{e} a1:{a1}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.math.mul(
                        (Unity.Mathematics.quaternion)a,
                        (Unity.Mathematics.quaternion)b
                    );
                    var d = Delta(e, a1);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} e:{e} a1:{a1}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_2018_1_OR_NEWER

            }

            Assert.Less(dm, delta);
            Utility.Log($"{dm}");
        }

        [Test]
        public static void TestRotate() {
            const double delta = 0.0002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var q = RandomQuaternion(ref rng);
                var v = Utility.RandomPosition(ref rng);
                var a = q.Rotate(v);

                {
                    var e = System.Numerics.Vector3.Transform(
                        (System.Numerics.Vector3)v,
                        (System.Numerics.Quaternion)q
                    );
                    var d = Utility.Delta(e, a);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} v:{v} e:{e} a:{a}");
                    }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = ((UnityEngine.Quaternion)q) * ((UnityEngine.Vector3)v);
                    var d = Utility.Delta(e, a);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} v:{v} e:{e} a:{a}");
                    }
                    dm2 = Math.Max(dm2, d);
                }
#endif

#if UNITY_2018_1_OR_NEWER
                {
                    var qf = (Unity.Mathematics.quaternion)q;
                    var vf = (Unity.Mathematics.float3)v;
                    var e = Unity.Mathematics.math.rotate(qf, vf);
                    var d = Utility.Delta(e, a);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} v:{v} e:{e} a:{a}");
                    }
                    dm3 = Math.Max(dm3, d);
                }
#endif
            }
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"{dm1}");
            Utility.Log($"{dm2}");
            Utility.Log($"{dm3}");
        }
        #endregion
        #region TestInverse
        [Test]
        public static void TestInverse() {
            const double delta = 0.0004;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var q = RandomQuaternion(ref rng);
                QuaternionI2F30 actual;
                {
                    var a = q.Inverse();
                    if (!a.HasValue) {
                        continue;
                    }
                    actual = a.Value;
                }

                {
                    var e = System.Numerics.Quaternion.Inverse((System.Numerics.Quaternion)q);
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} e:{e} actual:{actual}");
                    }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Quaternion.Inverse((UnityEngine.Quaternion)q);
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} e:{e} actual:{actual}");
                    }
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.math.inverse((Unity.Mathematics.quaternion)q);
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} q:{q} e:{e} actual:{actual}");
                    }
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"{dm1}");
            Utility.Log($"{dm2}");
            Utility.Log($"{dm3}");
        }
        #endregion
        #region TestLerp
        /// <summary>
        /// ランダムなクォータニオンを作成し､
        /// System.Quaternion と Intar1991.QuaternionI2F30 とで
        /// Lerp の結果を比較する｡
        /// </summary>
        [Test]
        public static void TestLerp() {
            const double delta = 0.0000002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm = 0.0;
            for (var i = 0; i < 32768; i++) {
                var a = RandomQuaternion(ref rng);
                var b = RandomQuaternion(ref rng);
                var t = Utility.Random01I17F15(ref rng);
                var actual = a.UncheckedLerp(b, t);

                {
                    var e = System.Numerics.Quaternion.Lerp(
                        (System.Numerics.Quaternion)a,
                        (System.Numerics.Quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }

#if UNITY_5_6_OR_NEWER
                {
                    var e = UnityEngine.Quaternion.Lerp(
                        (UnityEngine.Quaternion)a,
                        (UnityEngine.Quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_5_6_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.math.nlerp(
                        (Unity.Mathematics.quaternion)a,
                        (Unity.Mathematics.quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_2018_1_OR_NEWER

            }
            Assert.Less(dm, delta);
            Console.WriteLine(dm);
        }
        #endregion
        #region CheckSlerpLogic, TestSlerp

        /// <summary>
        /// ランダムな任意の回転を表現するクォータニオンを作成し、
        /// 各種演算の計算過程の値を収集し、その値がとりうる範囲を調査する。
        /// </summary>
        [Test]
        public static void CheckSlerpLogic() {
            {
                // ドット積が 0.9995 ギリギリだった場合、
                // invSin は 32 未満になることを確認する。
                // また、それ 5 ビットの整数部と 27 ビットの小数部を持つ
                // 符号なし固定小数点数で表現できることを確認する。
                const ulong dot = ((1UL << 60) - ((1UL << 60) / 2000)) >> 29;
                var sqr = dot * dot;
                var sqrt = Intar1991.Mathi.Sqrt((1UL << 62) - sqr);
                var inv = (1UL << (31 + 27)) / sqrt;
                Console.WriteLine($"inv: {(float)inv / (1 << 27)}");
                Assert.IsTrue(inv < uint.MaxValue);
            }

            var rng = new Xoroshiro128StarStar(0, 1);
            float dotMin = float.PositiveInfinity, dotMax = float.NegativeInfinity;
            float angleMin = float.PositiveInfinity, angleMax = float.NegativeInfinity;
            var invSinMin = float.PositiveInfinity;
            var invSinMax = float.NegativeInfinity;
            var w1Min = float.PositiveInfinity;
            var w2Min = float.PositiveInfinity;
            var w1Max = float.NegativeInfinity;
            var w2Max = float.NegativeInfinity;
            var lengthMax = float.NegativeInfinity;
            var lengthMin = float.PositiveInfinity;
            var lengthMaxT = 0.0f;
            var lengthMinT = 0.0f;
            for (var i = 0; i < 99999; i++) {
                var q1 = new System.Numerics.Quaternion(rng.Next(), rng.Next(), rng.Next(), rng.Next());
                var q2 = new System.Numerics.Quaternion(rng.Next(), rng.Next(), rng.Next(), rng.Next());
                q1 = System.Numerics.Quaternion.Normalize(q1);
                q2 = System.Numerics.Quaternion.Normalize(q2);
                var t = Utility.Random01Single(ref rng);
                var dot = System.Numerics.Quaternion.Dot(q1, q2);
                dotMin = Math.Min(dotMin, dot);
                dotMax = Math.Max(dotMax, dot);

                System.Numerics.Quaternion qTo;
                float absDot;
                if (dot < 0) {
                    absDot = -dot;
                    qTo = -q2;
                } else {
                    absDot = dot;
                    qTo = q2;
                }

                if (absDot < 0.9995f) {
                    var angle = (float)Math.Acos(absDot);
                    angleMin = Math.Min(angleMin, angle);
                    angleMax = Math.Max(angleMax, angle);
                    var invSin = 1.0f / (float)Math.Sqrt(1.0f - (dot * dot));
                    invSinMin = Math.Min(invSinMin, invSin);
                    invSinMax = Math.Max(invSinMax, invSin);
                    var w1 = invSin * (float)Math.Sin(angle * (1.0f - t));
                    var w2 = invSin * (float)Math.Sin(angle * t);
                    w1Min = Math.Min(w1Min, w1);
                    w2Min = Math.Min(w2Min, w2);
                    w1Max = Math.Max(w1Max, w1);
                    w2Max = Math.Max(w2Max, w2);
                    var q = (q1 * w1) + (qTo * w2);
                    {
                        var expected = System.Numerics.Quaternion.Slerp(q1, q2, t);
                        if (Math.Abs(q.X - expected.X) > 0.0005f ||
                            Math.Abs(q.Y - expected.Y) > 0.0005f ||
                            Math.Abs(q.Z - expected.Z) > 0.0005f ||
                            Math.Abs(q.W - expected.W) > 0.0005f) {
                            Assert.Fail($"expected: {expected}, actual: {q}");
                        }
                    }
                    {
                        var l = q.Length();
                        if (Math.Abs(l - 1.0f) > 0.005f) {
                            Assert.Fail($"l: {l}, q: {q}");
                        }
                        if (l > lengthMax) {
                            lengthMax = l;
                            lengthMaxT = t;
                        }
                        if (l < lengthMin) {
                            lengthMin = l;
                            lengthMinT = t;
                        }
                    }
                    {
                        var ls = q.LengthSquared();
                        if (Math.Abs(ls - 1.0f) > 0.05f) {
                            Assert.Fail($"ls: {ls}, q: {q}");
                        }
                    }
                }
            }

            // ドット積は [-1, 1] の範囲に収まる。
            Console.WriteLine($"dotMin: {dotMin}");
            Console.WriteLine($"dotMax: {dotMax}");
            Assert.GreaterOrEqual(dotMin, -1);
            Assert.LessOrEqual(dotMax, 1);

            // ドット積から求まる角度.
            // 実際には絶対値を渡すため, その範囲は [0, PI/2] .
            Console.WriteLine($"angleMin: {angleMin}");
            Console.WriteLine($"angleMax: {angleMax}");

            // 前述の角度から求める Sin の逆数。
            // ドット積の絶対値が 0.9995 を超えた場合は
            // アルゴリズムを Nlerp に移譲するため、
            // その値は [1, 32] 。
            // 1 / Sin(Acos(0.0000)) = 1 / Sin(PI / 2) = 1 / 0.0316 =  1.0000
            // 1 / Sin(Acos(0.9995)) = 1 / Sin(0.0316) = 1 / 1.0000 = 31.6267
            // ただし、Acos の精度に依存する点に注意。
            Console.WriteLine($"invSinMin: {invSinMin}");
            Console.WriteLine($"invSinMax: {invSinMax}");

            // invSin に Sin(t) / sin(1-t) を乗算した値であるから、
            // その範囲は [-invSin, invSin] => [-32, 32]
            Console.WriteLine($"w1Min: {w1Min}");
            Console.WriteLine($"w1Max: {w1Max}");
            Console.WriteLine($"w2Min: {w2Min}");
            Console.WriteLine($"w2Max: {w2Max}");

            // ほぼ 1 だが, t が極端に大きい値や小さい値になるほど
            // 誤差によって大きく、あるいは小さくなる。
            // length の範囲は約 [0.996, 1.003] 。
            // 各々は t が -32747.42 / 32073.27 の時の値。
            Console.WriteLine($"lengthMax: {lengthMax}");
            Console.WriteLine($"lengthMaxT: {lengthMaxT}");
            Console.WriteLine($"lengthMin: {lengthMin}");
            Console.WriteLine($"lengthMinT: {lengthMinT}");
        }

        [Test]
        public static void TestSlerp() {
            const double delta = 0.003;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm = 0.0;
            for (var i = 0; i < 32768; i++) {
                var a = RandomQuaternion(ref rng);
                var b = RandomQuaternion(ref rng);
                var t = Utility.Random01I17F15(ref rng);
                var actual = a.UncheckedSlerp(b, t);

                {
                    var e = System.Numerics.Quaternion.Slerp(
                        (System.Numerics.Quaternion)a,
                        (System.Numerics.Quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Quaternion.Slerp(
                        (UnityEngine.Quaternion)a,
                        (UnityEngine.Quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.math.slerp(
                        (Unity.Mathematics.quaternion)a,
                        (Unity.Mathematics.quaternion)b,
                        t.LossyToSingle()
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} a:{a} b:{b} t:{t} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_2018_1_OR_NEWER

            }
            Assert.Less(dm, delta);
            Console.WriteLine(dm);
        }
        #endregion
        #region TestRotation, TestEuler, TestAxisAngle

        [Test]
        public static void TestRotation() {
            const double delta = 0.0002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var d = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angle = Utility.RandomI17F15(ref rng);
                var actualX = QuaternionI2F30.RotateXP5(angle);
                var actualY = QuaternionI2F30.RotateYP5(angle);
                var actualZ = QuaternionI2F30.RotateZP5(angle);
                var rad = angle.LossyToSingle() * toRad;
                var deg = angle.LossyToSingle() * 90;

                {
                    var eX = System.Numerics.Quaternion.CreateFromAxisAngle(System.Numerics.Vector3.UnitX, rad);
                    var eY = System.Numerics.Quaternion.CreateFromAxisAngle(System.Numerics.Vector3.UnitY, rad);
                    var eZ = System.Numerics.Quaternion.CreateFromAxisAngle(System.Numerics.Vector3.UnitZ, rad);
                    var dX = Delta(eX, actualX);
                    var dY = Delta(eY, actualY);
                    var dZ = Delta(eZ, actualZ);
                    if (dX > delta) { Utility.LogError($"dX > delta dx:{dX} angle:{angle} eX:{eX} actualX:{actualX}"); }
                    if (dY > delta) { Utility.LogError($"dY > delta dy:{dY} angle:{angle} eY:{eY} actualY:{actualY}"); }
                    if (dZ > delta) { Utility.LogError($"dZ > delta dz:{dZ} angle:{angle} eZ:{eZ} actualZ:{actualZ}"); }
                    d = Math.Max(d, Math.Max(dX, Math.Max(dY, dZ)));
                }

#if UNITY_5_3_OR_NEWER
                {
                    var eX = UnityEngine.Quaternion.AngleAxis(deg, UnityEngine.Vector3.right);
                    var eY = UnityEngine.Quaternion.AngleAxis(deg, UnityEngine.Vector3.up);
                    var eZ = UnityEngine.Quaternion.AngleAxis(deg, UnityEngine.Vector3.forward);
                    var dX = Delta(eX, actualX);
                    var dY = Delta(eY, actualY);
                    var dZ = Delta(eZ, actualZ);
                    if (dX > delta) { Utility.LogError($"dX > delta dx:{dX} angle:{angle} eX:{eX} actualX:{actualX}"); }
                    if (dY > delta) { Utility.LogError($"dY > delta dy:{dY} angle:{angle} eY:{eY} actualY:{actualY}"); }
                    if (dZ > delta) { Utility.LogError($"dZ > delta dz:{dZ} angle:{angle} eZ:{eZ} actualZ:{actualZ}"); }
                    d = Math.Max(d, Math.Max(dX, Math.Max(dY, dZ)));
                }
#endif

#if UNITY_2018_1_OR_NEWER
                {
                    var eX = Unity.Mathematics.quaternion.RotateX(rad);
                    var eY = Unity.Mathematics.quaternion.RotateY(rad);
                    var eZ = Unity.Mathematics.quaternion.RotateZ(rad);
                    var dX = Delta(eX, actualX);
                    var dY = Delta(eY, actualY);
                    var dZ = Delta(eZ, actualZ);
                    if (dX > delta) { Utility.LogError($"dX > delta dx:{dX} angle:{angle} eX:{eX} actualX:{actualX}"); }
                    if (dY > delta) { Utility.LogError($"dY > delta dy:{dY} angle:{angle} eY:{eY} actualY:{actualY}"); }
                    if (dZ > delta) { Utility.LogError($"dZ > delta dz:{dZ} angle:{angle} eZ:{eZ} actualZ:{actualZ}"); }
                    d = Math.Max(d, Math.Max(dX, Math.Max(dY, dZ)));
                }
#endif

            }
            Assert.Less(d, delta);
            Console.WriteLine(d);
        }

        [Test]
        public static void TestEuler() {
            const double delta = 0.0006;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm = 0.0;
            for (var i = 0; i < 32768; i++) {
                var x = Utility.RandomI17F15(ref rng);
                var y = Utility.RandomI17F15(ref rng);
                var z = Utility.RandomI17F15(ref rng);
                var actual = QuaternionI2F30.EulerZxyP5(x, y, z);

                {
                    var e = System.Numerics.Quaternion.CreateFromYawPitchRoll(
                        y.LossyToSingle() * toRad,
                        x.LossyToSingle() * toRad,
                        z.LossyToSingle() * toRad
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} x:{x} y:{y} z:{z} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Quaternion.Euler(
                        x.LossyToSingle() * 90,
                        y.LossyToSingle() * 90,
                        z.LossyToSingle() * 90
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} x:{x} y:{y} z:{z} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.quaternion.EulerZXY(
                        x.LossyToSingle() * toRad,
                        y.LossyToSingle() * toRad,
                        z.LossyToSingle() * toRad
                    );

                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} x:{x} y:{y} z:{z} e:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif // UNITY_2018_1_OR_NEWER

            }
            Assert.Less(dm, delta);
            Console.WriteLine(dm);
        }

        [Test]
        public static void TestAxisAngle() {
            const double delta = 0.0002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm = 0.0;
            for (var i = 0; i < 32768; i++) {
                var axis = Utility.RandomAxis(ref rng);
                var angle = Utility.RandomI17F15(ref rng);
                var actual = QuaternionI2F30.AxisAngleP5(axis, angle);

                {
                    var e = System.Numerics.Quaternion.CreateFromAxisAngle(
                        (System.Numerics.Vector3)axis,
                        angle.LossyToSingle() * toRad
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} axis:{axis} angle:{angle} expected:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Quaternion.AngleAxis(
                        angle.LossyToSingle() * 90,
                        (UnityEngine.Vector3)axis
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} axis:{axis} angle:{angle} expected:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.quaternion.AxisAngle(
                        (Unity.Mathematics.float3)axis,
                        angle.LossyToSingle() * toRad
                    );
                    var d = Delta(e, actual);
                    if (d > delta) {
                        Utility.LogError($"d:{d} axis:{axis} angle:{angle} expected:{e} actual:{actual}");
                    }
                    dm = Math.Max(dm, d);
                }
#endif

            }
            Assert.Less(dm, delta);
            Utility.Log($"{dm}");
        }
        #endregion
    }
}
