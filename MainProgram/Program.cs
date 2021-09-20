using System;
using TokenizerLibrary;

namespace MainProgram
{
  class Program
  {
    public static void Main()
    {
      string input = "almaKörteBarack";

      foreach (var item in Tokenizer.Tokenize(input))
      {
        Console.WriteLine(item);
      }
    }
  }
}

