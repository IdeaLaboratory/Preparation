using DP;
using System;
using System.Diagnostics;
using Strings;
using Etc;
using System.Text;
using System.IO;
using Tree;

namespace Preparation
{
    public class MainDriverClass
    {
        static void Main(string[] args)
        {
            Stopwatch sw;
            Arithmetic al = new Arithmetic();
            Console.WriteLine("GetHighestIncreasingNumber");
            Console.WriteLine(al.GetHighestIncreasingNumber(122));
            Console.WriteLine();

            // find max power
            MaxPower mxPow = new MaxPower();
            Console.WriteLine(mxPow.FindMaxOccuranceOfFactors(250));

            //CustomDate check

            CustomDate date = new CustomDate(29, 2, 2016);
            Console.WriteLine(date.IsValid());
            CustomDate date1 = new CustomDate(29, 2, 2017);
            Console.WriteLine(date1.IsValid());
            CustomDate date2 = new CustomDate(29, 21, 2016);
            Console.WriteLine(date2.IsValid());
            CustomDate date3 = new CustomDate(29, 2, 3016);
            Console.WriteLine(date3.IsValid());
            CustomDate date4 = new CustomDate(33, 2, 2016);
            Console.WriteLine(date4.IsValid());

            GroupOccurrencesCharacters obj = new GroupOccurrencesCharacters();
            var newString = obj.GroupOccChar("abczabac");
            Console.WriteLine(newString);


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

            String s1 = "abcd";
            String s2 = "xxabcWdt";

            char[] X = s1.ToCharArray();
            char[] Y = s2.ToCharArray();
            int m = X.Length;
            int n = Y.Length;

            Console.Write("Length of LCS is" + " "
                          + LongestCommonSubsequence.FindLongestCommonSubsequence(X, Y, m, n));
            
            Console.WriteLine();
            Console.WriteLine();
            //////////////////////////
            //sw.Stop();
            //Console.WriteLine("==========Elapsed time=========");
            //Console.WriteLine(sw.Elapsed);
            //Console.Read();

            Fibonacci f = new Fibonacci();
            var series = f.GetFibonacci(5);

            sw = Stopwatch.StartNew();
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Fib of {0}th number is {1}",i, f.GetFibonacci(i));
            }
            sw.Stop();
            Console.WriteLine("==========Elapsed time========= \n GetFibonacci without DP");
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine();

            sw = Stopwatch.StartNew();
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Fib of {0} is {1}", i, f.GetFibonacciwithDP(i));
            }
            sw.Stop();
            Console.WriteLine("==========Elapsed time========= \n GetFibonacciwithDP");
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine();

            BinarySearchTree<int> myTree = new BinarySearchTree<int>();
            myTree.Insert(5);
            myTree.Insert(3);
            myTree.Insert(9);
            myTree.Insert(7);
            myTree.Insert(99);
            myTree.Insert(1);

            Console.WriteLine("PrintBFS");
            myTree.PrintBFS();

            Console.WriteLine("PrintDFSPreorder");
            myTree.PrintDFSPreorder();

            Console.WriteLine("Remove");
            myTree.Remove(99);

            Console.WriteLine("PrintDFSInorder");
            myTree.PrintDFSInorder();

            myTree.PrintDFSPostOrder();
            myTree.LeafNode();
            myTree.Edge();
            myTree.BFSWithoutRecursion();
        }
    }
}
