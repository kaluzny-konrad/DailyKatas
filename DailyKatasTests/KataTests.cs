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
    }
}
