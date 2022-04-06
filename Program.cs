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

    /*  Find the index of the first unique character in a string
        If there are no unique characters return -1
    */
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> letterDict = new Dictionary<char, int>();
        foreach (char letter in s)
        {
            if (letterDict.ContainsKey(letter))
            {
                letterDict[letter]++;
            }
            else
            {
                letterDict.Add(letter, 0);
            }
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (letterDict[s[i]] == 0)
            {
                return i;
            }
        }
        return -1;
    }


        //Valid anagram - return true or false if two words are anagrams of each other
        public bool IsAnagram(string s, string t)
        {
            char[] cs = s.ToCharArray();
            char[] ct = t.ToCharArray();

            Array.Sort(cs);
            Array.Sort(ct);

            String ss = new String(cs);
            String st = new String(ct);

            Console.WriteLine("Is \"{0}\" an anagram of \"{1}\" - " + ss.Equals(st), ss, st);

            return ss.Equals(st);

        }


        static void Main(string[] args)
    {
        Program test = new Program();

        //String reverse

        char[] test1 = { 'A', 'B', 'C', 'D' };
        Console.WriteLine(test.ReverseString(test1));

        //Int reverse
        Console.WriteLine(test.ReverseInt(123456789));
        Console.WriteLine(test.ReverseInt(-321));

        //Valid anagram
        test.IsAnagram("asdsdsd", "xxyysa"); //false
        test.IsAnagram("asds", "ssda"); //true 


    }
  }
}
