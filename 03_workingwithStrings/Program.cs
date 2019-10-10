using System;
using System.Text;

namespace _03_workingwithStrings
{
  class Program
  {
    static void Main(string[] args)
    {
      //string declaration and initialization
      //
      // Declare without initializing.
      string message1;

      // Initialize to null.
      string message2 = null;

      // Initialize as an empty string.
      // Use the Empty constant instead of the literal "".
      string message3 = System.String.Empty;

      //Initialize with a regular string literal.
      string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

      // Initialize with a verbatim string literal.
      string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

      // Use System.String if you prefer.
      System.String greeting = "Hello World!";

      // In local variables (i.e. within a method body)
      // you can use implicit typing.
      var temp = "I'm still a strongly-typed System.String!";

      // Use a const string to prevent 'message4' from
      // being used to store another string value.
      const string message4 = "You can't get rid of me!";

      // Use the String constructor only when creating
      // a string from a char*, char[], or sbyte*. See
      // System.String documentation for details.
      char[] letters = { 'A', 'B', 'C' };
      string alphabet = new string(letters);

      //Using array Notatin to access the character
      Console.WriteLine(letters[0]);


      //You could deside to loop in the string using a for loop
       for (int i = 0; i < letters.Length; i++)
       {
        Console.WriteLine(letters[i]); // explain this concept further
      }
      // Immutability of string objects
      // String objects are immutable: they cannot be changed after they have been created.
      // All of the String methods and C# operators that appear to modify a string actually return the results in a new string object
      #region Immutability
      string s1 = "A string is more ";
      string s2 = "than the sum of its chars.";

      // Concatenate s1 and s2. This actually creates a new
      // string object and stores it in s1, releasing the
      // reference to the original object.
      s1 += s2;

      // string verbatim literal
      string filePath = @"C:\Users\scoleridge\Documents\";
      //Output: C:\Users\scoleridge\Documents\

      string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
      /* Output:
      My pensive SARA ! thy soft cheek reclined
         Thus on mine arm, most soothing sweet it is
         To sit beside our Cot,... 
      */

      string quote = @"Her name was ""Sara.""";
      //Output: Her name was "Sara."
      System.Console.WriteLine(s1);
      // Output: A string is more than the sum of its chars.
      #endregion
      #region BasicStuff
      string testString = "We are using Visual studio 2019";
      string testString2 = "We are using Visual studio 2019";
      //replace a string
      Console.WriteLine(testString.Replace("2018", "2019"));
      string pathWithoutlength = testString.Substring(10);

      //Gets a section of the string
      string partwithLength = testString.Substring(5, 10);

      //checks for a value inside a string
      bool contains = testString.Contains("to");

      int compare = testString.CompareTo(testString2);
      int length = testString.Length;

      Console.WriteLine(pathWithoutlength);
      Console.WriteLine(partwithLength);
      Console.WriteLine($"the comparison of the two varables is {compare}");
      Console.WriteLine($"the lengh of the string above is {length}");
      Console.WriteLine($"contains for is :=> {contains}");

      // splitting the string 
      string[] teststringsplit = null;
      teststringsplit = testString.Split(",");
      // you want to split the values but you realize when you print out the object
      // you get the object System.String[]
      Console.WriteLine(teststringsplit);

      //this is an array and you want to loop to it
      foreach (var item in teststringsplit)
      {
        Console.Write(item);
      }

      //  The for loop implementation
      for (int i = 0; i < teststringsplit.Length; i++)
      {
        Console.WriteLine(teststringsplit[i]);
      }
      #endregion

      #region  Morepratical split
      //Extracting your domain name from and email
      string email = "edwinkamau@gmail.com";
      string[] domain = email.Split("@");
      Console.WriteLine(domain[1]);

      // Trim
      string names = "Edwin,  muraya,  John  , maina,  edward";
      System.Console.WriteLine(names);


      foreach (var item in names.Split(","))
      {
        Console.WriteLine(item.Trim());
      }

      string[] firtnames = names.Split(",");
      Console.WriteLine(firtnames[1]);
      #endregion

      //Question: are string immurable or mutable .Give an example?

      // Immutability of strings
      string lastname = "Muraya";
      lastname += " Maina";
      // it hard to demo this.
      // what happens is that new instance of object lastname is created. The first instance of lastname is not reference and the next time the garbage
      // collector run . it destroys the variable.
      Console.WriteLine(lastname);

      //Using c# inference typing.
      var middlenames = new StringBuilder("Edwin", 34);
      middlenames.Append("Kamau");
      middlenames.Append("Muraya");
      middlenames.Append("Edwardo");
      middlenames.Append("Kamau");
      //Creates a Giant string => not a list of strings
      for (int i = 0; i < middlenames.Length; i++)
      {
        Console.WriteLine(middlenames[i]);
      }
    }
  }
}