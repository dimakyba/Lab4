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
      uint n = 100000;
      string result = n.ToString();

      var watch = Stopwatch.StartNew();
      for (uint i = n - 1; i > 0; i--)
      {
        result = i.ToString() + " " + result;
      }

      watch.Stop();
      System.Console.WriteLine(result);
      long memoryAfter = GC.GetTotalMemory(true);
      long consumedMemory = memoryAfter - memoryBefore;
      System.Console.WriteLine($"Пам'яті спожито: {consumedMemory} байт або {consumedMemory / 1024.0} кілобайт");
      System.Console.WriteLine($"Час виконання програми: {watch.ElapsedMilliseconds}мс");
    }
  }
}
