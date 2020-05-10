using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP
{
    /// <summary>
    /// 

    /// </summary>
    public class LargestSquareInMatrix
    {
        /// <summary>
        /// For example: A Matrix is given with 0 and 1 as below
        /// 1 0 1 0 0
        /// 1 0 1 1 1
        /// 1 1 1 1 1
        /// 1 0 0 1 0
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns> 4, as largest square is 2x2. </returns>
        public int GetLargestSquare(int[,] matrix)
        {
            int[,] lenthMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                lenthMatrix[row, 0] = matrix[row, 0];
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                lenthMatrix[0, col] = matrix[0, col];
            }

            int max = 0;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        lenthMatrix[row, col] = 1 + Min(lenthMatrix[row - 1, col], lenthMatrix[row, col - 1], lenthMatrix[row - 1, col - 1]);

                        if (lenthMatrix[row, col] > max)
                            max = lenthMatrix[row, col];
                    }
                }
            }

            return max * max;
        }

        private int Min(params int[] nums)
        {
            int min = int.MaxValue;
            foreach (var n in nums)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        }
    }
}
