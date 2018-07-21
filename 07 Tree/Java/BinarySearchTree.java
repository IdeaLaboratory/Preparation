package binarySearchTree;

import java.util.ArrayList;
import java.util.List;
import java.util.Stack;

public class BinarySearchTree {

	class Node {
		int data;
		Node left;
		Node right;
		
		@Override
		public String toString() {
			String str= new String(""+data+"");
			return str;
		}
	}

	Node root;

	public void insert(int data) {
		root = insert(data, root);
	}

	public void BFSTraverse() {
		List<Node> childNodes = new ArrayList<>();
		BFStraverse(root, childNodes);
	}

	public void preOrder() {
		preOrder(root);
	}

	public void postOrder() {
		postOrder(root);
	}

	public void inOrder() {
		inOrder(root);
	}

	public void printLeafNodes() {
		List<Node> leafNodes = new ArrayList<>();
		printLeafNodes(root, leafNodes);
	}

	public void printEdgeNodes() {
		printLeftNodes(root);
		printLeafNodes();
		printRightNodes(root.right);
	}
	
	public void BFSWithoutRecursion()
	{
		BFSWithoutRecursion(root);
	}

	
	private Node insert(int data, Node node) {
		if (node == null) {
			node = new Node();
			node.data = data;
			return node;
		} else if (data < node.data) {
			node.left = insert(data, node.left);
		} else if (data > node.data) {
			node.right = insert(data, node.right);
		}
		return node;
	}

	private void preOrder(Node node) {
		if (node == null)
			return;
		System.out.print(node.data + "	");
		preOrder(node.left);
		preOrder(node.right);
	}

	private void postOrder(Node node) {
		if (node == null)
			return;
		postOrder(node.left);
		postOrder(node.right);
		System.out.print(node.data + "	");
	}

	private void inOrder(Node node) {
		if (node == null)
			return;
		inOrder(node.left);
		System.out.print(node.data + "	");
		inOrder(node.right);
	}

	private void BFStraverse(Node node, List<Node> childNodes) {
		if (node == null)
			return;
		System.out.print(node.data + "	");
		childNodes.add(node.left);
		childNodes.add(node.right);
		while (childNodes.size() > 0) {
			BFStraverse(childNodes.remove(0), childNodes);
		}
	}

	private void printLeafNodes(Node node, List<Node> leafNodes) {
		if (node == null)
			return;
		if (node.left == null && node.right == null) {
			System.out.print(node.data + "	");
		}
		leafNodes.add(node.left);
		leafNodes.add(node.right);
		while (leafNodes.size() > 0) {
			printLeafNodes(leafNodes.remove(0), leafNodes);
		}
	}

	private void printRightNodes(Node node) {
		if (node == null)
			return;
		printRightNodes(node.right);
		if (node.right != null) {
			System.out.print(node.data + "	");
		}
	}

	private void printLeftNodes(Node node) {
		if (node == null)
			return;
		if (node.left != null) {
			System.out.print(node.data + "	");
		}
		printLeftNodes(node.left);
	}
	
	private void BFSWithoutRecursion(Node node) {
		List<Node> nodeList= new ArrayList<>();
		List<Node> childList= new ArrayList<>();
		childList.add(node);
		while(childList.size()>0)
		{
			//retrieve each element
			Node n=childList.remove(0);
			
			//add element's child if not null
			if(n.left!=null)
			{
				childList.add(n.left);
			}
			if(n.right!=null)
			{
				childList.add(n.right);
			}
			// add element into nodeList
			nodeList.add(n);
		}
		
		System.out.println(nodeList);
	}


	public static void main(String[] args) {
		BinarySearchTree obj = new BinarySearchTree();
		obj.insert(5);
		obj.insert(3);
		obj.insert(9);
		obj.insert(1);
		obj.insert(7);
		obj.insert(99);

//		System.out.println("BFS");
//		obj.BFSTraverse();
//		System.out.println();
//		System.out.println("inOrder");
//		obj.inOrder();
//		System.out.println();
//		System.out.println("preOrder");
//		obj.preOrder();
//		System.out.println();
//		System.out.println("postOrder");
//		obj.postOrder();
//		System.out.println();
//		System.out.println("leaf nodes");
//		obj.printLeafNodes();
//		System.out.println();
//		System.out.println("edge nodes");
//		obj.printEdgeNodes();
		obj.BFSWithoutRecursion();

	}
}
