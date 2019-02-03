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

            //solution 1
            for (int i = limit; i > 0; i--)
            {
                if (IsIncreasingSequence(i))
                    return i;
            }

            //solution 2
            /*List<int> digits = new List<int>();
            BreakIntoDigits(limit, digits);

            for (int j = 0; j < digits.Count; j++)
            {
                // ToDO: Start considering from most significant digit and see if it povides highest increasing number.
                // Otehrwise fall back and try with different value.
            }*/
            
            return result;
        }

        private bool IsIncreasingSequence(int i)
        {
            List<int> digits = new List<int>();
            BreakIntoDigits(i, digits);
            int oldValue=0;
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
        private void BreakIntoDigits(int limit, List<int> digits)
        {
            int temp = limit;
            while (temp > 0)
            {
                digits.Add(temp % 10);
                temp = temp / 10;
            }
            digits.Reverse();
        }
    }
}
