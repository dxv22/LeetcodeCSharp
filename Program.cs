using System;
using System.Collections.Generic;

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

    // Reverse Int
    public int ReverseInt(int x)
    {
        long reverse = 0;
        long number = x;
        bool negative = x < 0;
        number = Math.Abs(number);

        while (number > 0)
        {
        reverse *= 10;
        reverse += number % 10;
        number /= 10;
        }

        if (reverse > int.MaxValue)
        {
            return 12345;
        }

        int finalReverse = (int)reverse;

        return negative ? finalReverse * -1 : finalReverse;

    }

    // First unique char in string
    public int FirstUniqChar(string s)
    {
      var charDict = new Dictionary<char, int>();
      for (int i = 0; i < s.Length; i++)
      {
        if (charDict.ContainsKey(s[i]))
        {
          //s[i]++;
        }
      }
      return -1;
    }


    static void Main(string[] args)
    {
        Program test = new Program();

            // String reverse
            /*
            char[] test1 = { 'A', 'B', 'C', 'D' };
            Console.WriteLine(test.ReverseString(test1));
            */
            Console.WriteLine(test.ReverseInt(123456789));
            Console.WriteLine(test.ReverseInt(-321));
        }
  }
}
