using System;
using System.Collections.Generic;

namespace Tree
{
    public class BinarySearchTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node _root;

        #region Node inner class
        class Node
        {
            public T data;
            public Node left, right;
        }
        #endregion

        #region public methods

        public void Insert(T val)
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

        public void BFSWithoutRecursion()
        {
            BFSWithoutRecursionInternal(_root);
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

        public void Remove(T val)
        {
            // find
            Node node = SearchDFS(val);

            // manipulate right if available
            node = RemoveNode(node);
            // or manipulate left if available
            // or just delete
        }

        private Node RemoveNode(Node node)
        {
            if (node.left == null && node.right == null)
            {
                node = null;
                return node;
            }

            if (node.right != null)
            {
                node.data = node.right.data;
                node.right = RemoveNode(node.right);
            }
            else if (node.left != null)
            {
                node.data = node.left.data;
                node.left = RemoveNode(node.left);
            }
            else
            {
                node = null;
            }

            return node;
        }

        private Node SearchDFS(T val)
        {
            return SearchDFSUtil(_root, val);
        }

        private Node SearchDFSUtil(Node root, T val)
        {
            if (root == null)
            {
                return null;
            }

            if (0 == root.data.CompareTo(val))
            {
                return root;
            }

            var temp = SearchDFSUtil(root.left, val);
            if (temp != null)
                return temp;

            var temp1 = SearchDFSUtil(root.right, val);
            if (temp1 != null)
                return temp1;

            return null;
        }

        public T Search()
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
        private Node InsertInternal(Node current, T val)
        {
            if (current == null)
            {
                current = new Node() { data = val };
            }
            else
            {
                if (1 == current.data.CompareTo(val))
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

        private void BFSWithoutRecursionInternal(Node root)
        {
            if (root == null)
                return;
            Queue<Node> nodes = new Queue<Node>();
            Queue<Node> childNodes = new Queue<Node>();
            childNodes.Enqueue(root);

            while (childNodes.Count > 0)
            {
                Node node = childNodes.Dequeue();
                if (node.left != null)
                    childNodes.Enqueue(node.left);
                if (node.right != null)
                    childNodes.Enqueue(node.right);

                nodes.Enqueue(node);
            }
            foreach (var item in nodes)
            {
                Console.WriteLine(item.data);
            }
        }

        #endregion
    }
}
