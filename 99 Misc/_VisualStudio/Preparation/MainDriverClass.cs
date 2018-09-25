using DP;
using System;
using System.Diagnostics;

namespace Preparation
{
    public class MainDriverClass
    {
        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
            var sw = Stopwatch.StartNew();
            sw = Stopwatch.StartNew();
            ////////////Write your code here to measure performance////////////
            Backtrack.NQueen nQueen = new Backtrack.NQueen();
            int n = 16;
            int[,] positions = new int[n, n];
            nQueen.GetQueenPositions(positions, 0);

            for (int i = 0; i < positions.GetLength(0); i++)
            {
                for (int j = 0; j < positions.GetLength(0); j++)
                {
                    Console.Write(positions[i, j] + ",");
                }
                Console.WriteLine();
            }
            ////////////////////////
            sw.Stop();
            Console.WriteLine("==========Elapsed time=========");
            Console.WriteLine(sw.Elapsed);
            Console.Read();

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
