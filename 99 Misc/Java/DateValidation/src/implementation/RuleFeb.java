package implementation;

import interfaces.Rules;
import main.Date;

public class RuleFeb implements Rules{

	@Override
	public boolean isValid(Date date) {
		// TODO Auto-generated method stub
		if(Date.isLeapYear(date.getYy()))
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


}
