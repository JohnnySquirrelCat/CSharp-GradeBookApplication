using GradeBook.GradeBooks;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;

namespace GradeBook.UserInterfaces
{
  public static class StartingUserInterface
  {
    public static bool Quit = false;
    public static void CommandLoop()
    {
      while (!Quit)
      {
        Console.WriteLine(string.Empty);
        Console.WriteLine(">> What would you like to do?");
        var command = Console.ReadLine().ToLower();
        CommandRoute(command);
      }
    }

    public static void CommandRoute(string command)
    {
      if (command.StartsWith("create"))
        CreateCommand(command);
      else if (command.StartsWith("load"))
        LoadCommand(command);
      else if (command.StartsWith("delete"))
        DeleteCommand(command);
      else if (command.StartsWith("list"))
        ListCommand();
      else if (command == "help")
        HelpCommand();
      else if (command == "quit" || command == "exit")
        Quit = true;
      else
        Console.WriteLine("{0} was not recognized, please try again.", command);
    }

    public static void CreateCommand(string command)
    {
      var parts = command.Split(' ');
      if (parts.Length != 4)
      {
        Console.WriteLine(" Command not valid, Create requires a name, type of gradebook, if it's weighted (true / false). ");
        return;
      }
            
      string name = parts[1];
      string type = parts[2];

      bool isWeighted = false;
      if (parts[3] == "true")
        isWeighted = true;

      BaseGradeBook gradeBook; // = new BaseGradeBook(name);
      switch (type)
      {
        case "standard":
          gradeBook = new StandardGradeBook(name, isWeighted);
          break;
        case "ranked":
          gradeBook = new RankedGradeBook(name, isWeighted);
          break;
        default:
          Console.WriteLine("{0} is not a supported type of gradebook, please try again ", type);
          return;          
      }

      //if (type == "standard")
      //  gradeBook = new StandardGradeBook(name, isWeighted);
      //else if (type == "ranked")
      //  gradeBook = new RankedGradeBook(name, isWeighted);
      //else
      //{
      //  Console.WriteLine("{0} is not a supported type of gradebook, please try again ", type);
      //  return;
      //}

      Console.WriteLine("\nCreated gradebook {0}.", name);
      GradeBookUserInterface.CommandLoop(gradeBook);
    }

    public static void LoadCommand(string command)
    {
      var parts = command.Split(' ');
      if (parts.Length != 2)
      {
        Console.WriteLine("Command not valid, Load requires a name.");
        return;
      }
      var name = parts[1];
      var gradeBook = BaseGradeBook.Load(name);

      if (gradeBook == null)
        return;

      GradeBookUserInterface.CommandLoop(gradeBook);
    }

    public static void DeleteCommand(string command)
    {
      var parts = command.Split(' ');

      if (parts.Length != 2)
      {
        Console.WriteLine("Command not valid, Delete requires a name.");
        return;       
      }

      string name = parts[1];

      if (!File.Exists(name + ".gdbk"))
      {
        Console.WriteLine(name + " Gradebook coudl not be found \n");
        return;
      }
      else
      {
        File.Delete(name + ".gdbk");
        Console.WriteLine(name + " Gradebook has been deleted \n");
        return;
      }
      

    }

    public static void ListCommand()
    {
               
      //if (File.Exists(savedGBPath))
      {
        List<string> lstPathsWFiles = new List<string>(Directory.GetFiles(@"C:\Users\JClark\Documents\GitHub\CSharp-GradeBookApplication\GradeBook\bin\Debug\netcoreapp2.0"));
        
        List<string> lstFiles = new List<string>();
        List<string> lstFiles2 = new List<string>();
        List<string> lstGradeBooks = new List<string>();

        Console.WriteLine();
        Console.WriteLine("Here is a list of all the saved Grade books. ");
        Console.WriteLine();

        // trying to see if I can check whether or not if the user has saved any grade books yet 
        //if (lstPathsWFiles.Where(x => x.EndsWith(".gdbk")))
        {
          lstGradeBooks = lstPathsWFiles.Where(x => x.EndsWith(".gdbk")).ToList();

          foreach (string lst in lstGradeBooks)
          {
            lstFiles = lst.Split('\\').ToList();
            foreach (string file in lstFiles)
            {
              if (file.EndsWith(".gdbk"))
              {
                lstFiles2 = file.Split(".").ToList();
                foreach(string file2 in lstFiles2)
                  {
                    if(file2 != "gdbk")
                      Console.WriteLine(file2);
                  }
                
              }

            }

          }

        }

      }
      //else
      //{
      //  Console.WriteLine("\n SAVE PATH NOT FOUND \n");
      //}
    }

    public static void HelpCommand()
    {
      //Console.WriteLine();
      Console.WriteLine("\n GradeBook accepts the following commands: \n");
      //Console.WriteLine();
      Console.WriteLine(" Create 'Name' 'Type' 'Weighted' - Creates a new gradebook where 'Name' is the name of the gradebook, 'Type' is what type of grading it should use, and 'Weighted' is whether or not grades should be weighted (true or false). \n");
      //Console.WriteLine();
      Console.WriteLine(" Load 'Name' - Loads the gradebook with the provided 'Name'. \n");
      //Console.WriteLine();
      Console.WriteLine(" Delete 'Name' - Deletes the gradebook with the provided 'Name' \n");
      //Console.WriteLine();
      Console.WriteLine(" List - Displays all of the grade books that are made. \n");
      //Console.WriteLine();
      Console.WriteLine(" Help - Displays all accepted commands. \n");
      //Console.WriteLine();
      Console.WriteLine(" Quit - Exits the application \n");
    }
  }
}
