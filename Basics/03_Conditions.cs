using System;

namespace CSharpFundamentals.Basics
{
  static class Conditions
  {
    public static void Run()
    {
      int x = 6;

      if (x == 5)
      {
        Console.WriteLine("Execute logic if x equals 5");
      }
      else if (x > 7)
      {
        Console.WriteLine("Execute logic if x greater than 7");
      }
      else
      {
        Console.WriteLine("Execute logic in all other cases");
      }
    }
  }
}