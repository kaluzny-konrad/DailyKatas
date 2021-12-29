using NUnit.Framework;

namespace Parser.Tests
{
    public class SolutionTest
    {
        [Test]
        [TestCase(1, "one")]
        [TestCase(20, "twenty")]
        [TestCase(246, "two hundred forty-six")]
        [TestCase(200, "two hundred")]
        [TestCase(2005, "two thousand and five")]
        [TestCase(422, "four hundred twenty-two")]
        [TestCase(2046, "two thousand forty-six")]
        [TestCase(1337, "one thousand three hundred and thirty-seven")]
        [TestCase(1358, "one thousand three hundred fifty-eight")]
        [TestCase(26359, "twenty-six thousand three hundred and fifty-nine")]
        [TestCase(27736, "twenty-seven thousand seven hundred and thirty-six ")]
        [TestCase(0, "dominik")]
        public void FixedTest1(int result, string input)
        {
            Assert.AreEqual(result, Parser.ParseInt(input));
        }
    }
}