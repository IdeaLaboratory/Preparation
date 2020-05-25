using DP;
using Etc;
using Graph;
using Strings;
using System.Collections.Generic;
using System.Linq;

namespace Preparation
{
    public class MainDriverClass
    {
        static void Main(string[] args)
        {
            int[] ar = { 0, 1, 0, 0, 0, 1 };
            ProblemSolvingExperience exp = new ProblemSolvingExperience();
            exp.SumOfPairs(ar, 6);
            var nu = exp.FindNDigitsNumbersWithGivenSum(2, 5);

            LeetcodeProblemsSolutions solutions = new LeetcodeProblemsSolutions();
            solutions.MoveZero(ar);
            solutions.ContiguousArrayLength(ar);
            var count_1 = solutions.CountElement(new int[] { 0, 1, 3, 4, 8 });
            var v = solutions.ProductExceptSelf(new int[] { 0, 1, 3, 5, 8 });
            var b = solutions.ValidParenthesis("((*)(*))((*");


            var list = new List<string>();
            list.Add("aid");
            list.Add("dia");
            list.Add("ida");
            list.Add("mon");
            list.Add("mno");


            Anagram anagram = new Anagram();
            var distList = anagram.RemoveAnagrams(list);

            Xor x = new Xor();
            var single = x.GetSingelEntry(new System.Collections.Generic.List<int> { 5, 4, 3, 4, 5 });

            IGraph<int> g = new Graph<int>();
            g.AddEdge(5, 2);
            g.AddEdge(5, 0);
            g.AddEdge(4, 0);
            g.AddEdge(4, 1);
            g.AddEdge(2, 3);
            g.AddEdge(3, 1);

            var result = (g as Graph<int>).TropologicalSort();
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

            LargestSquareInMatrix matrix = new LargestSquareInMatrix();
            int[,] arr = new int[,] {
                { 0, 1, 1, 0, 0 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1 } };

            int max = matrix.GetLargestSquare(arr);
            //Knapsack knapsack = new Knapsack();
            //int[] weights = { 1, 2, 3 };
            //int[] values = { 2, 4, 5 };
            //int maxWeight = 6;
            //Console.WriteLine(knapsack.GetMaxValue(maxWeight, values, weights));

            GenerateSequenceByGivenSymbols generate = new GenerateSequenceByGivenSymbols();
            var seq = generate.GenerateSequence("DIDD".ToCharArray());
            //Stopwatch sw;
            Arithmetic al = new Arithmetic();
            //Console.WriteLine("GetHighestIncreasingNumber");
            //Console.WriteLine(al.GetHighestIncreasingNumber(122));
            //Console.WriteLine();

            //// find max power
            //MaxPower mxPow = new MaxPower();
            //Console.WriteLine(mxPow.FindMaxOccuranceOfFactors(250));

            ////CustomDate check

            //CustomDate date = new CustomDate(29, 2, 2016);
            //Console.WriteLine(date.IsValid());
            //CustomDate date1 = new CustomDate(29, 2, 2017);
            //Console.WriteLine(date1.IsValid());
            //CustomDate date2 = new CustomDate(29, 21, 2016);
            //Console.WriteLine(date2.IsValid());
            //CustomDate date3 = new CustomDate(29, 2, 3016);
            //Console.WriteLine(date3.IsValid());
            //CustomDate date4 = new CustomDate(33, 2, 2016);
            //Console.WriteLine(date4.IsValid());

            //GroupOccurrencesCharacters obj = new GroupOccurrencesCharacters();
            //var newString = obj.GroupOccChar("abczabac");
            //Console.WriteLine(newString);


            //Tree.Trie trie = new Tree.Trie();
            //trie.Insert("hel");
            //trie.Insert("helaate");
            //trie.Insert("help");
            //trie.Insert("hell");
            //trie.Insert("hello");
            //trie.Insert("helps");
            //trie.Insert("has");
            //trie.Insert("hes");

            //var list = trie.Suggestions("hel");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //sw = Stopwatch.StartNew();
            //////////////Write your code here to measure performance////////////
            //Backtrack.NQueen nQueen = new Backtrack.NQueen();
            //int n = 4;
            //int[,] positions = new int[n, n];
            //nQueen.GetQueenPositions(positions, 0);

            ////for (int i = 0; i < positions.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < positions.GetLength(0); j++)
            ////    {
            ////        Console.Write(positions[i, j] + ",");
            ////    }
            ////    Console.WriteLine();
            ////}

            //String s1 = "abcd";
            //String s2 = "xxabcWdt";

            //char[] X = s1.ToCharArray();
            //char[] Y = s2.ToCharArray();
            //int m = X.Length;
            //int n = Y.Length;

            //Console.Write("Length of LCS is" + " "
            //              + LongestCommonSubsequence.FindLongestCommonSubsequence(X, Y, m, n));

            //Console.WriteLine();
            //Console.WriteLine();
            //////////////////////////
            //sw.Stop();
            //Console.WriteLine("==========Elapsed time=========");
            //Console.WriteLine(sw.Elapsed);
            //Console.Read();

            //Fibonacci f = new Fibonacci();
            //var series = f.GetFibonacci(5);

            //sw = Stopwatch.StartNew();
            //for (int i = 0; i < 40; i++)
            //{
            //    Console.WriteLine("Fib of {0}th number is {1}",i, f.GetFibonacci(i));
            //}
            //sw.Stop();
            //Console.WriteLine("==========Elapsed time========= \n GetFibonacci without DP");
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine();

            //sw = Stopwatch.StartNew();
            //for (int i = 0; i < 40; i++)
            //{
            //    Console.WriteLine("Fib of {0} is {1}", i, f.GetFibonacciwithDP(i));
            //}
            //sw.Stop();
            //Console.WriteLine("==========Elapsed time========= \n GetFibonacciwithDP");
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine();

            //BinarySearchTree<int> myTree = new BinarySearchTree<int>();
            //myTree.Insert(5);
            //myTree.Insert(3);
            //myTree.Insert(9);
            //myTree.Insert(7);
            //myTree.Insert(99);
            //myTree.Insert(1);

            //Console.WriteLine("PrintBFS");
            //myTree.PrintBFS();

            //Console.WriteLine("PrintDFSPreorder");
            //myTree.PrintDFSPreorder();

            //Console.WriteLine("Remove");
            //myTree.Remove(99);

            //Console.WriteLine("PrintDFSInorder");
            //myTree.PrintDFSInorder();

            //myTree.PrintDFSPostOrder();
            //myTree.LeafNode();
            //myTree.Edge();
            //myTree.BFSWithoutRecursion();
        }
    }
}