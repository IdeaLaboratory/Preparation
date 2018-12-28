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
            throw new NotImplementedException();
        }
    }
}
