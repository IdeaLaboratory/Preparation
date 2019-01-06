using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class MaxPower
    {
        List<int> divisors = new List<int>();

        public int FindMaxPower(int val)
        {
            int sqrtVal = (int)Math.Sqrt(val);
            GetAllFactors(val, sqrtVal);

            int max = -1;
            for (int i = 0; i <= sqrtVal; i++)
            {
                if (divisors[i] > max)
                {
                    max = divisors[i];
                }
            }

            return max;
        }

        private void GetAllFactors(int val, int sqrtVal)
        {
            int tempVal = val;

            bool hasDivided = false;
            for (int i = 2; i <= sqrtVal; i++)
            {
                if (tempVal % i == 0)
                {
                    divisors.Add(i);
                    tempVal = tempVal / i;
                    hasDivided = true;
                    GetAllFactors(tempVal, (int)Math.Sqrt(tempVal));
                    break;
                }
            }
            if (!hasDivided)
                divisors.Add(tempVal);
        }
    }
}
