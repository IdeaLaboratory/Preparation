using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class MaxPower
    {
        /// <summary>
        /// This will find the max number of occurance of it's factor.
        /// Example: number = 250. Factors are 2, 5, 5, 5.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public int FindMaxOccuranceOfFactors(int val)
        {
            int sqrtVal = (int)Math.Sqrt(val);
            int[] divisorArr = new int[sqrtVal + 1];

            var allFactors = GetAllFactors(val, divisorArr);
            
            //if (allFactors.Count >= 2)
            //    Console.WriteLine(allFactors[1]);   //allFactors[0] is the lowest factor and allFactors[1] is the max factor.

            int max = 1;
            for (int i = 0; i <= sqrtVal; i++)
            {
                if (divisorArr[i] > max)
                {
                    max = divisorArr[i];
                }
            }

            return max;
        }

        private List<int> GetAllFactors(int val, int[] divisorArr)
        {
            int tempVal = val;
            List<int> allFactors = new List<int>();
            bool hasDivided = false;
            var sqrt = (int)Math.Sqrt(val);

            for (int i = 2; i <= sqrt; i++)
            {
                if (tempVal % i == 0)
                {
                    tempVal = tempVal / i;
                    allFactors.Add(i);
                    allFactors.Add(tempVal);
                    divisorArr[i] += 1;
                    hasDivided = true;
                    GetAllFactors(tempVal, divisorArr);
                    break;
                }
            }
            if (!hasDivided && tempVal <= divisorArr.Length)
                divisorArr[tempVal] += 1;

            return allFactors;
        }
    }
}
