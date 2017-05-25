public class Palindrome {
	
	//O(n/2)
	static boolean isPalindrome(String str1)
	{
		Boolean isPalindrom=true;
		int startIndex = str1.length()-1;
		int endIndex = str1.length()-1; 
		while(startIndex>endIndex)
		{
			if(str1.charAt(startIndex)!=str1.charAt(endIndex))
				isPalindrom = false;
			startIndex++;
			endIndex--;
		}
		return isPalindrom;
	}

	public static void main(String[] args) {
		
		boolean isPalindrom = isPalindrome(args[0]);
		if(isPalindrom)
			System.out.println(args[0] +" is palindrom");
		else
			System.out.println(args[0] + " is not polindrom");
	}
}
