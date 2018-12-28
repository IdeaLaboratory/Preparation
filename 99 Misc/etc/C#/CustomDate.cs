using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    class CustomDate
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
            if (ValidDate()
                && ValidMonth()
                && ValidYear())
                return true;

            return false;
        }

        private bool ValidYear()
        {
            if (YYYY < 1900 || YYYY > 2100)
                return false;
            return true;
        }

        private bool ValidMonth()
        {
            if (MM < 1 || MM > 12)
                return false;
            return true;
        }

        private bool ValidDate()
        {
            int maxDay = getMaxDay(MM, YYYY);
            if (MM < 1 || MM > maxDay)
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
            throw new NotImplementedException();
        }
    }
}
