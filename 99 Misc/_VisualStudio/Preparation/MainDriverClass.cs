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
            var series1 = f.GetFibonacciWithDPWithoutDictionary(50);
            sw.Stop();
            Console.Write(series1 + ", ");
            Console.WriteLine("==========Elapsed time=========");
            Console.WriteLine(sw.Elapsed);

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
