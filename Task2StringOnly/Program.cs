using System;

class Program
{
  static void Main(string[] args)
  {
    string str = "a=2,t=5,c=3";

    string letters = "";
    string digits = "";

    foreach (char c in str)
    {
      if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
      {
        letters += c;
      }
      else if (c >= '0' && c <= '9')
      {
        digits = c + digits;
      }
    }

    string result = letters + digits;
    Console.WriteLine(result);
  }
}
