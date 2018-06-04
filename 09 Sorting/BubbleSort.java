package soritng;

public class BubbleSort implements MySort{

	@Override
	public void sort(int[] arr) {
		boolean flag= true;
		for(int i=0;i<arr.length;i++)
		{
			for(int j=0;j<arr.length-i-1;j++)
			{
				if(arr[j]>arr[j+1])
				{
					int temp= arr[j];
					arr[j]=arr[j+1];
					arr[j+1]=temp;
					flag=false;
				}
			}
			if(flag)
				break;
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
		MySort obj = new BubbleSort();
		int[] arr= {4,2,5,34,7,97,32};
		obj.sort(arr);
		obj.display(arr);
	}

}
