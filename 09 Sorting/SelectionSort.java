package soritng;

public class SelectionSort implements MySort{

	@Override
	public void sort(int[] arr) {
		for (int i = 0; i < arr.length-1; i++) {
			int smallestIndex=i;	
			for (int j = i+1; j < arr.length; j++) {
				if(arr[j]<arr[smallestIndex])
				{
					smallestIndex=j;
				}
				int temp=arr[i];
				arr[i]=arr[smallestIndex];
				arr[smallestIndex]=temp;
			}
		}
	}

	@Override
	public void display(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]+"  ");
		}
	}
	
	public static void main(String[] args) {
		MySort obj = new SelectionSort();
		int[] arr= {4,2,5,34,7,97,32};
		obj.sort(arr);
		obj.display(arr);
	}

}
