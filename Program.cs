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
      var watch = Stopwatch.StartNew();
      Console.OutputEncoding = UTF8Encoding.UTF8;




      watch.Stop();
      long memoryAfter = GC.GetTotalMemory(true);
      long consumedMemory = memoryAfter - memoryBefore; // Calculate consumed memory
      Console.WriteLine($"Memory consumed: {consumedMemory} bytes");
      Console.WriteLine($"Час роботи програми: {watch.ElapsedMilliseconds}мс");
    }
  }
}
