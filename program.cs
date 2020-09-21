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

      Console.WriteLine(firstRiddle.NewRiddle);
      string userAnswer = Console.ReadLine();
      if (firstRiddle.correct(userAnswer))
      {
        Console.WriteLine(secondRiddle.NewRiddle);
        string userAnswer2 = Console.ReadLine();
        if (secondRiddle.correct(userAnswer2))
        {
          Console.WriteLine(thirdRiddle.NewRiddle);
          string userAnswer3 = Console.ReadLine();
          if (thirdRiddle.correct(userAnswer3))
          {
            Console.WriteLine(fourthRiddle.NewRiddle);
            string userAnswer4 = Console.ReadLine();
            if (fourthRiddle.correct(userAnswer4))
            {
              Console.WriteLine("You beat me!");
            }
          }
        }
      }
      Console.Write("Time for a snack!");
    }
  }
}

