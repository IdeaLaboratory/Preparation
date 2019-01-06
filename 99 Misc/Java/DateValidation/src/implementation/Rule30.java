package implementation;

import interfaces.Rules;
import main.Date;

public class Rule30 implements Rules{

	@Override
	public boolean isValid(Date date) {
		// TODO Auto-generated method stub
		if(date.getDd()<=30)
		{
			return true;
		}
		return false;
	}


}
