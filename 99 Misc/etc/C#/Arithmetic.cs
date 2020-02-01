using System;
using System.Collections.Generic;

namespace Etc
{
    public class Arithmetic
    {
        /// <summary>
        /// provides the highest increasing number.
        /// Example: if 121 is given as the limit, HighestIncreasing number will be 119;</summary>
        /// <returns></returns>
        public int GetHighestIncreasingNumber(int limit)
        {
            int result = 0;

            //Iteration from max
            //Complexity best case O(1) worst case O(n) technically
            for (int i = limit; i > 0; i--)
            {
                if (IsIncreasingSequence(i))
                    return i;
            }

            return result;
        }

        #region private methods

        /// <summary>
        /// Complexity O(log10 n)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool IsIncreasingSequence(int i)
        {
            var digits = BreakIntoDigits(i);
            int oldValue = 0;
            foreach (int item in digits)
            {
                if (oldValue > item)
                    return false;
                oldValue = item;
            }
            return true;
        }


        /// <summary>
        /// BreakIntoDigits will break 121 into 1,2,1 in constant time (max 6 digit number).
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="digits"></param>
        private List<int> BreakIntoDigits(int limit)
        {
            var digits = new List<int>();
            int temp = limit;
            while (temp > 0)
            {
                digits.Add(temp % 10);
                temp = temp / 10;
            }
            digits.Reverse();
            return digits;
        } 
        #endregion
    }
}
