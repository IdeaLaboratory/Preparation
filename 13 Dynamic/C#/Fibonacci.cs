using System.Collections.Generic;

namespace DP
{
    public class Fibonacci
    {
        /// <summary>
        /// Get Fibonacci number of n th element using recursion(no DP)
        /// 0th element is 1
        /// 1st element is 1
        /// 2nd element is 2
        /// so on..
        /// </summary>
        /// <param name="n">n th element</param>
        /// <returns></returns>
        public long GetFibonacci(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        Dictionary<int, long> memory = new Dictionary<int, long>();
        
        /// <summary>
        /// Fibonacci number of n th element recursively with memorization (Dynamic programming) in key value pair
        /// Memorization with Top down approach
        /// </summary>
        /// <param name="n">n th element</param>
        /// <returns></returns>
        public long GetFibonacciwithDP(int n)
        {
            long result;
            if (memory.ContainsKey(n))
            {
                long value;
                memory.TryGetValue(n, out value);
                return value;
            }

            else    // not required
            {
                if (n < 2)
                {
                    memory.Add(n, 1);
                    return 1;
                }

                result = GetFibonacciwithDP(n - 1) + GetFibonacciwithDP(n - 2);
                memory.Add(n, result);
            }
            return result;
        }

        /// <summary>
        /// Fibonacci number of n th element recursively with memorization (Dynamic programming) in array
        /// Memorization with Top down approach
        /// </summary>
        /// <param name="n">n th element</param>
        /// <returns></returns>
        public long GetFibonacciWithDPWithoutDictionary(int n)
        {
            long[] memory3 = new long[n];
            for (int i = 0; i < n; i++)
            {
                memory3[i] = -1;
            }

            return FibonacciPrivate(n - 1, memory3);
        }

        #region private methods

        private long FibonacciPrivate(int n, long[] memory3)
        {
            if (memory3[n] != -1)
            {
                return memory3[n];
            }
            else
            {
                if (n < 2)
                {
                    memory3[n] = 1;
                    return 1;
                }
                else
                {
                    long result = FibonacciPrivate(n - 1, memory3) + FibonacciPrivate(n - 2, memory3);
                    memory3[n] = result;
                    return result;
                }
            }

        } 
        #endregion
    }
}