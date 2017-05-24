using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcdefgh";
            string str2 = "efg";

            FindSubstring substring = new FindSubstring();
            bool isSubstring = substring.IsSubString(str1, str2);

            if (isSubstring)
            {
                Console.WriteLine(str2 + " Is a substring of " + str1);
            }
            else
            {
                Console.WriteLine("Not substring");
            }
        }
    }
}
