public class Palindrome {
	
	static void isPalindrome(String str1)
	{
		Boolean isPalindrom=true;
		//String str1 = System.console().readLine();
		int ln = str1.length();
		int l2 = (int) Math.ceil(ln); 
		for(int i=0; i<l2; i++)
		{
			if(str1.charAt(i)!=str1.charAt(ln-1-i))
				isPalindrom = false;
		}
		if(isPalindrom)
			System.out.println(str1 +" is palindrom");
		else
			System.out.println(str1 + " is not polindrom");
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		isPalindrome(args[0]);
	}

}
