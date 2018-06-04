package soritng;

public class QuickSort implements MySort{

	int partition(int[] arr, int start, int end)
	{
		int pivot=arr[end];
		int pIndex=start;
		for(int i=start; i<end;i++)
		{
			if(arr[i]<=pivot)
			{
				int temp=arr[i];
				arr[i]=arr[pIndex];
				arr[pIndex]=temp;
				pIndex++;
			}
		}
		int temp=arr[pIndex];
		arr[pIndex]=arr[end];
		arr[end]=temp;
		return pIndex;		
	}
	void quicksort(int[] arr, int start, int end)
	{
		if(start<end)
		{
			int pIndex=partition(arr, start, end);
			quicksort(arr, start, pIndex-1);
			quicksort(arr, pIndex+1, end);
		}
	}
	public void sort(int[] arr) {
		
	}

	public void display(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]+"  ");
		}
	}
	public static void main(String[] args) {
		QuickSort obj = new QuickSort();
		int[] arr= {4,2,5,34,7,97,32};
		obj.quicksort(arr, 0, arr.length-1);
		obj.display(arr);
	}

}
