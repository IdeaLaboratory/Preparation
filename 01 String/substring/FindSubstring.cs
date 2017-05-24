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
        /// O(n^2) or O(n x m)
        /// Find if substring
        /// </summary>
        /// <param name="str1">First String in which given substring will be searched</param>
        /// <param name="str2">Given string to search</param>
        /// <returns></returns>
        internal bool IsSubString(string str1, string str2)
        {
            bool isSubString = false;
            for (int i = 0; i < str1.Length - 1; i++)
            {
                if (str1[i] == str2[0])
                {
                    bool areSame = true;
                    for (int j = 1; j < str2.Length - 1; j++)
                    {
                        if (str1[i + j] != str2[j])
                        {
                            areSame = false;
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
}