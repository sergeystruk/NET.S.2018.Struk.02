using System;

namespace IntegerOperations
{
    /// <summary>
    /// Class provides methods to work with integer numbers
    /// </summary>
    public class IntegerFinder
    {
        /// <summary>
        /// Static method which gives next bigger number
        /// </summary>
        /// <param name="initNumb">
        /// Initial number
        /// </param>
        /// <returns>
        /// Next bigger number,
        /// which contains only digits from initial number
        /// </returns>
        public int FindNextBiggerNumber(int initNumb)
        {
            if (initNumb < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

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
            int result = 0;
            for (int i = 0; i < digitArr.Length; i++)
            {
                result += digitArr[i] * Convert.ToInt32(Math.Pow(10, digitArr.Length - i - 1));
            }

            return result;
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
        private void Swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}