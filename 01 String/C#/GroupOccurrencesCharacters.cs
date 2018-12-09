using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class GroupOccurrencesCharacters
    {
        public string GroupOccChar(string input)
        {
            Dictionary<char, List<char>> keyValues = new Dictionary<char, List<char>>();
            foreach (char ch in input)
            {
                if (keyValues.Keys.Contains(ch))
                {
                    List<char> chrs;
                    keyValues.TryGetValue(ch, out chrs);
                    chrs.Add(ch);
                }
                else
                {
                    var v = new List<char>();
                    v.Add(ch);
                    keyValues.Add(ch, v);
                }
            }
            var allValues = keyValues.Values;
            string newString=null;

            foreach (List<char> item in allValues)
            {
                foreach (var ch in item)
                {
                    newString += ch;
                }
            }
            return newString;
        }
    }
}
