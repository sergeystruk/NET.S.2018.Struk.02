using System;
using NUnit.Framework;

namespace ArrayUtil.NUnitTests
{
    [TestFixture]
    public class ArrayUtilTests
    {
        [TestCase(new int[] { 12, 13, 99, 14, 26, 15 }, 1, ExpectedResult = new int[] { 12, 13, 14, 15 })]
        public int[] FilterDigits_TestArray(int[] array, int number)
        {
            return ArrayModifier.FilterDigits(array, number);
        }

        [Test]
        public void FilterDigits_Null_ArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => ArrayModifier.FilterDigits(null, 0));

        [Test]
        public void FilterDigits_NumberIsMoreThan9_ArgumentException()
            => Assert.Throws<ArgumentException>(() => ArrayModifier.FilterDigits(Array.Empty<int>(), 24));
    }
}
