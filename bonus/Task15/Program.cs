using System;
using System.Text;

namespace Bonus
{
  class Program
  {
    static void Main(string[] args)
    {
      // string s = Console.ReadLine();
      // string s1 = Console.ReadLine();
      string s = "coconut;
      string s1 = "   co\nco\t nut  ";
      if (RemoveWhitespaces(s) == RemoveWhitespaces(s1))
      {
        System.Console.WriteLine("YES");
      }
      else
      {
        System.Console.WriteLine("NO");
      }
    }
    /*
    https://www.quora.com/What-are-the-white-spaces-in-C#:~:text=White%20spaces%20in%20C%20refer,in%20the%20C%20programming%20languag
    whitespace - There is no particular symbol for whitespace. Whitespace characters are customarily:
    ‘ ‘ space
    '\t' horizontal tab
    '\n' newline
    '\v' vertical tab
    '\f' feed
    '\r' carriage return
    */
    static string RemoveWhitespaces(string input)
    {
      StringBuilder sb = new StringBuilder();
      foreach (char c in input)
      {
        if (!char.IsWhiteSpace(c))
        {
          sb.Append(c);
        }
      }
      return sb.ToString();
    }
  }
}
