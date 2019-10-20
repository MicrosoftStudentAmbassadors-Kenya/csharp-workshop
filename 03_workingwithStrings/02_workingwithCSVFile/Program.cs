using System.Linq;
using System.Text;
using System.IO;
using System;


namespace _02_workingwithCSVFile
{
  class Program
  {
    /// <summary>
    /// First implement this implementation
    /// You will find the refactored code in _02_WorkingwithcsfFileRefactored
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      /// Make sure you change the path to the local path of the csv file in the directory
      //var reader = new StreamReader(File.OpenRead(@"C:\Users\Edwin Muraya\source\repos\Csharp\03_workingwithStrings\02_workingwithCSVFile\football.csv"));
      var reader = new StreamReader($"{Environment.CurrentDirectory}/football.csv");
      ///  To understand what happening we could use some debugging.
      /// Hover your cursor to the end of line While(!reader.EndofStream) opening brace. Untill a ball is shown.
      /// click on the ball Untill the ball stay there.!-- 
      /// That is a breakpoint.!-- readmore on https://code.visualstudio.com/docs/editor/debugging
      /// The while reads oneline at a time using ReadLine() method.
      /// The one line read from the csv file the value is save in the line variable name.

      //  while (!reader.EndOfStream)
      // {
      //   //one line is saved to this valiable and each time we loop itsreplace with the next line.
      //   var line = reader.ReadLine();
      //   Console.WriteLine(line)
      // }


      // that is good Right?
      ///But not what we want we want to work with the data we need away to save all this infomation as one
      /// string and work with it from there. Let do just  that. 

      //Comment the above while loop.
      /// <summary>
      /// Remember the string class will not be efficient in this case since its immutable.!--
      /// We choose to use the StringBuilder class.
      /// </summary>
      /// <value></value>
      var teamsData = new StringBuilder();
      while (!reader.EndOfStream)
      {
        // Weird the newline escapesequence does not work
        teamsData.Append(@$"{reader.ReadLine()} {Environment.NewLine}");
      }
      //pefect we could start working with our data.
      //Console.WriteLine(teamsData);
      // we need a way to extract the informatin
      // string builder in not efficient with this. We will create a new string variable and copy over our data

      //Later we will use Linq to process this data well
      string teamsdatacopy = teamsData.ToString();
      // Confirm ++>
      //Console.WriteLine(teamsdatacopy);
      string[] firstteams = teamsdatacopy.Split($"{Environment.NewLine}");

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

      
    // string Manchesterteams =FootballAnaylsis.PlayedWithAway("Man Chester", teamsdatacopy);
     //Console.WriteLine(Manchesterteams);
    }
  }

  public static class FootballAnaylsis
  {

    // all season the teams played with which team
    // working with loop give uncessary errors.
    // This line does not work collectly
    public static string PlayedWithAway(string teamsname, string data)
    {
      var teamsplayed = new StringBuilder();
      string[] firstteams = data.Split($"{Environment.NewLine}");
      foreach (var team in firstteams)
      {
        string[] teamdata = team.Split(",");
        if(teamdata[0] == "") 
        return String.Empty;
        if (teamdata[1] == teamsname)
        {
          teamsplayed.Append(team[2]);
        }

      }
      return teamsplayed.ToString();


      //  // the number of scores a team had after the season. (pass the team name)
      // }
    }
  }
}