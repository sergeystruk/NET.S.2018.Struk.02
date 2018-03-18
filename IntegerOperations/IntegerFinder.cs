using System;
using System.Text;
using System.Diagnostics;

namespace IntegerOperations
{
    /// <summary>
    /// Class provides methods to work with integer numbers
    /// </summary>
    public static class IntegerFinder
    {
        /// <summary>
        /// Static method which gives next bigger number
        /// </summary>
        /// <param name="initNumb">
        /// Initial number
        /// </param>
        /// <param name="ellapsedMilliSec">
        /// Time which was needed to run the application
        /// </param>
        /// <returns>
        /// Next bigger number,
        /// which contains only digits from initial number
        /// </returns>
        public static int FindNextBiggerNumber(int initNumb, out long ellapsedMilliSec)
        {
            if (initNumb < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initNumb));
            }

            Stopwatch stopWatch = Stopwatch.StartNew();

            int convertBuf = initNumb;
            int index = initNumb.ToString().Length;
            int[] digitArr = new int[index];
            while (convertBuf != 0)
            {
                digitArr[index - 1] = convertBuf % 10;
                convertBuf /= 10;
                index--;
            }

            int lastDigIndex = 0;
            for (int i = digitArr.Length - 1; i > 0; i--)
            {
                if (digitArr[i] > digitArr[i - 1])
                {
                    lastDigIndex = i;
                    break;
                }
            }

            if (lastDigIndex == 0)
            {
                ellapsedMilliSec = stopWatch.ElapsedMilliseconds;
                return -1;
            }

            int smalliest = lastDigIndex;
            for (int i = lastDigIndex + 1; i < digitArr.Length; i++)
            {
                if ((digitArr[i] > digitArr[lastDigIndex - 1]) && (digitArr[i] < digitArr[smalliest]))
                {
                    smalliest = i;
                }
            }

            Swap(ref digitArr[smalliest], ref digitArr[lastDigIndex - 1]);
            Array.Sort(digitArr, lastDigIndex, digitArr.Length - lastDigIndex);

            StringBuilder sb = new StringBuilder(digitArr.Length);

            foreach (var elem in digitArr)
            {
                sb.Append(elem);
            }

            ellapsedMilliSec = stopWatch.ElapsedMilliseconds;

            return int.Parse(sb.ToString());
        }

        /// <summary>
        /// Method to swap two integers
        /// </summary>
        /// <param name="a">
        /// First integer
        /// </param>
        /// <param name="b">
        /// Second integer
        /// </param>
        private static void Swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}
