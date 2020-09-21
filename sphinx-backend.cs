using System;
using System.Collections.Generic;

namespace Sphinx.Backend
{
  public class Riddle
  {
    public string NewRiddle;
    public string AnswerLowerCase;
    public string AnswerUpperCase;

    public Riddle(string newRiddle, string answerLowerCase, string answerUpperCase)
    {
      NewRiddle = newRiddle;
      answerLowerCase = AnswerLowerCase;
      answerUpperCase = AnswerUpperCase;
    }
    public bool correct(string UserAnswer)
    {
      return (UserAnswer == AnswerLowerCase || AnswerUpperCase)
    }
  }

  public RiddleGenerator()
  {
    Console.WriteLine("Riddle: What has to be broken before you can use it?");
    string userAnswer = Console.ReadLine();
    bool lowercase = userAnswer.Contains("egg");
    bool uppercase = userAnswer.Contains("Egg");
    if (uppercase || lowercase)
    {
      Console.WriteLine("you are correct");
    }
    else
    {
      Console.Write("time for a snack!");
    }
  }
}