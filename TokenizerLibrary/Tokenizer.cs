using System;
using System.Collections.Generic;
using System.Linq;

namespace TokenizerLibrary
{
  public class Tokenizer
  {
    public static IEnumerable<string> Tokenize(string input)
    {
      if (string.IsNullOrWhiteSpace(input)) yield break;
      if(input.Length == 1)
      {
        yield return input;
        yield break;
      }
      var start = 0;
      var end = input.Length;
      var position = 1;
      while(position <= end)
      {
        if(position == end || char.IsUpper(input[position]))
        {
          yield return input.Substring(start, position - start);
          start = position;
        }

        position++;
      }
    }
  }
}
