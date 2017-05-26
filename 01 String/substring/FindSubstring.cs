using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    public class FindSubstring
    {
        /// <summary>
        /// O(n)
        /// Find if substring
        /// </summary>
        /// <param name="str1">First String in which given substring will be searched</param>
        /// <param name="str2">Given string to search</param>
        /// <returns></returns>
        internal bool IsSubString(string str1, string str2)
        {
            bool isSubString = false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[0])
                {
                    bool areSame = true;
                    for (int j = 1; j < str2.Length; j++)
                    {
                        if (str1[++i] != str2[j])
                        {
                            areSame = false; --i;
                            break;
                        }
                    }
                    if (areSame)
                    {
                        isSubString = true;
                        break;
                    }
                }
            }
            return isSubString;
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            string str1 = "asldknalndknaksmndkabsnkdaskdbkabskdbkasbdkbaksbdnasndlnasdnlasndknaskndb";
            string str2 = "kasb";

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