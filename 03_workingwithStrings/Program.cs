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
      #region BasicStuff
      string testString = "this is some string to use in some examples";
      string testString2 = "this is some string to use in some examples";
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