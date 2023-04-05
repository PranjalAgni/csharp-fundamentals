using System;
using System.Text;

namespace CSharpFundamentals.Basics
{
  static class Strings
  {
    public static void Run()
    {
      // Verbatim Strings
      // Strings can also be prefixed with the at (@) symbol which makes it a verbatim string that will ignore any escaped characters.
      string escaped = "c:\\test.txt";
      string verbatim = @"c:\test.txt";
      Console.WriteLine(escaped == verbatim); // true

      // C# strings are immutable objects
      string firstName = "John";
      string lastName = "Doe";
      string fullName = firstName + " " + lastName;

      Console.WriteLine(fullName); // Output: John Doe  

      int length = fullName.Length;
      Console.WriteLine(length); // Output: 8

      string uppercaseFullName = fullName.ToUpper();
      Console.WriteLine(uppercaseFullName); // Output: JOHN DOE

      string lowercaseFullName = fullName.ToLower();
      Console.WriteLine(lowercaseFullName); // Output: john doe

      string[] nameParts = fullName.Split(' ');
      Console.WriteLine(nameParts[0]); // Output: John
      Console.WriteLine(nameParts[1]); // Output: Doe

      // Substrings in C#
      string sentence = "Frank chases the bus.";
      string name = sentence.Substring(0, 5);
      Console.WriteLine(name); // Frank

      // IndexOf
      string text = "The quick brown fox jumps over the lazy dog";
      Console.WriteLine(text.IndexOf("brown")); // Output: 10
      Console.WriteLine(text.IndexOf("cat")); // Output: -1
      Console.WriteLine(text.IndexOf("fox", 10, 10)); // Output: 16

      // Concatenate strings in C#.

      // 1. Using the + operator:
      Console.WriteLine(firstName + " " + lastName); // Output: John Doe

      // 2. Using the string.Concat() method:
      string str1 = "Hello";
      string str2 = "World";
      string str3 = string.Concat(str1, " ", str2);

      Console.WriteLine(str3); // Output: Hello World

      // 3. Using the StringBuilder class:
      StringBuilder sb = new StringBuilder();
      sb.Append("The quick brown fox");
      sb.Append(" jumps over");
      sb.Append(" the lazy dog");

      string mergedSentence = sb.ToString();

      Console.WriteLine(mergedSentence); // Output: The quick brown fox jumps over the lazy dog

      // String interpolation in cs
      string greet = "Hello";
      Console.WriteLine($"{greet} {fullName}"); // Hello John Doe

      // String comparison in csharp
      string first = "hello";
      string second = "HELLO";

      // 1. Using the == operator:
      Console.WriteLine(first == second); // false

      // 2. Using the Equals() method:
      // We pass StringComparison.OrdinalIgnoreCase as the second parameter to the method to specify that we want a case-insensitive comparison
      Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase)); // true

      // 3. Using the Compare() method:
      // The Compare() method returns an integer value that indicates the relationship between the two strings (whether they are equal, less than, or greater than each other). 
      Console.WriteLine(string.Compare(first, second, StringComparison.OrdinalIgnoreCase)); // 0

      // 4. Using the Contains() method:
      string searchTerm = "FOX";
      bool contains = text.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
      Console.WriteLine(contains); // Output: True

      // 5. Using the StartsWith() and EndsWith() methods:
      string fileName = "myFile.txt";
      string extension = ".txt";

      bool startsWith = fileName.StartsWith("my");
      bool endsWith = fileName.EndsWith(extension);

      Console.WriteLine(startsWith); // Output: True
      Console.WriteLine(endsWith); // Output: True

    }
  }
}