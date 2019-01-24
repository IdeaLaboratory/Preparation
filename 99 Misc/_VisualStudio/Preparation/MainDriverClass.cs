using Etc;
using System;
using System.IO;
using System.Text;

namespace Preparation
{
    public class MainDriverClass
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 100; j++)
            {
                var csv = new StringBuilder();
                Probability p = new Probability();

                for (int i = 0; i < 9000; i++)
                {
                    Console.WriteLine();
                    //Suggestion made by KyleMit
                    csv.AppendLine(p.GetRandomNumberInRange(0, 99, 80, 99, 0.04).ToString());
                }
                File.WriteAllText(@"C:\del\t.csv", csv.ToString());
            }
            //after your loop

            //// find max power
            //MaxPower mxPow = new MaxPower();
            //Console.WriteLine(mxPow.FindMaxPower(75));
            //Console.WriteLine(mxPow.FindMaxPower(617));

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
            //var newString = obj.GroupOccChar("abcac");
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

            //Fibonacci f = new Fibonacci();
            //var sw = Stopwatch.StartNew();
            //sw = Stopwatch.StartNew();
            //////////////Write your code here to measure performance////////////
            ////Backtrack.NQueen nQueen = new Backtrack.NQueen();
            ////int n = 16;
            ////int[,] positions = new int[n, n];
            ////nQueen.GetQueenPositions(positions, 0);

            ////for (int i = 0; i < positions.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < positions.GetLength(0); j++)
            ////    {
            ////        Console.Write(positions[i, j] + ",");
            ////    }
            ////    Console.WriteLine();
            ////}

            //String s1 = "AGCAT";
            //String s2 = "GACXXA";

            //char[] X = s1.ToCharArray();
            //char[] Y = s2.ToCharArray();
            //int m = X.Length;
            //int n = Y.Length;

            //Console.Write("Length of LCS is" + " "
            //              + GFG.lcs(X, Y, m, n));

            //////////////////////////
            //sw.Stop();
            //Console.WriteLine("==========Elapsed time=========");
            //Console.WriteLine(sw.Elapsed);
            //Console.Read();

            //var series = f.GetFibonacci(44);
            //sw.Stop();
            //Console.Write(series + ", ");
            //Console.WriteLine("==========Elapsed time=========");
            //Console.WriteLine(sw.Elapsed);
            //BinarySearchTree<int> myTree = new BinarySearchTree<int>();
            //myTree.Insert(5);
            //myTree.Insert(3);
            //myTree.Insert(9);
            //myTree.Insert(7);
            //myTree.Insert(99);
            //myTree.Insert(1);

            ////myTree.PrintBFS();
            ////myTree.PrintDFSPreorder();
            //myTree.PrintDFSInorder();
            //myTree.PrintDFSPostOrder();
            //myTree.LeafNode();
            //myTree.Edge();
            //myTree.BFSWithoutRecursion();
        }
    }
}
