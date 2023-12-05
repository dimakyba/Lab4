using System;
using System.Text;

namespace Bonus
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = Console.ReadLine();
      // string s = "(++.)(()/)дамба";
      // string s = "())(()";
      string s2 = "(++.)(()/))дамба";
      if (ValidateParentheses(s)) {
        System.Console.WriteLine("YES");
      } else {
        System.Console.WriteLine("NO");
      }
    }

    // static string FilterParentheses(string input)
    // {
    //   StringBuilder sb = new StringBuilder();
    //   foreach (char c in input)
    //   {
    //     if (c == '(' || c == ')')
    //     {
    //       sb.Append(c);
    //     }
    //   }
    //   return sb.ToString();
    // }

    static bool ValidateParentheses(string input)
    {
      uint counter = 0;
      foreach (char c in input)
      {
        if (c == '(')
        {
          counter++;
        }
        else if (c == ')')
        {
          if (counter == 0)
          {
            return false;
          }
          counter--;
        }
      }
      return counter == 0;
    }

  }
}
