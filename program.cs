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
      Riddle secondRiddle = new Riddle("", "", "");
      Riddle thirdRiddle = new Riddle("", "", "");
      Riddle fourthRiddle = new Riddle("", "", "");

      Console.WriteLine("Riddle: What has to be broken before you can use it?");
      string userAnswer = Console.ReadLine();
      bool correct = userAnswer.Contains("egg");
      bool correct1 = userAnswer.Contains("Egg");
      if (correct || correct1)
      {
        Console.WriteLine("you are correct");
      }
      else
      {
        Console.Write("time for a snack!");
      }
    }
  }
}