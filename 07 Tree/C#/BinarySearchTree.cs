using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class BinarySearchTree : ITree
    {
        private Node _root;

        #region Node inner class
        class Node
        {
            public int data;
            public Node left, right;
        }
        #endregion

        #region public methods

        public void Insert(int val)
        {
            _root = InsertInternal(_root, val);
        }

        public void PrintBFS()
        {
            Queue<Node> childs = new Queue<Node>();
            PrintBFS(_root, childs);
        }

        public void PrintDFSInorder()
        {
            PrintDFSInorder(_root);
        }

        public void Edge()
        {
            InternalPrintLeft(_root);
            LeafNode();
            InternalPrintRight(_root.right);    //skip root as already printed
        }

        public void PrintDFSPostOrder()
        {
            PrintDFSPostOrder(_root);
        }

        public void PrintDFSPreorder()
        {
            PrintDFS(_root);
        }

        public void Remove(int val)
        {
            throw new NotImplementedException();
        }

        public int Search()
        {
            throw new NotImplementedException();
        }

        public void LeafNode()
        {
            Queue<Node> childs = new Queue<Node>();
            LeafNodeInternal(_root, childs);
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

        private void LeafNodeInternal(Node root, Queue<Node> childs)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
                Console.WriteLine(root.data);

            childs.Enqueue(root.left);
            childs.Enqueue(root.right);

            while (childs.Count > 0)
            {
                LeafNodeInternal(childs.Dequeue(), childs);
            }
        }

        private void InternalPrintRight(Node root)
        {
            if (root == null)
                return;
            if (root.right == null)  // skip the leaf left
                return;
            InternalPrintRight(root.right); //bottom to top
            Console.WriteLine(root.data);
        }

        private void InternalPrintLeft(Node root)
        {
            if (root == null)
                return;
            if (root.left == null)  // skip the leaf left
                return;
            Console.WriteLine(root.data);
            InternalPrintLeft(root.left);
        }

        #endregion
    }
}
