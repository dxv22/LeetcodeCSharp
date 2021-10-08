using System;

namespace LeetcodeCSharp
{
    class Program
    {
        // Reverse String
        public char[] ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            char curr;

            while (i <= j)
            {
                curr = s[i];
                s[i] = s[j];
                s[j] = curr;
                i++;
                j--;
            }
            return s;
        }

        public string Test()
        {
            return "ADF";
        }

        static void Main(string[] args)
        {
            Program test = new Program();

            // String reverse
            char[] test1 = { 'A', 'B', 'C', 'D' };
            Console.WriteLine(test.ReverseString(test1));
        }
    }
}
