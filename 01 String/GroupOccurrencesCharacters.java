import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

class GroupOccurrencesCharacters {

	static String str1 = "AdiIsCallingAdi";

	static String GroupOcc(String input) {

		List<String> inputList = new ArrayList<String>(Arrays.asList(input.split("")));
		String newString = new String();
		for (int i = 0; i < inputList.size(); i++) {
			newString += inputList.get(i);
			for (int j = i + 1; j < inputList.size(); j++) {
				if (input.charAt(i) == input.charAt(j)) {
					newString += inputList.remove(j);
				}
			}
		}
		return newString;
	}

	public static void main(String[] args) {
		System.out.println(GroupOcc(str1));
	}
}