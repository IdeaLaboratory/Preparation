using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class ProblemSolvingExperience
    {
        /// <summary>
        /// Unify
        /// Print all pairs with given sum
        /// O(N^2) and order of output is not same as description.
        /// https://www.geeksforgeeks.org/print-all-pairs-with-given-sum/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public void SumOfPairs(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine("{0} {1}", arr[i], arr[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Unify
        /// Print all pairs with given sum
        /// O(N^2) and due to sort the order of output is not same as description.
        /// https://www.geeksforgeeks.org/print-all-pairs-with-given-sum/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public IDictionary<int, int> SumOfPairs(int[] arr, int sum, int len)
        {
            var dict = new Dictionary<int, int>();
            Array.Sort(arr);

            int left = 0, right = len - 1;
            while (true)
            {
                if (left >= right)
                    break;
                if (arr[left] + arr[right] == sum)
                {
                    Console.WriteLine("{0} {1}", arr[left], arr[right]);
                    //dict.Add(arr[left], arr[right]);
                    if (left + 1 < right && arr[left] == arr[left + 1])
                    {
                        left++;
                    }
                    else if (right - 1 > left && arr[right] == arr[right - 1])
                    {
                        right--;
                    }
                    else
                    {
                        left++; right--;
                    }
                }
                else if (arr[left] + arr[right] > sum)
                {
                    right--;
                }
                else if (arr[left] + arr[right] < sum)
                {
                    left++;
                }
            }
            return dict;
        }

        /// <summary>
        /// Unify
        /// Count of n digit numbers whose sum of digits equals to given sum
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int[] FindNDigitsNumbersWithGivenSum(int n, int sum)
        {
            var list = new List<int>();
            int start = (int)Math.Pow(10, n - 1);
            int end = (int)Math.Pow(10, n) - 1;

            while (start < end)
            {
                int cur = 0;
                int temp = start;

                while (temp != 0)
                {
                    cur += temp % 10;
                    temp = temp / 10;
                }

                if (cur == sum)
                {
                    list.Add(start);
                    start += 9;
                }
                else
                    start++;
            }
            return list.ToArray();
        }
    }
}