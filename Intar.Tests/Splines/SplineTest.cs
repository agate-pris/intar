using AgatePris.Intar.Splines;
using NUnit.Framework;

#if !UNITY_5_6_OR_NEWER
using System.IO;
using System.Text;
using System;
using System.Runtime.Serialization.Formatters.Soap;
#endif

namespace AgatePris.Intar.Tests.Splines {
    public class SplineTest {
        [Test]
        public void Test() {
            var spline = new Spline2D();
            Assert.IsNotNull(spline);
#if !UNITY_5_6_OR_NEWER
            var stream = new MemoryStream();
            var formatter = new SoapFormatter();
            formatter.Serialize(stream, spline);
            var str = Encoding.UTF8.GetString(stream.GetBuffer());
            Console.WriteLine(str);
#endif
        }
    }
}
