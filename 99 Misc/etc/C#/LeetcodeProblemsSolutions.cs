using System;
using System.Collections.Generic;
using System.Linq;

namespace Etc
{
    public class LeetcodeProblemsSolutions : ILeetcodeProblemsSolutions
    {

        ///<see cref = "ILeetcodeProblemsSolutions.CountElement" />
        public int CountElement(int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (arr.Contains(item + 1))
                {
                    count++;
                }
            }
            return count;
        }

        ///<see cref = "ILeetcodeProblemsSolutions.BestTimeToBuyAndSellStock" />
        public int BestTimeToBuyAndSellStock(int[] arr)
        {
            int n = arr.Length;
            int[,] dp = new int[n, 2];
            for (int i = 0; i < arr.Length; i++)
            {
                int stk = arr[i];

            }
            return 0;
        }

        public int FindSingleNumber(int[] nums)
        {
            int r = 0;
            foreach (var n in nums)
            {
                r ^= n;
            }
            return r;
        }

        public List<List<string>> GroupAnagrams(List<string> text)
        {
            throw new NotImplementedException();
        }

        public bool IsHappyNumber(int n)
        {
            int sum = GetDigits(n);
            for (int i = 0; i < 50; i++)
            {
                n = GetDigits(n);
                if (n == 1)
                {
                    return true;
                }
            }

            return false;
        }

        private int GetDigits(int n)
        {
            List<int> list = new List<int>();
            int s = 0;
            while (n > 0)
            {
                s += (n % 10) * (n % 10);
                n /= 10;
            }
            return s;
        }

        ///<see cref = "ILeetcodeProblemsSolutions.MaximumSubarray(int[])" />
        ///Kadane's algorithm, greedy (or may be dp) approach.
        public int MaximumSubarray(int[] arr)
        {
            int max = int.MinValue;
            int sum = 0;

            foreach (var item in arr)
            {
                sum = Math.Max(0, sum + item);
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }

        ///<see cref = "ILeetcodeProblemsSolutions.MoveZero(int[]) />
        /// [0,4,5,1,0] becomes [4,5,1,0,0]
        public int[] MoveZero(int[] arr)
        {
            int i = 0;
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    continue;
                }
                arr[i] = item;
                i++;
            }
            for (int j = i; j < arr.Length; j++)
            {
                arr[j] = 0;
            }
            return arr;
        }

        public int PrefixSum(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int BestTimeToBuyAndSellStock(List<int> arr)
        {
            throw new NotImplementedException();
        }

        ///<see cref = "ILeetcodeProblemsSolutions.FindTheMiddleNodeOfLinklist" />
        public int FindTheMiddleNodeOfLinklist(LinkedList<int> linkedList)
        {
            var root = linkedList.First;

            var turtle = root;
            var rabbit = root;

            while (rabbit != null)
            {
                rabbit = rabbit.Next;
                if (rabbit == null)
                {
                    return turtle.Value;
                }

                turtle = turtle.Next;
                rabbit = rabbit.Next;
            }

            return turtle.Value;
        }

        public bool BackpaceStringsAreEqual(string s1, string s2)
        {
            var l = AfterBackspace(s1);
            var r = AfterBackspace(s2);
            return l == r;
        }

        private string AfterBackspace(string s1)
        {
            string rs11 = null;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i] == '#')
                    i--;
                else
                    rs11 += s1[i];
            }
            return rs11;
        }

        ///<see cref = "ILeetcodeProblemsSolutions.MinValueStack" />
        public int MinValueStack(Stack<int> stack)
        {
            throw new NotImplementedException();
        }

        public int DiameterofBinaryTree(object root)
        {
            throw new NotImplementedException();
        }

        ///<see cref = "ILeetcodeProblemsSolutions.ContiguousArrayLength" />
        ///[0,1,0,1,1] => 0,0,1,1 => 2
        public int ContiguousArrayLength(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
                }
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            var result = (arr.Length - Math.Abs(sum)) / 2;
            return result;
        }

        public void ShiftingString(string str, int[,] arr)
        {
            // arr[0]==0 means left rotate, arr[0] ==1 means right rotate
            // arr[1] is the number of time of rotate.
            // 
        }

        ///<see cref = "ILeetcodeProblemsSolutions.ProductExceptSelf" />
        ///[2,3,4] = [12,8,6]
        public int[] ProductExceptSelf(int[] arr)
        {
            int[] resultArray = new int[arr.Length];
            int r = 1; int zero = 0;
            foreach (int i in arr)
            {
                if (i == 0)
                {
                    zero++;
                    continue;
                }

                r = r * i;
            }

            if (zero > 1)
            {
                return resultArray;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (zero == 1 && arr[i] == 0)
                {
                    resultArray[i] = r;
                    return resultArray;
                }
                else
                {
                    resultArray[i] = r / arr[i];
                }
            }
            return resultArray;
        }

        ///<see cref = "ILeetcodeProblemsSolutions.ProductExceptSelf" />
        ///[2,3,4] = [12,8,6]
        public int[] ProductExceptSelf_2(int[] arr)
        {
            List<int> result = new List<int>();
            List<int> pref_product = new List<int>();
            List<int> suf_product = new List<int>();

            pref_product.Add(1);
            for (int i = 0; i < arr.Length; i++)
            {
                pref_product.Add(pref_product[i] * arr[i]);
            }

            suf_product.Add(1);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                suf_product.Add(suf_product[i] * arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(pref_product[i] * suf_product[i]);
            }

            return result.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidParenthesis(string s)
        {
            var leftToRight = IsValidLeftToright(s);
            var r = new string(s.Reverse().ToArray());
            var rightToLeft = IsValidLeftToright(r);
            return leftToRight & rightToLeft;
        }

        private bool IsValidLeftToright(string s)
        {
            int b = 0, star = 0;
            foreach (var v in s)
            {
                if (v == '(')
                    b++;
                else if (v == ')')
                {
                    b--;
                    if (b + star < 0)
                        return false;
                }
                else if (v == '*')
                {
                    if (b > 0)
                    {
                        b--;
                    }
                    else if (b < 0)
                    {
                        b++;
                    }
                    else
                        star++;
                }
            }
            if (Math.Abs(b) > star)
                return false;

            return true;
        }

        public int LastStoneWeight(int[] weights)
        {
            throw new NotImplementedException();
        }

        public void ShiftingString(string str)
        {
            throw new NotImplementedException();
        }

        public int NumberofIslands(char[][] arr)
        {
            throw new NotImplementedException();
        }

        public int MinPathSum(int[][] grid)
        {
            throw new NotImplementedException();
        }

        public int SearchInRotatedSortedArray(int[] arr)
        {
            throw new NotImplementedException();
        }

        public object BstFromPreorder(int[] preorder)
        {
            throw new NotImplementedException();
        }
    }
}
