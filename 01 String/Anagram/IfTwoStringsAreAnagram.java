public class IfTwoStringsAreAnagram {

	char[] sort(char[] charr)
	{
		char[] b= new char[charr.length];
		int count=0;
		for(int i=0; i<charr.length;i++)
		{
			count=0;
			for(int j=0; j<charr.length;j++)
			{
				if(charr[i]>charr[j])
				{
					count++;
				}
			}
			b[count]=charr[i];
		}
		return b;
	}
	
	boolean compare(char[] c1,char[] c2)
	{
		boolean isSameChar=false;
		boolean isAna=false;
		for(int i=0; i< c1.length;i++)
		{
			if(c1[i]!=c2[i])
			{
				break;
			}
			else
			{
				isSameChar=true;
			}
		}
		if(isSameChar)
		{
			isAna=true;
			return isAna;
		}
		else 
			return false;
	
	}
	
	
	public static void main(String[] args) {
		IfTwoStringsAreAnagram obj = new IfTwoStringsAreAnagram();
		boolean result=false;;
		String str1="abar";
		String str2="baar";
		str1=str1.toLowerCase();
		str2=str2.toLowerCase();
		char[] chr1=obj.sort(str1.toCharArray());
		char[] chr2=obj.sort(str2.toCharArray());
		if(chr1.length==chr2.length)
		{
			result=obj.compare(chr1, chr2);
			if(result)
			{
				System.out.println("isAnagram");
			}
			else
			{
				System.out.println("notAnagram");
			}
		}
		else
		{
			System.out.println("notAnagram");
		}
		
		
	}
}
