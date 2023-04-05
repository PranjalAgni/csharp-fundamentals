using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Basics
{
  static class Dictionary
  {
    public static void Run()
    {
      Dictionary<string, int> ages = new Dictionary<string, int>();
      ages.Add("Alice", 25);
      ages.Add("Bob", 30);
      ages.Add("Charlie", 35);

      // We can also use the index operator to add or modify values:
      ages["David"] = 40;
      ages["Alice"] = 26;

      Console.WriteLine(ages["Alice"]); // aliceAge = 26

      Console.WriteLine(ages.ContainsKey("Bob")); // hasBob = true

      // remove a key
      ages.Remove("David");

      foreach (KeyValuePair<string, int> pair in ages)
      {
        Console.WriteLine("{0} is {1} years old", pair.Key, pair.Value);
      }
      // Output: 
      // Alice is 26 years old
      // Bob is 30 years old
      // Charlie is 35 years old

      Console.WriteLine(new List<string>(ages.Keys)); // keys = { "Alice", "Bob", "Charlie" }
      Console.WriteLine(new List<int>(ages.Values)); // values = { 26, 30, 35 }
    }
  }
}