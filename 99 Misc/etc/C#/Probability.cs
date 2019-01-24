using System;
using System.Collections.Generic;

namespace Etc
{
    public class Probability
    {
        public int GetRandomNumberInRange(int min, int max, int maskMin, int maskMax, double expProb)
        {
            Random r = new Random();
            int rNum = r.Next(min, max); //for ints

            if (rNum >= 80 && rNum <= 99)
            {
                rNum = ProbabilityMaskUtil(rNum, maskMin, maskMax, expProb * 100);
            }

            return rNum;
        }

        private int ProbabilityMaskUtil(int val, int min, int max, double expProbability)
        {
            HashSet<int> bucket = new HashSet<int>();
            Random r = new Random();

            FillBucketUtil(min, max, expProbability, bucket, r);

            if (bucket.Contains(val))
            {
                return val;
            }
            else
            {
                return r.Next(0, min - 1);
            }
        }

        private static void FillBucketUtil(int min, int max, double expProbability, HashSet<int> bucket, Random r)
        {
            int rNum = r.Next(min, max); //for ints

            for (int i = 0; i < expProbability; i++)
            {
                if (bucket.Contains(rNum))
                {
                    FillBucketUtil(min, max, expProbability - i, bucket, r);
                    return;
                }
                bucket.Add(rNum);
            }

            rNum = r.Next(min, max); //for ints
        }
    }
}
