//http://www.geeksforgeeks.org/anagram-substring-search-search-permutations/

package AnagramSubString;

import java.util.ArrayList;
import java.util.List;

public class AnagramSubString {
	
	boolean compare(List<Character> c1,List<Character> c2)
	{
		boolean flag=true;
		for(char c: c1)
		{
			if(!c2.contains(c))
			{
				flag=false;
			}
		}
		return flag;
	}
	
	void checkSubstring(List<Character> text, List<Character> pat)
	{
		List<Character> window= new ArrayList<Character>();
		
		int count=pat.size()-1;
		int i=0;
		
		for (i = 0; i < pat.size(); i++) {
			window.add(i, text.get(i));
		}
		for(i=pat.size();i<text.size();i++)
		{
			
			if(compare(pat,window))//comparing first set of letters..no need of i hence
			{
				System.out.println("found at index: "+(i-pat.size()));//if matches it will be found at index 0 for first set of window
			}
			window.remove(window.get(0));
			window.add(window.size(), text.get(++count));
		}
		if(compare(pat,window))//comparing last set of letters..no need of i hence
		{
			System.out.println("found at index: "+(i-pat.size()));//if matches it will be found at index 0 for first set of window
		}
		
	}
	
	public static void main(String[] args) {
		AnagramSubString obj = new AnagramSubString();
		String s1="AAABABAA";
		String s2="AABA";
		s1=s1.toLowerCase();
		s2=s2.toLowerCase();
		
		List<Character> text=new ArrayList<Character>();
		List<Character> pat=new ArrayList<Character>();
		
		for(char c: s1.toCharArray())
		{
			text.add(c);
		}
		for(char c: s2.toCharArray())
		{
			pat.add(c);
		}
		obj.checkSubstring(text, pat);
		
		
	}

}
