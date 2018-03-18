using System;
using NUnit.Framework;

namespace BitOperation.Tests
{
    public class BitModifierTests
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumber_TestWithDiffValues(int a, int b, int i, int j)
            => BitModifier.InsertNumber(a, b, i, j);

        [Test]
        public void InsertNumber_TestWithNegative() 
            => Assert.Throws<ArgumentOutOfRangeException>(() => BitModifier.InsertNumber(8, 15, -4, -4));
        [Test]
        public void InsertNumber_TestEndLessThenStart()
            => Assert.Throws<ArgumentOutOfRangeException>(() => BitModifier.InsertNumber(8, 15, 15, 8));
        [Test]
        public void InsertNumber_TestIndexOverFlow()
            => Assert.Throws<ArgumentOutOfRangeException>(() => BitModifier.InsertNumber(8, 15, 34, 0));
    }
}
