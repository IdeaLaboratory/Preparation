
public class NQueen {

	boolean getQueenPos(int[][] arr, int currentRow) {
		if (currentRow >= arr.length) {
			return true;
		}

		for (int col = 0; col < arr[0].length; col++) {
			if (isValidPos(currentRow, col, arr)) {
				arr[currentRow][col] = 1;
				if (getQueenPos(arr, currentRow + 1) == true)
					return true;
				arr[currentRow][col] = 0;// this is backtrack, as this is not the solution, falling back.
			}
		}
		return false;
	}

	private boolean isValidPos(int currentRow, int col, int[][] arr) {
		// check for row
		for (int i = 0; i < arr[0].length; i++) {
			if (arr[currentRow][i] == 1) {
				return false;
			}
		}
		// check for column
		for (int i = 0; i < currentRow; i++) {
			if (arr[i][col] == 1) {
				return false;
			}
		}
		// check for top-left
		for (int i = currentRow - 1, j = col - 1; i >= 0 && j >= 0; i--, j--) {
			if (arr[i][j] == 1)
				return false;
		}
		// check for top-right
		for (int i = currentRow - 1, j = col + 1; i >= 0 && j < arr[0].length; i--, j++) {
			if (arr[i][j] == 1)
				return false;
		}
		// check for bottom-left
		for (int i = currentRow + 1, j = col - 1; i < arr.length && j >= 0; i++, j--) {
			if (arr[i][j] == 1)
				return false;
		}
		// check for bottom-right
		for (int i = currentRow + 1, j = col + 1; i < arr.length && j < arr[0].length; i++, j++) {
			if (arr[i][j] == 1)
				return false;
		}

		return true;
	}

	public static void main(String[] args) {
		int[][] arr = new int[8][8];
		boolean res = new NQueen().getQueenPos(arr, 0);

		for (int i = 0; i < arr.length; i++) {
			{
				for (int j = 0; j < arr[0].length; j++) {
					System.out.print(arr[i][j] + "  ");
				}
				System.out.println();
			}
		}

	}
}
