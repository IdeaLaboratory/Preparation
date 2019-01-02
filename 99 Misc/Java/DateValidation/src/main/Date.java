package main;


import java.util.Arrays;
import java.util.List;

import implementation.Rule30;
import implementation.Rule31;
import implementation.RuleFeb;
import interfaces.Rules;

public class Date {

	private int dd;
	private int mm;
	private int yy;
	private List<Integer> monthList31= Arrays.asList(1,3,5,7,8,10,12);
	private List<Integer> monthList30= Arrays.asList(4,6,9,11);

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

	public static boolean isLeapYear(int year) {
		// TODO Auto-generated method stub
		if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
			return true;
		}
		return false;
	}

	public boolean isValid() {
		boolean isValid = false;
		if (mm == 2 && isLeapYear(yy)&&(dd <= 29)) {
			return true;
		}
		else if(dd<=28)
			return true;
		if(monthList31.contains(mm)&& dd<=31)
		{
			return true;
		}
		if(monthList30.contains(mm)&& dd<31)
			return true;
		return isValid;
		
	}
	
	public boolean isValidOOO()
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

		}
		return isValid;
	}

	public static void main(String[] args) {
		Date date = new Date(31, 04, 2016);
		System.out.println(date.isValidOOO());
	}
}
