using System;
using System.Collections.Generic;
using System.Linq;

namespace TokenizerLibrary
{
  public class Tokenizer
  {
    // almaKorteSzilva
    int upperCase = 0;
    string _input;
    List<string> results = new List<string>();

    public Tokenizer(string input)
    {
      _input = input;
    }

    public IEnumerable<string> Tokenize()
    {
      if (!_input.Any(char.IsUpper))
      {
        results.Add(_input);
        return results;
      }
      else
      {
        for (int i = 0; i < _input.Length; i++)
        {
          if (char.IsUpper(_input[i]) && i != 0)
          {
            AddSubString(i);
            upperCase = i;
          }
        }
      }

      AddSubString(_input.Length);

      return results;
    }

    private void AddSubString(int index)
    {
      int stringLength = index - upperCase;
      string subS = _input.Substring(upperCase, stringLength);
      results.Add(subS);
    }
  }
}
