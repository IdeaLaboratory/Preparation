using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    /// <summary>
    /// Find the number of words in a camelCaseWords
    /// e.g. camelCaseWords has 3 words
    /// </summary>
    class CamelCaseWords
    {
        internal int FindNumberOfWords(string words)
        {
            int count = 1;
            foreach (char ch in words)
            {
                if ((int)ch > 65 && (int)ch < 90)
                    ++count;
            }
            return count;
        }
    }
}
