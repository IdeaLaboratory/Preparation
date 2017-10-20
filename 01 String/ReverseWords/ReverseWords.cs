using System;

namespace substring
{
    class ReverseWords
    {
        internal string[] ReverseString(string str)
        {
            return str.Split(' ');
        }
    }

    class Driver
    {
        static string str = "My name is Adi";
        public static void Main(string[] args)
        {
            ReverseWords rString = new ReverseWords();
            string[] words = rString.ReverseString(str);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + ' ');
            }
        }

    }
}
