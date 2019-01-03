package implementation;

import interfaces.Rules;
import main.Date;

public class RuleFeb implements Rules{

	@Override
	public boolean isValid(Date date) {
		// TODO Auto-generated method stub
<<<<<<< HEAD
		if(isLeapYear(date.getYy()))
=======
		if(Date.isLeapYear(date.getYy()))
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c
		{
			if(date.getDd()<=29)
				return true;
		}
		else
		{
			if(date.getDd()<=28)
				return true;
		}
		return false;
	}
<<<<<<< HEAD
	
	boolean isLeapYear(int year) {
		// TODO Auto-generated method stub
		if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
			return true;
		}
		return false;
	}
=======
>>>>>>> 4c1c0e1ed4fba56e9f82ec2cda6428fd5987c17c


}
