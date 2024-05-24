using AgatePris.Intar.Mathematics;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace AgatePris.Intar.Tests.Mathematics {
    public class MathematicsTest {
        [Test]
        public void Vector2Test() {
            {
                var v = new Int2(1, 2);
                AreEqual(1, v.X);
                AreEqual(2, v.Y);
                AreEqual(11, v.Dot(new Int2(3, 4)));
                var l = v.AsLong();
                AreEqual(1, l.X);
                AreEqual(2, l.Y);
            }
            {
                var v = new Uint2(3, 4);
                AreEqual(3, v.X);
                AreEqual(4, v.Y);
                AreEqual(39, v.Dot(new Uint2(5, 6)));
                var l = v.AsUlong();
                AreEqual(3, l.X);
                AreEqual(4, l.Y);
            }
            {
                var v = new Long2(5, 6);
                AreEqual(5, v.X);
                AreEqual(6, v.Y);
                AreEqual(83, v.Dot(new Long2(7, 8)));
                var i = v.AsInt();
                AreEqual(5, i.X);
                AreEqual(6, i.Y);
            }
            {
                var v = new Ulong2(7, 8);
                AreEqual(7, v.X);
                AreEqual(8, v.Y);
                AreEqual(143, v.Dot(new Ulong2(9, 10)));
                var i = v.AsUint();
                AreEqual(7, i.X);
                AreEqual(8, i.Y);
            }
            AreEqual(50, new Int2(30, 40).Length());
            AreEqual(50, new Int2(-30, 40).Length());
            AreEqual(50, new Int2(30, -40).Length());
            AreEqual(50, new Int2(-30, -40).Length());
            AreEqual(50, new Uint2(30, 40).Length());
        }
    }
}
