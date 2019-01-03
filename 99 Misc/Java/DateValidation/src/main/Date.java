package main;

<<<<<<< HEAD
=======

import java.util.Arrays;
import java.util.List;

>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
import implementation.Rule30;
import implementation.Rule31;
import implementation.RuleFeb;
import interfaces.Rules;

public class Date {

	private int dd;
	private int mm;
	private int yy;
<<<<<<< HEAD
=======
	private List<Integer> monthList31= Arrays.asList(1,3,5,7,8,10,12);
	private List<Integer> monthList30= Arrays.asList(4,6,9,11);
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c

	public int getDd() {
		return dd;
	}

<<<<<<< HEAD
=======
	public void setDd(int dd) {
		this.dd = dd;
	}

>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
	public int getMm() {
		return mm;
	}

<<<<<<< HEAD
=======
	public void setMm(int mm) {
		this.mm = mm;
	}

>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
	public int getYy() {
		return yy;
	}

<<<<<<< HEAD
=======
	public void setYy(int yy) {
		this.yy = yy;
	}

>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
	public Date(int dd, int mm, int yy) {
		super();
		this.dd = dd;
		this.mm = mm;
		this.yy = yy;
	}

<<<<<<< HEAD
	public boolean isValid()
=======
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
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
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
<<<<<<< HEAD
		default: System.out.println("Please enter a valid month");
=======
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c

		}
		return isValid;
	}

	public static void main(String[] args) {
<<<<<<< HEAD
		Date date = new Date(31, 4, 2016);
		System.out.println(date.isValid());
=======
		Date date = new Date(31, 04, 2016);
		System.out.println(date.isValidOOO());
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
	}
}
