using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tree;

namespace Preparation
{
    public class MainDriverClass
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.Insert(5);
            myTree.Insert(3);
            myTree.Insert(9);
            myTree.Insert(7);
            myTree.Insert(99);
            myTree.Insert(1);

            //myTree.PrintBFS();
            //myTree.PrintDFSPreorder();
            //myTree.PrintDFSInorder();
            //myTree.PrintDFSPostOrder();
            //myTree.LeafNode();
            myTree.Edge();
        }
    }
}
