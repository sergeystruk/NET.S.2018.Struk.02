using System;
using System.Collections.Generic;

namespace ArrayUtil
{
    /// <summary>
    /// Class provides a method for filtering an array using any digit
    /// </summary>
    public static class ArrayModifier
    {
        /// <summary>
        /// Returns an array with numbers that contains digit
        /// </summary>
        /// <param name="array">
        /// Array which is needed to be filtered
        /// </param>
        /// <param name="number">
        /// A digit is used like a filter
        /// </param>
        /// <returns>
        /// An array
        /// </returns>
        public static int[] FilterDigits(int[] array, int number)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (number < 0 || number > 9)
            {
                throw new ArgumentException(nameof(number));
            }

            int subElem;
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                subElem = array[i];
                while (subElem != 0)
                {
                    if (subElem % 10 == number)
                    {
                        list.Add(array[i]);
                    }

                    subElem /= 10;
                }
            }

            return list.ToArray();
        }
    }
}
