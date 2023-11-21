﻿using System;
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
      uint n = uint.Parse(Console.ReadLine());
      // uint n = 50;

      StringBuilder result = new StringBuilder(n.ToString());

      var watch = Stopwatch.StartNew();
      for (uint i = n - 1; i > 0; i--)
      {
        result.Insert(0, i.ToString() + " ");
      }

      watch.Stop();
      System.Console.WriteLine(result);
      long memoryAfter = GC.GetTotalMemory(true);
      long consumedMemory = memoryAfter - memoryBefore;
      System.Console.WriteLine();
      System.Console.WriteLine($"Пам'яті спожито: {consumedMemory} байт або {consumedMemory / 1024.0} кілобайт");
      System.Console.WriteLine($"Час виконання програми: {watch.ElapsedMilliseconds}мс");
    }
  }
}
