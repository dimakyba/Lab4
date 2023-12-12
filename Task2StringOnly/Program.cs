using System;

class Program
{
  static void Main(string[] args)
  {
    string str = "a=2,t=5,c=3";

    string result = "";
    // string digits = "";

    foreach (char c in str)
    {
      if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
      {
        result += c;
      }
    }
    int strLastIndex = result.Length;
    foreach (char c in str)
    {

      if (c >= '0' && c <= '9')
      {
        result = result.Insert(strLastIndex, c.ToString());
      }
    }
    Console.WriteLine(result);
  }
}
