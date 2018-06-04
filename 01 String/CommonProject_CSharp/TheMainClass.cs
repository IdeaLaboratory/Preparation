using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wildCard;

namespace substring
{
    public class TheMainClass
    {
        public static void Main(string[] args)
        {
            #region Wild card search
            //string mainString = "abc";
            //string pattern = "a*c";
            ////WildCardSearch wildCardSearch = new WildCardSearch();
            ////Console.WriteLine(IsAnagram(mainString, pattern));
            //WildCardSearch.WildCard(mainString, pattern, 3, 3); 
            #endregion

            CamelCaseWords camelCase = new CamelCaseWords();
            Console.WriteLine(camelCase.FindNumberOfWords("camelCaseWords"));
        }

        /*
     * Complete the simpleArraySum function below.
     */
        static int alice = 0, bob = 0;
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {

            AssignPoints(a0, b0);
            AssignPoints(a1, b1);
            AssignPoints(a2, b2);
            int[] ab = new int[2];
            ab[0] = alice;
            ab[1] = bob;

            return ab;
        }

        static void AssignPoints(int a0, int b0)
        {
            if (a0 > b0)
                alice++;
            else if (a0 < b0)
                bob++;
        }
    }
}
