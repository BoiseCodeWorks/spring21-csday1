// import System from 'system'
using System;
using System.Collections.Generic;
using System.Threading;
using csday1.Models;

namespace csday1
{
  class Program
  {
    static void Main(string[] args)
    {
      // SECTION Number Game
      Console.Clear();
      Console.WriteLine("You Wanna play a game? (Y/N)");
      char choice = Console.ReadKey().KeyChar;
      Console.WriteLine("");
      if (choice == 'y')
      {
        Console.WriteLine("Lets Play!");
      }
      else if (choice == 'n')
      {
        Console.WriteLine("TOO BAD!");
      }
      else
      {
        Console.WriteLine("Your Stupidity is upsetting, lets play anyway");
      }
      bool running = true;
      while (running)
      {
        Console.Write("Calculating random number.");
        int freq = 300;
        for (int i = 0; i < 6; i++)
        {
          Thread.Sleep(750);
          Console.Write('.');
          Console.Beep(freq, 200);
          freq += 50;
        }
        Console.Beep(850, 1500);
        Console.Clear();
        Game game = new Game();
        bool playing = true;
        while (playing)
        {

          Console.Write("What is your guess: ");
          string guess = Console.ReadLine();
          if (int.TryParse(guess, out int intGuess))
          {
            playing = !game.Guess(intGuess);
          }
          else
          {
            Console.WriteLine("Thats not even a number you bozo");
          }
        }
        System.Console.WriteLine("GG BRO");
        System.Console.WriteLine("Play again?");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        if (choice == 'y')
        {
          Console.WriteLine("Lets Play!");
        }
        else if (choice == 'n')
        {
          Console.WriteLine("Bye Loser!");
          running = false;
        }
        else
        {
          Console.WriteLine("Your Stupidity is upsetting, I'm done");
          running = false;
        }
      }









      // AKA console log
      //   Console.WriteLine("Hello World!");

      // SECTION Variable Declaration (TYPES CANNOT BE CHANGED)
      //  IMPLICIT (Type is implied by the assigned value)
      //        var x = "Mark";

      //  EXPLICIT (defines the type as the variable is declared)
      //    string name = "Mark";
      //    char myChar = 'M';
      //    int myNum;
      //    myNum = 8;

      // SECTION PRIMATIVE DATA TYPES

      // STRING (must use " ")
      //   string myName = "Mark";
      //   string myLastName = "Ohnsman";
      //   char myChar = 'M';

      //  CONCAT
      //   Console.WriteLine(myName + " " + myLastName);

      //  INTERPOLAITON ($ at start of string allows for interpolation with { } )
      //   string fullName = $"{myName} {myLastName}";
      //   Console.WriteLine($"{0} {1}", myName, myLastName);
      // @ adds support for linebreaks
      //       Console.Clear();
      //       Console.ForegroundColor = ConsoleColor.Green;
      //       Console.WriteLine($@"
      // {fullName}      

      // Welcome to the party!

      //       ");
      //       Console.ResetColor();

      // BOOLEAN
      //   bool isTrue = true;

      // NUMBER
      //    int (whole numbers -2,147,483,648 to 2,147,483,647 )
      //    var x = 8;
      //    float (decimals with up to 6-9 digits)
      //    float y = 4.5f;

      // double is 'd'
      // decimal is 'm'

      // NULL / UNDEFINED (there is no UNDEFINED)



      // Collection Types
      // Arrays (BOOOOO) fixed length, properties must be set by index
      //   string[] names = new string[] { "Mark", "Jonsey", "Mick", "Harrison" };
      //   names[0] = null;
      // List (YAY) works like a JS Array
      //   List<string> names = new List<string>() { "Mark", "Jonsey", "Mick", "Harrison" };
      // js equiv let names= ["Mark", "Jonsey", "Mick", "Harrison"]

      //   names.Insert(0, "Justin");
      //   names.AddRange(new string[] { "Jake", "Zach", "Brittany" });
      //   names.Remove("Jake");

      //   names.ForEach(n =>
      //   {
      //     Console.WriteLine(n);
      //   });

      //   foreach (string name in names)
      //   {
      //     Console.WriteLine(name);
      //   }



      // SECTION DICTIONARIES  (NO POCO Plain ol C# Objects)
      // takes in key type and value type
      //   Dictionary<string, string> staffRoles = new Dictionary<string, string>(){
      //       {"Mark", "Instructor"}
      //   };
      //   staffRoles.Add("Justin", "TA");
      //   staffRoles.Add("Jake", "CEO");


      //   if (staffRoles.ContainsKey("Jake"))
      //   {

      //     Console.WriteLine(staffRoles["Jake"]);
      //   }


      //   Dictionary<string, User> users = new Dictionary<string, User>();
      //   User mark = new User("Mark", 32);
      //   users.Add(mark.Name, mark);
      //   System.Console.WriteLine(mark.Age);
      //   mark.Birthday();
      //   System.Console.WriteLine(mark.Age);








      // SECTION FUNSTUFF with consoles
      // GET INPUT
      //       Console.Clear();
      //       Console.WriteLine("Hello What is your name?");
      //       string name = Console.ReadLine();
      //       System.Console.WriteLine(@"
      //               ███████  ███████
      //           ████▓▓▓▓▓▓████░░░░░██
      //         ██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██
      //       ██▓▓▓▓▓▓████████████░░░░██
      //     ██▓▓▓▓▓▓████████████████░██
      //     ██▓▓████░░░░░░░░░░░░██████
      //   ████████░░░░░░██░░██░░██▓▓▓▓██
      //   ██░░████░░░░░░██░░██░░██▓▓▓▓██
      // ██░░░░██████░░░░░░░░░░░░░░██▓▓██
      // ██░░░░░░██░░░░██░░░░░░░░░░██▓▓██
      //   ██░░░░░░░░░███████░░░░██████
      //     ████░░░░░░░███████████▓▓██
      //       ██████░░░░░░░░░░██▓▓▓▓██
      //     ██▓▓▓▓██████████████▓▓██
      //   ██▓▓▓▓▓▓▓▓████░░░░░░████
      // ████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
      // ████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
      // ██████▓▓▓▓▓▓▓▓██░░░░░░████████
      //   ██████▓▓▓▓▓▓████████████████
      //     ██████████████████████▓▓▓▓██
      //   ██▓▓▓▓████████████████▓▓▓▓▓▓██
      // ████▓▓██████████████████▓▓▓▓▓▓██
      // ██▓▓▓▓██████████████████▓▓▓▓▓▓██
      // ██▓▓▓▓██████████      ██▓▓▓▓████
      // ██▓▓▓▓████              ██████ 
      //   ████
      //              ");
      //       Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
      //       System.Console.WriteLine($"Hello {name}");





    }
  }
}
