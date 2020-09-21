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
      AnswerLowerCase = answerLowerCase;
      AnswerUpperCase = answerUpperCase;
    }
    public bool correct(string UserAnswer)
    {
      return (UserAnswer.Contains(AnswerLowerCase) || UserAnswer.Contains(AnswerUpperCase));
    }
  }
}
