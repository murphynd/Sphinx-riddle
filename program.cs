using System;
using System.Collections.Generic;
using Sphinx.Backend;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle firstRiddle = new Riddle("What has to be broken before you can use it?", "egg", "Egg");
      Riddle secondRiddle = new Riddle("I shave every day, but my beard stays the same. What am I?", "barber", "Barber");
      Riddle thirdRiddle = new Riddle("The more of this there is, the less you see. What is it?", "darkness", "Darkness");
      Riddle fourthRiddle = new Riddle("What has many keys but can't open a single lock?", "piano", "Piano");
      List<Riddle> RiddleList = new List<Riddle>() { firstRiddle, secondRiddle, thirdRiddle, fourthRiddle };

      bool temp = true;
      int asdf = RiddleList.Count;
      for (int i = 0; i < asdf; i++)
      {
        Random rnd = new Random();
        int index = rnd.Next(RiddleList.Count - 1);
        Console.WriteLine(RiddleList[index].NewRiddle);
        string userAnswer = Console.ReadLine();
        if (!RiddleList[index].Correct(userAnswer))
        {
          Console.WriteLine("Time for a snack!");
          temp = false;
          break;
        }
        RiddleList.Remove(RiddleList[index]);
      }
      if (temp)
      {
        Console.WriteLine("You beat me!");
      }
    }
  }
}

