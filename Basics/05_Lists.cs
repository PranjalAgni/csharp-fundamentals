using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Basics
{
  static class Lists
  {
    public static void Run()
    {
      List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
      foreach (var number in numbers)
      {
        // // Output: 1,2,3,4,5,6
        Console.WriteLine(number);
      }

      numbers[0] = 10;
      foreach (var number in numbers)
      {
        // Output: 10,2,3,4,5,6
        Console.WriteLine(number);
      }

      numbers.Remove(6);
      foreach (var number in numbers)
      {
        // Output: 10,2,3,4,5
        Console.WriteLine(number);
      }

      // Output: Count is 5
      Console.WriteLine($"Count is {numbers.Count}");

      int evenNumber = numbers.Find(number => number % 2 == 0);
      Console.WriteLine($"Even number {evenNumber}"); // Output: 10

      numbers.Sort();
      foreach (var number in numbers)
      {
        // Output: 2,3,4,5,10
        Console.WriteLine(number);
      }

    }
  }
}