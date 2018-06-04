package soritng;

public class MergeSort implements MySort{

	public void sort(int[] arr) {
		int n=arr.length;
		if(n<2)
			return;
		int mid=n/2;
		int[] leftArr=new int[mid];
		int[] rightArr=new int[n-mid];
		for(int i=0;i<mid;i++)
		{
			leftArr[i]=arr[i];
		}
		for (int i = mid; i < arr.length; i++) {
			rightArr[i-mid]=arr[i];
		}
		sort(leftArr);
		sort(rightArr);
		merge(leftArr, rightArr, arr);

	}

	public void display(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]+"  ");
		}
	}
	void merge(int[] leftArr, int[] rightArr, int[] arr)
	{
		int nL=leftArr.length;
		int nR=rightArr.length;
		int i=0;
		int j=0;
		int k=0;
		while(i<nL && j<nR)
		{
			if(leftArr[i]<=rightArr[j])
			{
				arr[k]=leftArr[i];
				k++;
				i++;
			}
			else
			{
				arr[k]=rightArr[j];
				k++;
				j++;
			}
		}
		while(i<nL)
		{
			arr[k]=leftArr[i];
			i++;
			k++;
		}
		while(j<nR)
		{
			arr[k]=rightArr[j];
			j++;
			k++;
		}
	}
	public static void main(String[] args) {
		MySort obj = new MergeSort();
		int[] arr= {4,2,5,34,7,97,32};
		obj.sort(arr);
		obj.display(arr);
	}

}
