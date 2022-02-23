using System;
using System.Collections.Generic;

namespace QuartsParchmentShears.Models
{
  public class Program
  {
    public static void Main()
    {
      bool playAgain = true;
      while (playAgain)
      {
        System.Console.WriteLine("QUARTZ PARCHMENT or SHEARS/ or DONE");
        System.Console.WriteLine("Player one select: ");
        string userOneInput = System.Console.ReadLine().ToUpper();
        Game choiceOne = new Game(userOneInput);
        System.Console.WriteLine("Player two select: ");
        string userTwoInput = System.Console.ReadLine().ToUpper();
        Game choiceTwo = new Game(userTwoInput);
        System.Console.WriteLine(Game.CheckWinner(choiceOne.Choice, choiceTwo.Choice));
        if (choiceOne.Choice == "DONE" || choiceTwo.Choice == "DONE")
        {
          playAgain = false;
        }
      }
    }
  }
}