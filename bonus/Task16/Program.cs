using System;
using System.Text;

namespace N
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      1 filter
      2 to_small
      3 sort
      4 compare
      */
      string s = Console.ReadLine();
      string s1 = Console.ReadLine();
      // string s = "«Tom Marvolo Riddle»";
      // string s1 = "«I am Lord Voldemort!»";
      s = SortStringByAscii(FilterLetters(s).ToLower());
      s1 = SortStringByAscii(FilterLetters(s1).ToLower());
      if (s == s1)
      {
        System.Console.WriteLine("YES");
      }
      else
      {
        System.Console.WriteLine("NO");
      }
    }
    static string FilterLetters(string input)
    {
      StringBuilder sb = new StringBuilder();
      foreach (char c in input)
      {
        if (char.IsLetter(c))
        {
          sb.Append(c);
        }
      }
      return sb.ToString();
    }

    static string SortStringByAscii(string input)
    {
      char[] chars = input.ToCharArray();
      Array.Sort(chars);
      string result = new string(chars);
      return result;
    }


  }
}
