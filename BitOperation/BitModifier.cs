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
        /// leaving second number's bytes on positions from start to end
        /// </summary>
        /// <param name="firstNumb"> 
        /// First number
        /// </param>
        /// <param name="secondNumb">
        /// Second Number
        /// </param>
        /// <param name="start">
        /// Start index
        /// </param>
        /// <param name="end">
        /// End index
        /// </param>
        /// <returns>
        /// New number
        /// </returns>
        public static int InsertNumber(int firstNumb, int secondNumb, int start, int end)
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

            int startToEndOnes = int.MaxValue >> 31 - (end - start + 1);
            startToEndOnes <<= start;
            firstNumb &= ~startToEndOnes;
            int overFlowChecker = int.MaxValue;
            overFlowChecker >>= 31 - (end - start + 1);
            overFlowChecker &= secondNumb;
            overFlowChecker <<= start;
            overFlowChecker &= startToEndOnes;
            return firstNumb | overFlowChecker;
        }
    }
}
