using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using QuartsParchmentShears.Models;

namespace QuartsParchmentShears.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      string choice = "QUARTZ";
      Game newGame = new Game(choice);
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_ReturnChoice_Game()
    {
      string choice = "QUARTZ";
      Game newGame = new Game(choice);
      string result = newGame.Choice;
      Assert.AreEqual(choice, result);
    }

    [TestMethod]
    public void GameConstructor_ChangeChoice_String()
    {
      string choice = "QUARTZ";
      Game newGame = new Game(choice);
      string updatedChoice = "PARCHMENT";
      newGame.Choice = updatedChoice;
      string result = newGame.Choice;
      Assert.AreEqual(updatedChoice, result);
    }

    [TestMethod]
    public void CheckWinner_ReturnWinnerPlayerOne_String()
    {
      string choiceOne = "PARCHMENT";
      string choiceTwo = "QUARTZ";
      Game userOneChoice = new Game(choiceOne);
      Game userTwoChoice = new Game(choiceTwo);
      Assert.AreEqual("Player One wins", Game.CheckWinner(userOneChoice.Choice, userTwoChoice.Choice));
    }

        [TestMethod]
    public void CheckWinner_ReturnWinnerPlayerTwo_String()
    {
      string choiceOne = "QUARTZ";
      string choiceTwo = "PARCHMENT";
      Game userOneChoice = new Game(choiceOne);
      Game userTwoChoice = new Game(choiceTwo);
      Assert.AreEqual("Player Two wins", Game.CheckWinner(userOneChoice.Choice, userTwoChoice.Choice));
    }
    public void CheckWinner_ReturnDraw_String()
    {
      string choiceOne = "QUARTZ";
      string choiceTwo = "QUARTZ";
      Game userOneChoice = new Game(choiceOne);
      Game userTwoChoice = new Game(choiceTwo);
      Assert.AreEqual("Draw", Game.CheckWinner(userOneChoice.Choice, userTwoChoice.Choice));
    }

  }
}