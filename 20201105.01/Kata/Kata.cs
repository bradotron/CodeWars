using System;
using System.Collections.Generic;

namespace Kata
{
  public class Kata
  {
    private static Dictionary<char, List<string>> DigitToOptions = new Dictionary<char, List<string>>()
    {
     { '0', new List<string>() { "8" , "0" } },
     { '1', new List<string>() { "1", "2", "4"} },
     { '2', new List<string>() { "1", "2", "3", "5"} },
     { '3', new List<string>() { "2", "3", "6"} },
     { '4', new List<string>() { "1", "4", "5", "7"} },
     { '5', new List<string>() { "2", "4", "5", "6", "8"} },
     { '6', new List<string>() { "3", "5", "6", "9"} },
     { '7', new List<string>() { "4", "7", "8"} },
     { '8', new List<string>() { "5", "7", "8", "9", "0"} },
     { '9', new List<string>() { "6", "8", "9" } }
    };

    public static List<string> GetPINs(string observed)
    {
      Console.WriteLine("Generating PINs for: " + observed);

      List<List<string>> DigitOptions = new List<List<string>>();

      foreach (char c in observed)
      {
        if (!DigitToOptions.ContainsKey(c))
        {
          return new List<string>();
        }

        DigitOptions.Add(DigitToOptions[c]);
      }

      List<string> Options = new List<string>();

      AddVariationsToList("", Options, DigitOptions);

      return Options;
    }

    private static void AddVariationsToList(string prefix, List<string> output, List<List<string>> Options)
    {
      if (Options.Count > 1)
      {
        List<string> current = Options[0];
        foreach (string option in current)
        {
          List<List<string>> newOptions = new List<List<string>>();
          for (int i = 1; i < Options.Count; i++)
          {
            newOptions.Add(Options[i]);
          }
          AddVariationsToList(prefix + option, output, newOptions);
        }
      }
      else
      {
        foreach (string option in Options[0])
        {
          output.Add(prefix + option);
        }
      }
    }
  }
}
