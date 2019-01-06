package implementation;

import interfaces.Rules;
import main.Date;

public class RuleFeb implements Rules{

	@Override
	public boolean isValid(Date date) {
		// TODO Auto-generated method stub
		if(isLeapYear(date.getYy()))
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
	
	boolean isLeapYear(int year) {
		// TODO Auto-generated method stub
		if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
			return true;
		}
		return false;
	}


}
