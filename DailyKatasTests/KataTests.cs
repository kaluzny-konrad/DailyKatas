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
    }
}
