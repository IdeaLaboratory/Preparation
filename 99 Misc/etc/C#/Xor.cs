using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etc
{
    public class Xor
    {
        /// <summary>
        /// Given a non-empty array of integers, every element appears twice except for one. 
        /// Find that single one.
        /// </summary>
        public int GetSingelEntry(List<int> list)
        {
            int result = 0;
            foreach (var item in list)
            {
                result ^= item;
            }

            return result;
        }
    }
}
