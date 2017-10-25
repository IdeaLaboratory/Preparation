package stackMain;

public class Stack {
	int top;
	int size;
	int[] arr;

	Stack() {
		top = -1;
	}

	Stack(int n) {
		size = n;
		arr = new int[size];
		top = -1;
	}

	boolean isFull() {
		if (top == size - 1)
			return true;
		else
			return false;
	}

	boolean isEmpty() {
		if (top == -1)
			return true;
		else
			return false;
	}

	void push(int n) {
		if (isFull()) {
			int[] newArr = new int[size * 2];
			for (int i = 0; i < arr.length; i++) {
				newArr[i] = arr[i];
			}
			this.arr = newArr;
			size = size * 2;
		}
		System.out.println(n+ " pushed");
		arr[++top] = n;
	}

	int pop() {
		if (isEmpty())
			System.out.println("Stack is empty");
		else
			return arr[top--];
		return 0;
	}
}
