using System;
using NUnit.Framework;

namespace IntegerOperations.Tests
{
    public class IntegerFinderTests
    {
        [TestCase(12, 0L, ExpectedResult = 21)]
        [TestCase(513, 0L, ExpectedResult = 531)]
        [TestCase(2017, 0L, ExpectedResult = 2071)]
        [TestCase(414, 0L, ExpectedResult = 441)]
        [TestCase(144, 0L, ExpectedResult = 414)]
        [TestCase(1234321, 0L, ExpectedResult = 1241233)]
        [TestCase(1234126, 0L, ExpectedResult = 1234162)]
        [TestCase(3456432, 0L, ExpectedResult = 3462345)]
        [TestCase(10, 0L, ExpectedResult = -1)]
        [TestCase(20, 0L, ExpectedResult = -1)]
        public int FindNextBiggerNumber_TestWithDiffNumbs(int a, out long l) 
            => IntegerFinder.FindNextBiggerNumber(a, out l);

        [Test]
        public void FindNextBiggerNumber_WithNegative_ThrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => IntegerFinder.FindNextBiggerNumber(-321, out _));
    }
}
