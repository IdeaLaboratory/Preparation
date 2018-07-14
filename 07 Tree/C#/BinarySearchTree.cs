using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class BinarySearchTree : ITree
    {
        private Node Root { get; set; }
        class Node
        {
            public int data;
            public Node left, right;
        }

        #region public methods

        public void Insert(int val)
        {
            Root = InsertInternal(Root, val);
        }

        public void PrintBFS()
        {
            Queue<Node> childs = new Queue<Node>();
            PrintBFS(Root, childs);
        }

        public void PrintDFSInorder()
        {
            PrintDFSInorder(Root);
        }

        public void PrintDFSPostOrder()
        {
            PrintDFSPostOrder(Root);
        }

        public void PrintDFSPreorder()
        {
            PrintDFS(Root);
        }

        public void Remove(int val)
        {
            throw new NotImplementedException();
        }

        public int Search()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region private methods
        private Node InsertInternal(Node current, int val)
        {
            if (current == null)
            {
                current = new Node() { data = val };
            }
            else
            {
                if (val < current.data)
                    current.left = InsertInternal(current.left, val);
                else
                    current.right = InsertInternal(current.right, val);
            }
            return current;
        }

        private void PrintBFS(Node root, Queue<Node> childs)
        {
            if (root == null)
                return;

            Console.WriteLine(root.data);
            childs.Enqueue(root.left);
            childs.Enqueue(root.right);

            while (childs.Count > 0)
            {
                PrintBFS(childs.Dequeue(), childs);
            }
        }

        private void PrintDFS(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.data);
            PrintDFS(root.left);
            PrintDFS(root.right);
        }

        private void PrintDFSInorder(Node root)
        {
            if (root == null)
                return;

            PrintDFSInorder(root.left);
            Console.WriteLine(root.data);
            PrintDFSInorder(root.right);
        }

        private void PrintDFSPostOrder(Node root)
        {
            if (root == null)
                return;

            PrintDFSPostOrder(root.left);
            PrintDFSPostOrder(root.right);
            Console.WriteLine(root.data);
        }
        #endregion
    }
}
