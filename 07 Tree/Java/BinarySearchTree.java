package binarySearchTree;

import java.util.ArrayList;
import java.util.List;

public class BinarySearchTree {

	class Node {
		int data;
		Node left;
		Node right;
	}

	Node root;

	void insert(int data) {
		root = insert(data, root);
	}

	void BFSTraverse() {
		List<Node> childNodes = new ArrayList<>();
		BFStraverse(root, childNodes);
	}

	void preOrder() {
		preOrder(root);
	}

	void postOrder() {
		postOrder(root);
	}

	void inOrder() {
		inOrder(root);
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
		System.out.print(node.data+"	");
		preOrder(node.left);
		preOrder(node.right);
	}

	private void postOrder(Node node) {
		if (node == null)
			return;
		postOrder(node.left);
		postOrder(node.right);
		System.out.print(node.data+"	");
	}

	private void inOrder(Node node) {
		if (node == null)
			return;
		inOrder(node.left);
		System.out.print(node.data+" ");
		inOrder(node.right);
	}

	private void BFStraverse(Node root, List<Node> childNodes) {
		if (root == null)
			return;
		System.out.print(root.data+"	");
		childNodes.add(root.left);
		childNodes.add(root.right);
		while (childNodes.size() > 0) {
			BFStraverse(childNodes.remove(0), childNodes);
		}
	}

	void traverse(Node node) {
		if (node == null)
			return;
		else {
			System.out.println(node.data);
			traverse(node.left);
			traverse(node.right);
		}
	}

	public static void main(String[] args) {
		BinarySearchTree obj = new BinarySearchTree();
		obj.insert(5);
		obj.insert(3);
		obj.insert(9);
		obj.insert(1);
		obj.insert(7);
		obj.insert(99);

		System.out.println("BFS");
		obj.BFSTraverse();
		System.out.println("inOrder");
		obj.inOrder();
		System.out.println("preOrder");
		obj.preOrder();
		System.out.println("postOrder");
		obj.postOrder();

	}
}
