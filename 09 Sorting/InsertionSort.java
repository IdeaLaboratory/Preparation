package soritng;

public class InsertionSort implements MySort{

	@Override
	public void sort(int[] arr) {
		for (int i = 1; i < arr.length; i++) {
			int currentElement=arr[i];
			int j=i-1;
			while(j>=0 && arr[j]>currentElement)
			{
				arr[j+1]=arr[j];
				j=j-1;
			}
			arr[j+1]=currentElement;
		}
		
	}

	@Override
	public void display(int[] arr) {
		// TODO Auto-generated method stub
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]+"  ");
		}
	}
	public static void main(String[] args) {
		MySort obj = new InsertionSort();
		int[] arr= {4,2,5,34,7,97,32};
		obj.sort(arr);
		obj.display(arr);
	}


}
