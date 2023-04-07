using System;

#pragma warning disable CS0219
#pragma warning disable CS8600
#nullable enable

namespace CSharpFundamentals.Basics
{
  static class Nullability
  {
    public static void Run()
    {
      // In C#, the null literal is used to denote the absence of a value. A nullable type is a type that allows for null values.

      string nullableReferenceType = "hello";
      nullableReferenceType = null; // Valid as type is nullable

      int nonNullableValueType = 5;
      // nonNullableValueType = null; // Compile error as type is not nullable

      int? nullableValueType = 5; // Define nullable value type
      nullableValueType = null;   // Valid as type is nullable


      // Accessing a member of a variable whose value is null will compile fine, but result in a NullReferenceException being thrown at runtime:
      string sentence = null;

      // Throws NullReferenceException at runtime
      // Console.WriteLine("Length = " + sentence.Length);

      // the null-coalescing operators
      // The ?? operator allows one to return a default value when the value is null:
      string? name1 = "John";
      Console.WriteLine(name1 ?? "Paul"); // => "John"

      string? name2 = null;
      Console.WriteLine(name2 ?? "George"); // => "George"

      // Null-conditional operators ?. and ?[]
      string? fruit = "apple";
      Console.WriteLine(fruit?.Length); // => 5

      string? vegetable = null;
      Console.WriteLine(vegetable?.Length); // => null
    }
  }
}