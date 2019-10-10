## Learn how to read the documentation of the methods.
- What will you you be looking for in the documentation.
      - objects signatures 
         - what are object you my ask.
               - methods  and properties. How do you know what is what
### Methods 
This are shown by a cube like thing 
the properties  are shown by a spanner symbol.

## Lets Get into It 
Every program need string as form of datatype. System.String class is used to create string objects. 
What can we do to string 
 1. We can build strings
     - we do continous modification of string types.
 2. Formatting expressions
 3. Regular expressions.
 4. Span<T> - Allows fast access to string without actually copying the string . Fast memory access.

 ## Examine the System.String class
    we are going to look at some methods.
1. compare 
     - this compares the content of string ,takin into account the culture (locale) in equivalence between certain characters.
2. compareordinal
     - this compares the content of string without taking into account the ordinal (locale) characteristic.
3. Concat 
      combine two string into one string instance
4. copyto 
     - copies a specific number of characters to an entirly new instance of an array.
5. Indexof
    - Locate the occurence of a given substring and returns the value of the index.
6. ToLower
7. ToUpper
8. Trim
9. Split

## Building Strings
If you notices String class is a very powerfull class to implement with a very large number of usefull methods.However string has a shortcomming, or it could be an advantage. It depends of how you want to argue it out. Let this of it as a shortcoming for now.Strings are immutable data type. which means that after you initialize, a string object cannot change. 
- You will be actually required to make other string and copy some parts

Microsoft provide a different class to create new strings. called System.Text.StringBuilder class. It is not as powerfull as the string class with the number of methods it provide.The processing you can do on string builder is limited to the following.
    
  - Appending
  - substitution
  - Removing text
However it works in a more efficient way.
## Methods
- Append       Appends a string to the current string.
- AppendFormat Appends a string that has been formatted from a format specifier.
- Insert       Inserts a substring into the current string.
- Remove       Removes characters from the current string.
- Replace      Replaces all occurrences of a character with another character or a substring with another substring in the current string.
- ToString     Returns the current string cast to a System.String object (overridden from System. Object)

properties are 
- Length => the size of the array
- Capacity => used to declare the size of the string builder.

## String Formats
## String Interpolations 

C# 6 introduces string interpolations. Where we prefix $"" on strings  Which removed the need to call. String.Format(). but the code will get translated to the String.Format() style.

## Escape Sequence
Escape sequence	Character name	Unicode encoding
\'	Single quote	0x0027
\"	Double quote	0x0022
\\	Backslash	0x005C
\0	Null	0x0000
\a	Alert	0x0007
\b	Backspace	0x0008
\f	Form feed	0x000C
\n	New line	0x000A
\r	Carriage return	0x000D
\t	Horizontal tab	0x0009
\v	Vertical tab	0x000B


## String Interpolations
Use string interpolation to improve the readability and maintainability of your code. String interpolation achieves the same results as the String.Format method, but improves ease of use and inline clarity.

```Csharp
var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

// Output:
// Jupiter Hammon was an African American poet born in 1711.
// He was first published in 1761 at the age of 50.
// He'd be over 300 years old today. 
```
