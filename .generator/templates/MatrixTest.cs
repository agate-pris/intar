{%- set components = ['X', 'Y', 'Z', 'W'] %}
{#- -#}

using System;

using {{ namespace }}.Rand;
using NUnit.Framework;

namespace {{ namespace }}.Tests {
    public class MatrixTest {
        public static Matrix3x3I2F30 RandomMatrix(ref Xoroshiro128StarStar rng) {
            var q = QuaternionTest.RandomQuaternion(ref rng);
            return (Matrix3x3I2F30)q;
        }

        {%- for f in [15, 30] %}

        public static double Delta(System.Numerics.Matrix4x4 e, Matrix3x3I{{ 32 - f }}F{{ f }} a) {
            var d = 0.0;
            {%- for r in range(end=4) %}
            {%- for c in range(end=4) %}
            d = Math.Max(d, Math.Abs(e.M{{ r + 1 }}{{ c + 1 }}
            {%- if   r == 3 and c == 3 %} - 1
            {%- elif r != 3 and c != 3 %} - (float)a.C{{ c }}.{{ components[r] }}{%- endif %}));
            {%- endfor %}
            {%- endfor %}
            return d;
        }
        {%- endfor %}

#if UNITY_5_3_OR_NEWER
        public static double Delta(UnityEngine.Matrix4x4 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            {%- for r in range(end=4) %}
            {%- for c in range(end=4) %}
            d = Math.Max(d, Math.Abs(e.m{{ r }}{{ c }}
            {%- if   r == 3 and c == 3 %} - 1
            {%- elif r != 3 and c != 3 %} - (float)a.C{{ c }}.{{ components[r] }}
            {%- endif %}));
            {%- endfor %}
            {%- endfor %}
            return d;
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static double Delta(Unity.Mathematics.float3x3 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            {%- for r in range(end=3) %}
            {%- for c in range(end=3) %}
            d = Math.Max(d, Math.Abs(e.c{{ c }}.{{ components[r]|lower }} - (float)a.C{{ c }}.{{ components[r] }}));
            {%- endfor %}
            {%- endfor %}
            return d;
        }
#endif // UNITY_2018_1_OR_NEWER

        [Test]
        public static void TestConversionFromQuaternion() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32786; i++) {
                var q = QuaternionTest.RandomQuaternion(ref rng);
                var a = (Matrix3x3I2F30)q;

                {
                    var e = System.Numerics.Matrix4x4.Transpose(
                        System.Numerics.Matrix4x4.CreateFromQuaternion(
                            (System.Numerics.Quaternion)q
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        (UnityEngine.Quaternion)q
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.quaternion)q
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0000003;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestMultiply() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var m1 = RandomMatrix(ref rng);
                var m2 = RandomMatrix(ref rng);
                var a = m1 * m2;

                {
                    var mf1 = new System.Numerics.Matrix4x4(
                        (float)m1.C0.X, (float)m1.C1.X, (float)m1.C2.X, 0,
                        (float)m1.C0.Y, (float)m1.C1.Y, (float)m1.C2.Y, 0,
                        (float)m1.C0.Z, (float)m1.C1.Z, (float)m1.C2.Z, 0,
                        0, 0, 0, 1
                    );
                    var mf2 = new System.Numerics.Matrix4x4(
                        (float)m2.C0.X, (float)m2.C1.X, (float)m2.C2.X, 0,
                        (float)m2.C0.Y, (float)m2.C1.Y, (float)m2.C2.Y, 0,
                        (float)m2.C0.Z, (float)m2.C1.Z, (float)m2.C2.Z, 0,
                        0, 0, 0, 1
                    );
                    var e = mf1 * mf2;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var mf1 = new UnityEngine.Matrix4x4(
                        (UnityEngine.Vector3)m1.C0,
                        (UnityEngine.Vector3)m1.C1,
                        (UnityEngine.Vector3)m1.C2,
                        new UnityEngine.Vector4(0, 0, 0, 1)
                    );
                    var mf2 = new UnityEngine.Matrix4x4(
                        (UnityEngine.Vector3)m2.C0,
                        (UnityEngine.Vector3)m2.C1,
                        (UnityEngine.Vector3)m2.C2,
                        new UnityEngine.Vector4(0, 0, 0, 1)
                    );
                    var e = mf1 * mf2;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var mf1 = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.float3)m1.C0,
                        (Unity.Mathematics.float3)m1.C1,
                        (Unity.Mathematics.float3)m1.C2
                    );
                    var mf2 = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.float3)m2.C0,
                        (Unity.Mathematics.float3)m2.C1,
                        (Unity.Mathematics.float3)m2.C2
                    );
                    var e = Unity.Mathematics.math.mul(mf1, mf2);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0000002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }
        {%- for index in range(end=3) %}
        {%- set a = components[index] %}

        [Test]
        public static void TestRotate{{ a|upper }}() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angle = Utility.RandomI17F15(ref rng);
                var rad = (float)angle * (float)(Math.PI / 2);
                var a = Matrix3x3I2F30.Rotate{{ a|upper }}P5(angle);

                {
                    var e = System.Numerics.Matrix4x4.Transpose(System.Numerics.Matrix4x4.CreateRotation{{ a|upper }}(rad));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var deg = (float)angle * 90;
                    var e = UnityEngine.Matrix4x4.Rotate(UnityEngine.Quaternion.Euler(
                        {%- for i in range(end=3) %}
                        {%- if index == i %}deg{% else %}0{% endif %}
                        {%- if not loop.last %}, {% endif %}
                        {%- endfor -%}
                    ));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.Rotate{{ a|upper }}(rad);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }
        {%- endfor %}

        {%- for item in ['xyz', 'xzy', 'yxz', 'yzx', 'zxy', 'zyx'] %}

        [Test]
        public static void TestEuler{{ item|capitalize }}() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            {%- if item == 'zxy' %}
            var dm2 = 0.0;
            {%- endif %}
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.Euler{{ item|capitalize }}P5(angles);

                {
                    var e
                    {%- for i in item %}
                        {% if loop.first %}=
                        {%- else %}*
                        {%- endif %} System.Numerics.Matrix4x4.CreateRotation
                        {{- i | upper }}((float)angles.
                        {{- i | upper }} * (float)(Math.PI / 2))
                    {%- endfor %};
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

                {%- if item == 'zxy' %}
#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        UnityEngine.Quaternion.Euler(
                            (UnityEngine.Vector3)angles * 90
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER
                {%- endif %}

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.Euler{{ item|upper }}(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            {%- if item == 'zxy' %}
            Assert.Less(dm2, delta);
            {%- endif %}
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            {%- if item == 'zxy' %}
            Utility.Log($"dm2:{dm2}");
            {%- endif %}
            Utility.Log($"dm3:{dm3}");
        }
        {%- endfor %}

        [Test]
        public static void TestAxisAngle() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var axis = Utility.RandomAxis(ref rng);
                var angle = Utility.RandomI17F15(ref rng);
                var a = Matrix3x3I2F30.AxisAngleP5(axis, angle);

                {
                    // Remarks
                    //
                    // For matrix transformations, the Vector2, Vector3, and Vector4
                    // instances are represented as rows: a vector v is transformed by
                    // a matrix M with vM multiplication.
                    //
                    // https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4
                    var e = System.Numerics.Matrix4x4.Transpose(
                        System.Numerics.Matrix4x4.CreateFromAxisAngle(
                            (System.Numerics.Vector3)axis,
                            (float)angle * (float)(Math.PI / 2)
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        UnityEngine.Quaternion.AngleAxis(
                            (float)angle * 90,
                            (UnityEngine.Vector3)axis
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.AxisAngle(
                        (Unity.Mathematics.float3)axis,
                        (float)angle * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestLookRotation() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                Vector3I2F30 forward, up;
                {
                    var q1 = QuaternionTest.RandomQuaternion(ref rng);
                    var q2 = QuaternionTest.RandomQuaternion(ref rng);
                    forward = q1.Rotate(Vector3I2F30.UnitX);
                    up = q2.Rotate(Vector3I2F30.UnitX);
                }
                var a = Matrix3x3I2F30.LookRotation(forward, up);

                {
                    // System.Numerics は右手系であるから
                    // forward を符号反転し、行列を転置 **しない** ことで
                    // 同じ値になる。
                    var e = System.Numerics.Matrix4x4.CreateLookAt(
                        System.Numerics.Vector3.Zero,
                        -(System.Numerics.Vector3)forward,
                        (System.Numerics.Vector3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.LookAt(
                        UnityEngine.Vector3.zero,
                        (UnityEngine.Vector3)forward,
                        (UnityEngine.Vector3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.LookRotation(
                        (Unity.Mathematics.float3)forward,
                        (Unity.Mathematics.float3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0007;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestLookRotationSafe() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                Vector3I2F30 forward, up;
                {
                    var q1 = QuaternionTest.RandomQuaternion(ref rng);
                    var q2 = QuaternionTest.RandomQuaternion(ref rng);
                    forward = q1.Rotate(Vector3I2F30.UnitX);
                    up = q2.Rotate(Vector3I2F30.UnitX);
                }
                var a = Matrix3x3I2F30.LookRotationSafe(forward, up);

                if (!a.HasValue) {
                    continue;
                }

                {
                    var e = System.Numerics.Matrix4x4.CreateLookAt(
                        System.Numerics.Vector3.Zero,
                        -(System.Numerics.Vector3)forward,
                        (System.Numerics.Vector3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.LookAt(
                        UnityEngine.Vector3.zero,
                        (UnityEngine.Vector3)forward,
                        (UnityEngine.Vector3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.LookRotation(
                        (Unity.Mathematics.float3)forward,
                        (Unity.Mathematics.float3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0007;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }
    }
} // namespace {{ namespace }}.Tests
