using System;
using System.Collections.Generic;
using System.Linq;

namespace TokenizerLibrary
{
  public class Tokenizer
  {
    public static IEnumerable<string> Tokenize(string input)
    {
      int _upperCase = 0;
      List<string> _results = new List<string>();

      if (string.IsNullOrWhiteSpace(input)) return null;
      else if (!input.Any(char.IsUpper))
      {
        _results.Add(input);
        return _results;
      }
      else
      {
        for (int i = 1; i < input.Length; i++)
        {
          if (char.IsUpper(input[i]))
          {
            _results = AddSubString(i, input, _results, _upperCase);
            _upperCase = i;
          }
        }
      }

      _results = AddSubString(input.Length, input, _results, _upperCase);
      return _results;
    }

    private static List<string> AddSubString(int index, string input, List<string> results, int upperCase)
    {
      int stringLength = index - upperCase;
      string subS = input.Substring(upperCase, stringLength);
      results.Add(subS);
      return results;
    }
  }
}
