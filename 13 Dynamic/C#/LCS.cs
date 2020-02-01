using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP
{

    /* C#  Naive recursive implementation of LCS problem */
    using System;

    public class LongestCommonSubsequence
    {
        /* Returns length of LCS for X[0..length1-1], inputString2[0..n-1] */
        public static int FindLongestCommonSubsequence(char[] inputString1, char[] inputString2, int length1, int length2)
        {
            if (length1 == 0 || length2 == 0)
                return 0;
            if (inputString1[length1 - 1] == inputString2[length2 - 1])
                return 1 + FindLongestCommonSubsequence(inputString1, inputString2, length1 - 1, length2 - 1);
            else
                return GetMax(FindLongestCommonSubsequence(inputString1, inputString2, length1, length2 - 1), 
                    FindLongestCommonSubsequence(inputString1, inputString2, length1 - 1, length2));
        }

        /* Utility function to get max of 2 integers */
        public static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
