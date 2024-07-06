using AgatePris.Intar.Numerics;
using NUnit.Framework;
using System;

#if UNITY_5_6_OR_NEWER

using UnityEngine;

#else

using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

#endif

namespace AgatePris.Intar.Tests {
    public class TransformTest {
        [Test]
        public static void TestTransform() {
            var transform = new TransformI17F15 {
                LocalPosition = new Vector3I17F15(I17F15.FromNum(1), I17F15.FromNum(2), I17F15.FromNum(3)),
                LocalRotation = QuaternionI17F15.Identity,
                LocalScale = new Vector3I17F15(I17F15.One, I17F15.One, I17F15.One)
            };

            {
                string s;
#if UNITY_5_6_OR_NEWER
                s = JsonUtility.ToJson(transform);
#else
                // Serialize using SOAP formatter.
                var formatter = new SoapFormatter();
                var stream = new MemoryStream();
                formatter.Serialize(stream, transform);

                // Convert from stream to string
                s = Encoding.UTF8.GetString(stream.GetBuffer());
#endif
                Console.WriteLine(s);
            }
        }
    }
}
