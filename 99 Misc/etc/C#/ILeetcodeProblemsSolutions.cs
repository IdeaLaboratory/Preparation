using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public interface ILeetcodeProblemsSolutions
    {
        /// <summary>
        /// #1
        /// Find the number from an array which has only one occurrence,
        /// Where other number has two occurrences.
        /// https://leetcode.com/problems/single-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int FindSingleNumber(int[] nums);

        /// <summary>
        /// #2
        /// Determine if the number is a happy number
        /// "Break the number into digits, square the digits and add them". Repeat the process until sum is 1.
        /// If we cannot reach to 1, number is not a happy number.
        /// https://leetcode.com/problems/happy-number/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        bool IsHappyNumber(int n);

        /// <summary>
        /// #3
        /// Kadane's algorithm
        /// Find the maximum sum of subarray
        /// [-1,2,-3,4,-1,2,-5] is 5 => [4,-1,2,]
        /// https://leetcode.com/problems/maximum-subarray/
        /// </summary>
        /// <param name="str"></param>
        int MaximumSubarray(int[] arr);

        /// <summary>
        /// #3.5
        /// subarray = pref[j] - pref[i-j];
        /// https://www.geeksforgeeks.org/prefix-sum-array-implementation-applications-competitive-programming/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int PrefixSum(int[] nums);

        /// <summary>
        /// #4
        /// Move the zero to the last keeping relative positions.
        /// [0,4,5,1,0] becomes [4,5,1,0,0]
        /// https://leetcode.com/problems/move-zeroes/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int[] MoveZero(int[] arr);

        //two pointer


        /// <summary>
        /// #5
        /// Best Time to Buy and Sell Stock, note: you are allowed multiple transactions.
        /// [7,1,5,3,6,4] => 4 + 3 = 7
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int BestTimeToBuyAndSellStock(int[] arr);

        /// <summary>
        /// #5
        /// Best Time to Buy and Sell Stock, note: you are allowed only one transactions.
        /// [7,1,5,3,6,4] => 5
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int BestTimeToBuyAndSellStock(List<int> arr);

        // learn iterative Dp


        /// <summary>
        /// #6
        /// Anagrams and Canonical Form
        /// Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
        /// Output:
        /// [
        ///   ["ate","eat","tea"],
        ///   ["nat","tan"],
        ///   ["bat"]
        /// ]
        /// https://leetcode.com/problems/group-anagrams/
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        List<List<string>> GroupAnagrams(List<string> text);

        /// <summary>
        /// #7
        /// count the number of elements where the element k and k+1 both are present in the array.
        /// [0,1,3,4,8] = 0,1 and 3,4 => 2
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int CountElement(int[] arr);

        /// <summary>
        /// #8
        /// Find the middle element of a linked list. This I have done in college using fast and slow technique. Will do the same.
        /// https://leetcode.com/problems/middle-of-the-linked-list/
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        int FindTheMiddleNodeOfLinklist(LinkedList<int> linkedList);

        /// <summary>
        /// #9
        /// Backspace String Compare in O(1) Space
        /// https://leetcode.com/problems/backspace-string-compare/
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        bool BackpaceStringsAreEqual(string s1, string s2);

        /// <summary>
        /// #10
        /// Min stack where top() always returns lowest value.
        /// https://leetcode.com/problems/min-stack/
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        int MinValueStack(Stack<int> stack);

        /// <summary>
        /// #11
        /// Diameter of a binary tree
        /// https://leetcode.com/problems/diameter-of-binary-tree/
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        int DiameterofBinaryTree(object root);

        /// <summary>
        /// #12
        /// </summary>
        /// <returns></returns>
        int LastStoneWeight(int[] weights);

        /// <summary>
        /// #13
        /// find the maximum length of a contiguous subarray with equal number of 0 and 1
        /// https://leetcode.com/problems/contiguous-array/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int ContiguousArrayLength(int[] arr);

        /// <summary>
        /// #13
        /// https://leetcode.com/problems/shifting-letters/
        /// </summary>
        /// <param name="str"></param>
        void ShiftingString(string str);

        /// <summary>
        /// #15
        /// [2,3,4]=>[12,8,6]
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int[] ProductExceptSelf(int[] arr);

        //Prefix sum

        /// <summary>
        /// #16
        /// 678. Valid Parenthesis String
        /// "((*)(*))((*" => false
        /// https://leetcode.com/problems/valid-parenthesis-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool ValidParenthesis(string s);

        /// <summary>
        /// #17
        /// https://leetcode.com/problems/number-of-islands/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        int NumberofIslands(char[][] arr);

        /// <summary>
        /// #18
        /// Given a m x n grid filled with non-negative numbers, 
        /// find a path from top left to bottom right which minimizes the sum of all numbers along its path.
        /// Note: You can only move either down or right at any point in time.
        /// Input:
        /// [[1,3,1],
        /// [1,5,1],
        /// [4,2,1]]
        /// Output: 7
        /// Explanation: Because the path 1→3→1→1→1 minimizes the sum.
        /// https://leetcode.com/problems/minimum-path-sum/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        int MinPathSum(int[][] grid);

        /// <summary>
        /// #19
        /// https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>index of the element if found or -1</returns>
        int SearchInRotatedSortedArray(int[] arr);

        /// <summary>
        /// #20
        /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
        /// </summary>
        /// <param name="preorder"></param>
        /// <returns></returns>
        object BstFromPreorder(int[] preorder);
    }
}