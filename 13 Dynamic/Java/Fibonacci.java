import java.util.HashMap;
import java.util.Map;

public class Fibonacci {

	Map<Integer, Integer> memory = new HashMap<>();

	int getnthinFiboSeriesDP(int n) {
		if (memory.containsKey(n)) {
			return memory.get(n);
		}

		else {
			if (n < 2) {
				memory.put(n, 1);
				return 1;
			}
			int result = getnthinFiboSeriesDP(n - 1) + getnthinFiboSeriesDP(n - 2);
			memory.put(n, result);
			return result;
		}
	}

	int printFibo(int n) {
		if (n == 1 || n == 0) {
			return 1;
		}
		return printFibo(n - 1) + printFibo(n - 2);
	}

	public static void main(String[] args) {
		Fibonacci obj = new Fibonacci();
		System.out.println(obj.getnthinFiboSeriesDP(5));
	}
}
