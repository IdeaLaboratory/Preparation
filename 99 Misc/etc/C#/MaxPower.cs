using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class MaxPower
    {
        public int FindMaxPower(int val)
        {
            int sqrtVal = (int)Math.Sqrt(val);
            int[] divisorArr = new int[sqrtVal + 1];

            GetAllFactors(val, divisorArr);

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

        private void GetAllFactors(int val, int[] divisorArr)
        {
            int tempVal = val;

            bool hasDivided = false;
            for (int i = 2; i <= (int)Math.Sqrt(val); i++)
            {
                if (tempVal % i == 0)
                {
                    divisorArr[i] += 1;
                    tempVal = tempVal / i;
                    hasDivided = true;
                    GetAllFactors(tempVal, divisorArr);
                    break;
                }
            }
            if (!hasDivided && tempVal <= divisorArr.Length)
                divisorArr[tempVal] += 1;
        }
    }
}
