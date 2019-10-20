
# Working With Files
# Working with Paths.
> Note this is not the best implementation.We will refactor this code as we go along. Introduce (Linq and OOP) later.But it will get us started.
## What are path?
A path is a slash-separated list of directory names followed by either a directory name of a file name. A directory is the same as a folder.

```bash
E:\Data\MyStuff            (path terminating in a directory name)
E:\Data\MyStuff\roads.shp  (path terminating in a file name)
```
> PathName

Path, Pathname are synonymous
```bash
    Example of AbsolutPath

C:\Users\eduuh\source\repos\Csharp\03_workingwithStrings\02_workingwithCSVFile\football.csv"


02_workingwithCSVFile => is the working directory
football.csv          => our filename in the path
```
## Forward Versus Backward slashes
The Windows conventions is to use a backward slash (\) as the separator in a path. Unix systems use the forward slash (/).

## BackWard slash in C# code
C# treats the backslash (\) as the escape characters. For example **\n** signifies a carriage return(New Line).Since paths contains backslashes, you need to prevent backslashes from beign used as the escape character. A common technique is to escape the backslash as follows.

```Csharp
var path = "C:\\Users\\eduuh\\source\\repos\\Csharp\\03_workingwithStrings\\02_workingwithCSVFile\\football.csv"
```
## With String Verbatim Literals
You can avoid using the above by using something like this
```c#
var path = @"C:\Users\eduuh\source\repos\Csharp\03_workingwithStrings\02_workingwithCSVFile\football.csv"
```
> There are Many types of paths
1. **Relative paths**
     - A relative paths refers to a locatin that is relative to the current directory. Relative paths make use of two special symbols,a dot (.) and a double-dot(..), which translates into current directory and the parent directory. Double dots are use for moving up in  the hierarchy. A single dot represents the current directory itself.
   
2. **Absolute paths**
     - Absolute/full, paths begin with a drive letter followed by a colon, such as **C:**
3. **Url paths**
     - A path to files in a remote server.

## Visual studio code.
Visual studio code works on projects in directory based way. Meaning its more aware of the parent directory and relative paths of the files. We could use this to more productive.

## Why use Relative paths over Absolute Paths
When using absolute paths, Your code tends to break each time you change the location folder to a new location. You will be need to change the path each time you change.

If collabolating with a frd on a project. The paths will never be similar. The code will not work in this case too. they may be needed to configure the path variable to their local paths. 

## What to use.?
Assuming the Csv file is in the project folder.

We use class **Environment** in system namespace to get the Current directory of your folder. then concantanate with the **relative path**

## using string Interpolation
```C#
var reader = new StreamReader($"{Environment.CurrentDirectory}/football.csv");
```
## How to get Absolute and Relative path from VSCode
1. Navigate to your explorer window to the file of intrest.
2. Right click on the file.
3. Click on either copy **path(absolute)** , **copy Relative path**
<br><br>
![relativepaths](images\relativeabsolutpathvscode.png)

Write the following lines of code
```C#
// Using the StreamReader to read our csv
var reader = new StreamReader($"{Environment.CurrentDirectory}/football.csv");

### Use some Debugging here.
  while (!reader.EndOfStream)
{
  //one line is saved to this variable and each time we loop its replaced with the next line.
  var line = reader.ReadLine();
  //Prints out eachline to the console
  Console.WriteLine(line)
}

```
## We want to analyze this Data
### we are just reading and printing it out

Remmember string are usually immutable.Each time we loop and append the result of one line to a string dotnet will be creating a new string.This can be perfomance heavy. We choose to use **StringBuilder** class which is most suited to building strings.

Since we will be working to anayze the data. **StringBuilder** class is limited in the number of fuctinality. We can Create a string and copy all the data from the **stringbuilder object** using the **ToString()** method.

```C#
// Comment or Refactor the above code to
var teamsData = new StringBuilder();
while (!reader.EndOfStream)
{
  // Weird the newline escapesequence does not work
  teamsData.Append(@$"{reader.ReadLine()} {Environment.NewLine}");
}

//Print out to console
string teamsdatacopy = teamsData.ToString();
      // Confirm ++>
Console.WriteLine(teamsdatacopy);
```
Loop in the collections

```C#
foreach (var firstteam in firstteams)
{
  // We are able to getDetails
  //Console.WriteLine(firstteam.Split(",")); return string[] objects
  // we need to loop in the object ot get the expected results

  foreach (var item in firstteam.Split(","))
  {
      System.Console.WriteLine(item);
  }
}
```
## Lets continue form Here! Anaysis
## You can try implementing this. Loop,Loop until you get all!
 1. Number of goals each team scored.
 2. A string[] of teams played with a team : say *Chelsea*
 3. Create a lineup table for all the teams.
>> Happy Coding!!