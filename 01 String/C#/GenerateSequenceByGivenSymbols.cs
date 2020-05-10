using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class GenerateSequenceByGivenSymbols
    {
        /// <summary>
        /// Given a string S which contains only I (increase) and D (decrease). 
        /// The task is to return any permutation of integers [0, 1, …, N] where N ≤ Length of S such that for all i = 0, …, N-1:
        /// If S[i] == “D”, then A[i] > A[i + 1]
        /// If S[i] == “I”, then A[i] < A[i + 1].
        /// Output must contain distinct elements.
        /// </summary>
        /// 
        /// <param name="chararacters">DDI</param>
        /// <returns>[3, 2, 0, 1]</returns>
        public int[] GenerateSequence(char[] chararacters)
        {
            // As elements must be distinct, the digits must be 0 to number of characters.
            // lets consider a minimum and maximum
            int min = 0; int max = chararacters.Length;
            int[] result = new int[max + 1]; int i;

            //Based input incrementing order (01) or decrement order (10) depends on the input symbol or character.
            for (i = 0; i < chararacters.Length; i++)
            {
                switch (chararacters[i])
                {
                    case 'D':
                        result[i] = max--;
                        break;
                    case 'I':
                        result[i] = min++;
                        break;
                }
            }

            //complete the sequence
            result[i] = min;

            return result;
        }
    }
}
