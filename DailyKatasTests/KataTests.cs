using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyKatas;
using NUnit.Framework;

namespace DailyKatasTests
{
    public class DailyKatasTests
    {
        [TestFixture]
        public class ClockInMirrorTests
        {
            [Test]
            [TestCase("06:35", "05:25")]
            [TestCase("11:59", "12:01")]
            [TestCase("12:02", "11:58")]
            [TestCase("12:00", "12:00")]
            [TestCase("02:00", "10:00")]
            public void ClockInMirrorTest(string timeInMirror, string expectetTime)
            {
                var receivedTime = Kata.WhatIsTheTime(timeInMirror);
                StringAssert.AreEqualIgnoringCase(expectetTime, receivedTime);
            }
        }

        [TestFixture]
        public class Rot13Tests
        {
            [Test, Description("test")]
            public void testTest()
            {
                Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
            }

            [Test, Description("Test")]
            public void TestTest()
            {
                Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
            }
        }

        [TestFixture]
        public class Rot13v2Tests
        {
            [Test, Description("test")]
            public void testTest()
            {
                Assert.AreEqual("grfg", Kata.Rot13v2("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
            }

            [Test, Description("Test")]
            public void TestTest()
            {
                Assert.AreEqual("Grfg", Kata.Rot13v2("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
            }
        }

        [TestFixture]
        public class DigPowTests
        {

            [Test]
            public void Test1()
            {
                Assert.AreEqual(1, Kata.DigPow(89, 1));
            }
            [Test]
            public void Test2()
            {
                Assert.AreEqual(-1, Kata.DigPow(92, 1));
            }
            [Test]
            public void Test3()
            {
                Assert.AreEqual(51, Kata.DigPow(46288, 3));
            }
        }

        [TestFixture]
        public class BuildTowerTests
        {
            [Test]
            public void BuildTowerTest1()
            {
                Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", Kata.TowerBuilder(1)));
            }

            [Test]
            public void BuildTowerTest2()
            {
                Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.TowerBuilder(2)));
            }

            [Test]
            public void BuildTowerTest3()
            {
                Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.TowerBuilder(3)));
            }

            [Test]
            public void BuildTowerTest4()
            {
                Assert.AreEqual(string.Join(",", new[] { "   *   ", "  ***  ", " ***** ", "*******" }), string.Join(",", Kata.TowerBuilder(4)));
            }
        }

        [TestFixture]
        public class UInt32ToIPTests
        {
            [Test]
            public void UInt32ToIPTest1()
            {
                Assert.AreEqual("128.114.17.104", Kata.UInt32ToIP(2154959208));
            }

            [Test]
            public void UInt32ToIPTest2()
            {
                Assert.AreEqual("0.0.0.0", Kata.UInt32ToIP(0));
            }

            [Test]
            public void UInt32ToIPTest3()
            {
                Assert.AreEqual("128.32.10.1", Kata.UInt32ToIP(2149583361));
            }
        }

        [TestFixture]
        public class IPToUInt32Tests
        {
            [Test]
            public void UInt32ToIPTest1()
            {
                Assert.AreEqual(2154959208, Kata.IPToUInt32("128.114.17.104"));
            }

            [Test]
            public void UInt32ToIPTest2()
            {
                Assert.AreEqual(0, Kata.IPToUInt32("0.0.0.0"));
            }

            [Test]
            public void UInt32ToIPTest3()
            {
                Assert.AreEqual(2149583361, Kata.IPToUInt32("128.32.10.1"));
            }
        }

    }
}
