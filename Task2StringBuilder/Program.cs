using System;
using System.Text;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "a=2,t=5,c=3";

      StringBuilder letters = new StringBuilder();
      StringBuilder digits = new StringBuilder();

      foreach (char c in str)
      {
        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
        {
          letters.Append(c);
        }
        else if (c >= '0' && c <= '9')
        {
          digits.Insert(0, c);
        }
      }
      string result = letters.ToString() + digits.ToString();
      Console.WriteLine(result);
    }
  }
}
