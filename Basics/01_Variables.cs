using System;

namespace CSharpFundamentals.Basics
{
  class Calculator
  {
    public int Add(int x, int y)
    {
      return x + y;
    }
  }

  static class Variables
  {
    public static void Run()
    {
      int explicitVar = 10; // Explicitly typed
      var implicitVar = 10; // Implicitly typed

      var count = 1; // Assign initial value
      count = 2;     // Update to new value

      var calculator = new Calculator();
      var sum = calculator.Add(2, 5);

      Console.WriteLine("Sum is " + sum);
    }
  }
}