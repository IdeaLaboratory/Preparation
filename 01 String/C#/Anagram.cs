using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class Anagram
    {
        /// <summary>
        /// This function will remove strings if its a anagram of any previous string already not removed.
        /// </summary>
        /// <param name="text">A text contains list of strings.</param>
        /// <returns>list of unique strings</returns>
        public IEnumerable<string> RemoveAnagrams(IEnumerable<string> text)
        {
            char[] sorted;
            var dict = new Dictionary<string, string>();
            foreach (var s in text)
            {
                sorted = s.ToArray();
                Array.Sort(sorted);
                string key = new string(sorted);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, s);
                }
            }

            return dict.Values;
        }
    }
}
