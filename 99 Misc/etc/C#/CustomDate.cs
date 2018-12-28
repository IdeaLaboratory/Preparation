using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class CustomDate
    {
        public int DD { get; set; }
        public int MM { get; set; }
        public int YYYY { get; set; }

        public CustomDate(int d, int m, int y)
        {
            DD = d; MM = m; YYYY = y;
        }

        public bool IsValid()
        {
            if (ValidUtil(DD, 1, getMaxDay(MM, YYYY))
                && ValidUtil(MM, 1, 12)
                && ValidUtil(YYYY, 1900, 2100))
                return true;

            return false;
        }

        private bool ValidUtil(int YYYY, int min, int max)
        {
            if (YYYY < min || YYYY > max)
                return false;
            return true;
        }
        
        private int getMaxDay(int mM, int yYYY)
        {
            int isLeapyear = IsLeapyear(YYYY);
            switch (mM)
            {
                case 2:
                    return 28 + isLeapyear;

                case 9:
                case 4:
                case 6:
                case 11:
                    return 30;

                default:
                    return 31;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="yYYY"></param>
        /// <returns>0 or 1</returns>
        private int IsLeapyear(int yYYY)
        {
            if (yYYY % 4 == 0)
                return 1;
            return 0;
        }
    }
}
