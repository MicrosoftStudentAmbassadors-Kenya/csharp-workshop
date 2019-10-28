using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _05_Linq
{
  class Program
  {
    static void Main(string[] args)
    {
      var football = ReadFile(@"./football.json");
      Console.WriteLine("Hello World!");

      var obj = JsonConvert.DeserializeObject<Football>(football);
      System.Console.WriteLine(obj);
    }
  }
}
