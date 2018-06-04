public class AnagramSubstringArr {

	boolean compare(char[] c1, char[] c2) {
		int count = 0;
		for (int i = 0; i < c1.length; i++) {
			for (int j = 0; j < c2.length; j++) {
				if (c1[i] == c2[j]) {
					++count;
				}
			}
		}
		if (count == c1.length)
			return true;
		else
			return false;
	}

	void checkSubstring(char[] arr1, char[] arr2) {
		char[] window = new char[arr2.length];
		int i = arr2.length;

		for (int k = 0; k < arr2.length; k++) {
			window[k] = arr1[k];
		}
		for (i = arr2.length; i < arr1.length; i++) {

			if (compare(arr2, window))// comparing first set of letters..no need of i hence
			{
				System.out.println("found at index: " + (i - arr2.length));// if matches it will be found at index 0 for
																			// first set of window
			}
			for(int j=1;j<window.length;j++)
			{
				window[j-1]=window[j];
			}
			window[arr2.length - 1] = arr1[i];
		}
		if (compare(arr2, window))// comparing last set of letters..no need of i hence
		{
			System.out.println("found at index: " + (i - arr2.length));// if matches it will be found at last found index for
																		// last window
		}
	}

	public static void main(String[] args) {
		AnagramSubstringArr obj = new AnagramSubstringArr();
		String s1 = "BACDGABCDA";
		String s2 = "ABCD";
		s1 = s1.toLowerCase();
		s2 = s2.toLowerCase();
		char[] text = s1.toCharArray();
		char[] pat = s2.toCharArray();
		obj.checkSubstring(text, pat);

	}
}
