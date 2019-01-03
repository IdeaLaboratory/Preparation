package implementation;

import interfaces.Rules;
import main.Date;

public class Rule31 implements Rules{

	@Override
	public boolean isValid(Date date) {
		// TODO Auto-generated method stub
		if(date.getDd()<=31)
		{
			return true;
		}
		return false;
	}

}
