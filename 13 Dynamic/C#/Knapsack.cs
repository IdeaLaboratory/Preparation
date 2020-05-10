using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP
{
    /// <summary>
    /// This a 0-1 knapsack solution using dynamic programming technique
    /// </summary>
    public class Knapsack
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxWeight">Maximum weight that the knapsack can carry</param>
        /// <param name="itemValues">value of each item</param>
        /// <param name="itemWeights">weight of each item</param>
        /// <returns></returns>
        public int GetMaxValue(int maxWeight, int[] itemValues, int[] itemWeights)
        {
            /// Generate a matrix where columns are weights from 0 to max weight.
            /// each row consider each item.
            /// cell value must consider previous value as well
            int[,] knapsackValueMatrix = new int[itemWeights.Length + 1, maxWeight + 1];

            for (int i = 0; i <= itemWeights.Length; i++)
            {
                for (int j = 0; j <= maxWeight; j++)
                {
                    // fill first row and first column with zero.
                    if (i == 0 || j == 0)
                    {
                        knapsackValueMatrix[i, j] = 0;
                        continue;
                    }

                    //we will proceed considering each item and previous row that is previous item.

                    // If item can be fit into knapsack at this moment?
                    if (itemWeights[i - 1] <= j)
                    {
                        int current = itemValues[i - 1] + knapsackValueMatrix[i - 1, j - itemWeights[i - 1]];
                        int previous = knapsackValueMatrix[i - 1, j];
                        knapsackValueMatrix[i, j] = Math.Max(current, previous);
                    }
                    else
                    {
                        knapsackValueMatrix[i, j] = knapsackValueMatrix[i - 1, j];
                    }
                }
            }

            for (int i = 0; i <= knapsackValueMatrix.GetLength(0); i++)
            {
                for (int j = 0; j<= knapsackValueMatrix.GetLength(0); j++)
                {
                    Console.Write(knapsackValueMatrix[i,j]);
                }
                Console.WriteLine();
            }

            return knapsackValueMatrix[itemWeights.Length, maxWeight];
        }
    }
}
