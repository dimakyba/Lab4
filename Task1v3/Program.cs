using System;
using System.Text;
using System.Diagnostics;

namespace Lab4
{
  class Program
  {
    static void Main(string[] args)
    {
      long memoryBefore = GC.GetTotalMemory(true);
      Console.OutputEncoding = UTF8Encoding.UTF8;
      System.Console.Write("Введіть натуральне число n: ");
      // uint n = uint.Parse(Console.ReadLine());
      uint n = 200000;

      StringBuilder result = new StringBuilder();
      result.Append(1);
      var watch = Stopwatch.StartNew();
      for (uint i = 2; i <= n; i++)
      {
        result.Append(i.ToString());
        result.Append(" ");
      }

      System.Console.WriteLine(result);
      watch.Stop();
      long memoryAfter = GC.GetTotalMemory(true);
      long consumedMemory = memoryAfter - memoryBefore;
      System.Console.WriteLine();
      System.Console.WriteLine($"Пам'яті спожито: {consumedMemory} байт або {consumedMemory / 1024.0} кілобайт");
      System.Console.WriteLine($"Час виконання програми: {watch.ElapsedMilliseconds}мс");
    }
  }
}
