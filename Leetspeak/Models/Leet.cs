using System;
using System.Collections.Generic;

namespace Leetspeakname
{
  public class Leet
  {
    public string PlayGame(string index)
    {
      var arr = index.ToCharArray();
      List<char> result = new List<char>();
      int current = 0;
      for(var i = 0; i < arr.Length; ++i)
      {
        char c = arr[i];
        result.Add(PlayGame(c, current));
        if (c == ' ') {
          current = 0;;
        }
        else {
          current++;
        }
      }
      return string.Join("", result);
    }
    public char PlayGame(char letter, int index)
    {

      if (letter == 'e')
      {
        return '3';
      }
      else if (letter == 'o')
      {
        return '0';
      }
      else if (letter == 'I')
      {
        return '1';
      }
      else if (letter == 't')
      {
        return '7';
      }
      else if ( letter == 's' && index != 0)
      {
        return 'z';
      }
      else
      {
        return letter;
      }
    }
  }
}
