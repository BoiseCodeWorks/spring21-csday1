using System;

// REVIEW
namespace csday1.Models
{
  public class Game
  {

    private int Number { get; set; }
    public int Guesses { get; private set; }
    // stretch Goal history of guesses in a list

    public bool Guess(int num)
    {
      Guesses++;
      string guessTimes = Guesses < 2 ? "try" : "tries ";
      if (num == Number)
      {
        System.Console.WriteLine($"You got it, it took {Guesses} {guessTimes}");
        return true;
      }
      else if (num > Number)
      {
        Console.WriteLine($"Your guess is too high, you have been wrong {Guesses} {guessTimes}");
      }
      else
      {
        Console.WriteLine($"Your guess is too low, you have been wrong {Guesses} {guessTimes}");
      }
      return false;
    }

    public Game()
    {
      Random rnd = new Random();
      Number = rnd.Next(1, 101);
      Guesses = 0;
    }

  }
}