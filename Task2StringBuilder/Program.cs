using System;
using System.Text;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "a=2,t=5,c=3";

      StringBuilder sb = new StringBuilder();
      foreach (char c in str)
      {
        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
        {
          sb.Append(c);
        }

      }
      int strLastIndex = sb.ToString().Length;
      foreach (char c in str)
      {

        if (c >= '0' && c <= '9')
        {

          sb.Insert(strLastIndex, c);
        }

      }

      string result = sb.ToString();
      Console.WriteLine(result);
    }
  }
}
