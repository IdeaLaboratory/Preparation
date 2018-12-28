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
            return false;
        }
    }
}
