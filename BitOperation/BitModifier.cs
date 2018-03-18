using System;
namespace BitOperation
{
    /// <summary>
    /// Static class which works with bites
    /// </summary>
    public static class BitModifier
    {
        /// <summary>
        /// Inserts bytes of first number into second number
        /// lefting second number's bytes on positions from start to end
        /// </summary>
        /// <param name="a"> 
        /// First number
        /// </param>
        /// <param name="b">
        /// Second Number
        /// </param>
        /// <param name="start">
        /// Start index
        /// </param>
        /// <param name="end">
        /// End index
        /// </param>
        /// <returns>
        /// New int
        /// </returns>
        public static int InsertNumber(int a, int b, int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException(nameof(start));
            }

            if (start < 0 || start > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(start));
            }

            if (end < 0 || end > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(end));
            }

            string firstNum = Convert.ToString(a, 2);
            string secondNum = Convert.ToString(b, 2);
            char[] firstNumChar = new char[32];
            char[] secondNumChar = new char[32];
            int countFirstLen = firstNum.Length - 1;
            int countSecondLen = secondNum.Length - 1;
            for (int i = 31; i >= 0; i--)
            {
                if (i > 31 - firstNum.Length)
                {
                    firstNumChar[i] = firstNum[countFirstLen];
                    countFirstLen--;
                }
                else
                {
                    firstNumChar[i] = '0';
                }

                if (i > 31 - secondNum.Length)
                {
                    secondNumChar[i] = secondNum[countSecondLen];
                    countSecondLen--;
                }
                else
                {
                    secondNumChar[i] = '0';
                }
            }

            char[] result = new char[32];
            int count = 31;

            for (int i = 31; i >= 0; i--)
            {
                if (i >= 31 - end && i <= 31 - start)
                {
                    result[i] = secondNumChar[count];
                    count--;
                }
                else
                {
                    result[i] = firstNumChar[i];
                }
            }

            return Convert.ToInt32(new string(result), 2);
        }
    }
}
