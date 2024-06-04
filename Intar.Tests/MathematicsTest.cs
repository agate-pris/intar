using AgatePris.Intar.Mathematics;
using NUnit.Framework;
using static NUnit.Framework.Assert;

#if !UNITY_5_6_OR_NEWER
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
#endif

#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
#endif

namespace AgatePris.Intar.Tests.Mathematics {
    public class MathematicsTest {
        [Test]
        public void Vector2Test() {
#if !UNITY_5_6_OR_NEWER
            {
                var v = new int2(1, 2);

                // Serialize v into string using SOAP formatter.
                var formatter = new SoapFormatter();
                var stream = new MemoryStream();
                formatter.Serialize(stream, v);
                var str = Encoding.UTF8.GetString(stream.GetBuffer());
                Console.WriteLine(str);

                // Deserialize into v from string using SOAP formatter.
                stream = new MemoryStream(Encoding.UTF8.GetBytes(str));
                v = (int2)formatter.Deserialize(stream);
                AreEqual(1, v.x);
                AreEqual(2, v.y);
            }
#endif
            {
                var v = new int2(1, 2);
                AreEqual(1, v.x);
                AreEqual(2, v.y);
                AreEqual(11, v.Dot(new int2(3, 4)));
                var l = v.AsLong();
                AreEqual(1, l.x);
                AreEqual(2, l.y);
            }
            {
                var v = new uint2(3, 4);
                AreEqual(3, v.x);
                AreEqual(4, v.y);
                AreEqual(39, v.Dot(new uint2(5, 6)));
                var l = v.AsUlong();
                AreEqual(3, l.X);
                AreEqual(4, l.Y);
            }
            {
                var v = new long2(5, 6);
                AreEqual(5, v.x);
                AreEqual(6, v.y);
                AreEqual(83, v.Dot(new long2(7, 8)));
                var i = v.AsInt();
                AreEqual(5, i.x);
                AreEqual(6, i.y);
            }
            {
                var v = new ulong2(7, 8);
                AreEqual(7, v.X);
                AreEqual(8, v.Y);
                AreEqual(143, v.Dot(new ulong2(9, 10)));
                var i = v.AsUint();
                AreEqual(7, i.x);
                AreEqual(8, i.y);
            }
            AreEqual(50, new int2(30, 40).Length());
            AreEqual(50, new int2(-30, 40).Length());
            AreEqual(50, new int2(30, -40).Length());
            AreEqual(50, new int2(-30, -40).Length());
            AreEqual(50, new uint2(30, 40).Length());
        }
    }
}
