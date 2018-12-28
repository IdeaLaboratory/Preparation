import java.util.Arrays;
import java.util.List;

public class Date {
	private int dd;
	private int mm;
	private int yy;
	private List<Integer> monthList31 = Arrays.asList(1, 3, 5, 7, 8, 10, 12);
	private List<Integer> monthList30 = Arrays.asList(4, 6, 9, 11);

	public int getDd() {
		return dd;
	}

	public void setDd(int dd) {
		this.dd = dd;
	}

	public int getMm() {
		return mm;
	}

	public void setMm(int mm) {
		this.mm = mm;
	}

	public int getYy() {
		return yy;
	}

	public void setYy(int yy) {
		this.yy = yy;
	}

	public Date(int dd, int mm, int yy) {
		super();
		this.dd = dd;
		this.mm = mm;
		this.yy = yy;
	}

	private boolean isLeapYear(int year) {
		return ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0));
	}

	public boolean isValid() {
		if (mm == 2 && isLeapYear(yy) && (dd <= 29)) {
			return true;
		}
		else if (dd <= 28)
			return true;
		if (monthList31.contains(mm) && dd <= 31)
		{
			return true;
		}
		if (monthList30.contains(mm) && dd < 31)
			return true;
		return false;
	}
	
	public static void main(String[] args) {
		Date date= new Date(30, 02, 2016);
		System.out.println(date.isValid());
	}

}
