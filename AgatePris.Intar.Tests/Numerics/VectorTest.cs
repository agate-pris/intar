using AgatePris.Intar.Numerics;
using NUnit.Framework;
using System;

namespace AgatePris.Intar.Tests.Numerics {
    public class VectorTest {
        [Test]
        public static void TestLengthSquared() {
            {
                var v = Generator.Vector(
                    I17F15.FromNum(1),
                    I17F15.FromNum(1));
                var ls = v.LengthSquared();
                var expected = I36F28.FromNum(2);
                if (expected != ls) {
                    Assert.Fail($"expected: {expected} ls: {ls}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.FromNum(1),
                    I17F15.FromNum(2));
                var ls = v.LengthSquared();
                var expected = I36F28.FromNum(5);
                if (expected != ls) {
                    Assert.Fail($"expected: {expected} ls: {ls}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.FromNum(3),
                    I17F15.FromNum(4));
                var ls = v.LengthSquared();
                var expected = I36F28.FromNum(25);
                if (expected != ls) {
                    Assert.Fail($"expected: {expected} ls: {ls}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.MaxValue,
                    I17F15.MaxValue);
                var ls = v.LengthSquared();
                Console.WriteLine($"ls: {ls}");
                var greater = I36F28.FromBits(long.MinValue / -4);
                Console.WriteLine($"greater: {greater}");
                if (ls > greater) {
                    Assert.Fail($"ls: {ls} greater: {greater}");
                }
                I36F28 expected;
                {
                    const long k = int.MaxValue;
                    expected = I36F28.FromBits(k * k / 4 * 2);
                }
                Console.WriteLine($"expected: {expected}");
                if (ls != expected) {
                    Assert.Fail($"ls: {ls} expected: {expected}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.MaxValue,
                    I17F15.MinValue);
                var ls = v.LengthSquared();
                Console.WriteLine($"ls: {ls}");
                var greater = I36F28.FromBits(long.MinValue / -4);
                Console.WriteLine($"greater: {greater}");
                if (ls > greater) {
                    Assert.Fail($"ls: {ls} greater: {greater}");
                }
                I36F28 expected;
                {
                    const long k = -1L * int.MaxValue * int.MinValue;
                    expected = I36F28.FromBits(k / 4 * 2);
                }
                Console.WriteLine($"expected: {expected}");
                if (ls != expected) {
                    Assert.Fail($"ls: {ls} expected: {expected}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.MinValue,
                    I17F15.MinValue);
                var ls = v.LengthSquared();
                Console.WriteLine($"ls: {ls}");
                var greater = I36F28.FromBits(long.MinValue / -4);
                Console.WriteLine($"greater: {greater}");
                if (ls > greater) {
                    Assert.Fail($"ls.Bits: {ls.Bits} greater: {greater.Bits}");
                }
                I36F28 expected;
                {
                    const long k = int.MinValue;
                    expected = I36F28.FromBits(k * k / 4 * 2);
                }
                Console.WriteLine($"expected: {expected}");
                if (ls != expected) {
                    Assert.Fail($"ls: {ls} expected: {expected}");
                }
            }
            {
                var v = Generator.Vector(
                    I17F15.MinValue,
                    I17F15.MinValue,
                    I17F15.MinValue,
                    I17F15.MinValue);
                var ls = v.LengthSquared();
                Console.WriteLine($"ls: {ls}");
                var greater = I36F28.FromBits(long.MinValue / -2);
                Console.WriteLine($"greater: {greater}");
                if (ls > greater) {
                    Assert.Fail($"ls.Bits: {ls.Bits} greater: {greater.Bits}");
                }
                I36F28 expected;
                {
                    const long k = int.MinValue;
                    expected = I36F28.FromBits(k * k / 4 * 4);
                }
                Console.WriteLine($"expected: {expected}");
                if (ls != expected) {
                    Assert.Fail($"ls: {ls} expected: {expected}");
                }
            }
        }
    }
}
