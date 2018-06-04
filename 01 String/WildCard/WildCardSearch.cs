using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wildCard
{
    public class WildCardSearch
    {
        
        static bool IsAnagram(string str, string pattern)
        {
            bool retult = true;

            for (int i = 0; i < pattern.Length - 1; i++)
            {
                if (pattern[i] == '*') //special case
                {
                    // 0) nothing after that
                    if (i >= pattern.Length - 1) //next is letter
                        break;
                    // 1) amything after that?
                    if (i < pattern.Length - 1 && char.IsLetterOrDigit(pattern[i + 1]))    //next is letter
                        continue;

                }
                else
                {
                    if (pattern[i] != str[i])
                    {
                        retult = false;
                        break;
                    }
                }
            }
            return retult;
        }

        // Function that matches input str with
        // given wildcard pattern
        public static bool WildCard(string str, string pattern, int n, int m)
        {
            // empty pattern can only match with
            // empty string
            if (m == 0)
                return (n == 0);

            // lookup table for storing results of
            // subproblems
            bool[,] lookup = new bool[4, 4];

            // initailze lookup table to false
            //memset(lookup, false, sizeof(lookup));

            // empty pattern can match with empty string
            lookup[0, 0] = true;

            // Only '*' can match with empty string
            for (int j = 1; j <= m; j++)
                if (pattern[j - 1] == '*')
                    lookup[0, j] = lookup[0, j - 1];
            printLookup(lookup);
            // fill the table in bottom-up fashion
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    // Two cases if we see a '*'
                    // a) We ignore ‘*’ character and move
                    //    to next  character in the pattern,
                    //     i.e., ‘*’ indicates an empty sequence.
                    // b) '*' character matches with ith
                    //     character in input
                    if (pattern[j - 1] == '*')
                        lookup[i, j] = lookup[i, j - 1] ||
                                       lookup[i - 1, j];

                    // Current characters are considered as
                    // matching in two cases
                    // (a) current character of pattern is '?'
                    // (b) characters actually match
                    else if (pattern[j - 1] == '?' ||
                             str[i - 1] == pattern[j - 1])
                        lookup[i, j] = lookup[i - 1, j - 1];

                    // If characters don't match
                    else lookup[i, j] = false;

                    printLookup(lookup);
                }
            }

            return lookup[n, m];
        }

        static void printLookup(bool[,] lookup)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(lookup[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
            for (int i = 0; i < str.Length-1-pattern.Length-1; i++)
            {
                bool moveWindow = false;
                for (int j = 0; j < pattern.Length-1; j++)
                {
                    if (pattern[j] != str[i])
                    {
                        moveWindow = true;
                        break;
                    }
                    if
                }

            }*/
