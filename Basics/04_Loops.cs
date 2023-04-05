using System;
namespace CSharpFundamentals.Basics
{
  static class Loops
  {
    public static void Run()
    {
      char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

      for (int i = 0; i < vowels.Length; i++)
      {
        // Output the vowel: aeiou
        Console.Write(vowels[i]);
      }

      Console.WriteLine();
      foreach (char vowel in vowels)
      {
        // Output the vowel: aeiou
        Console.Write(vowel);
      }

      Console.WriteLine();
      int index = 0;

      while (index < vowels.Length)
      {
        // Output the vowel: aeiou
        Console.Write(vowels[index]);
        index += 1;
      }

      Console.WriteLine();
      index = 0;
      do
      {
        // Output the vowel: aeiou
        Console.WriteLine(vowels[index]);
        index += 1;
      } while (index < vowels.Length);
    }
  }
}