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
      Console.WriteLine(explicitVar);
      Console.WriteLine(implicitVar);

      var count = 1; // Assign initial value
      Console.WriteLine("Old value " + count);
      count = 2;     // Update to new value
      Console.WriteLine("New value " + count);

      var calculator = new Calculator();
      var sum = calculator.Add(2, 5);

      Console.WriteLine("Sum is " + sum);
    }
  }
}