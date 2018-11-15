using System;
using System.Collections.Generic;

namespace Leetspeakname
{

  public class LeetProgram
  {
      static void Main()
      {

        Console.WriteLine("Please enter a word.");

        string input = Console.ReadLine();
        var charArray = input.ToCharArray();

        Leet inputWord = new Leet();
        string returnedString = inputWord.PlayGame(charArray);
        Console.WriteLine(returnedString);
      }

  }
}
