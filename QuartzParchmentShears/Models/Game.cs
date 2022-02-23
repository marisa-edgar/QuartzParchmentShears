using System.Collections.Generic;

namespace QuartsParchmentShears.Models
{
  public class Game
  {
    public string Choice { get; set; }

    public Game(string choice)
    {
      Choice = choice;
    }

    public static string CheckWinner(string userOne, string userTwo)
    {
      if ((userOne == "QUARTZ" && userTwo == "SHEARS") || (userOne == "PARCHMENT" && userTwo == "QUARTZ") || (userOne == "SHEARS" && userTwo == "PARCHMENT"))
      {
        return "Player One wins";
      }
      else if ((userTwo == "QUARTZ" && userOne == "SHEARS") || (userTwo == "PARCHMENT" && userOne == "QUARTZ") || (userTwo == "SHEARS" && userOne == "PARCHMENT"))
      {
        return "Player Two wins";
      }
      else if(userOne == "DONE" || userTwo == "DONE")
      {
        return "GAMEOVER";
      }
      else
      {
        return "Draw";
      }
    }
  }
}