package main;

import implementation.Rule30;
import implementation.Rule31;
import implementation.RuleFeb;
import interfaces.Rules;

public class Date {

	private int dd;
	private int mm;
	private int yy;

	public int getDd() {
		return dd;
	}

	public int getMm() {
		return mm;
	}

	public int getYy() {
		return yy;
	}

	public Date(int dd, int mm, int yy) {
		super();
		this.dd = dd;
		this.mm = mm;
		this.yy = yy;
	}

	public boolean isValid()
	{
		boolean isValid=false;
		Rules rule;
		switch (mm) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12: rule= new Rule31();
				 isValid=rule.isValid(new Date(dd,mm,yy));
				 break;
		case 2: rule= new RuleFeb();
				isValid=rule.isValid(new Date(dd,mm,yy));
				break;
		case 4:
		case 6:
		case 9:
		case 11: rule= new Rule30();
				 isValid=rule.isValid(new Date(dd,mm,yy));
				 break;
		default: System.out.println("Please enter a valid month");

		}
		return isValid;
	}

	public static void main(String[] args) {
		Date date = new Date(31, 4, 2016);
		System.out.println(date.isValid());
	}
}
