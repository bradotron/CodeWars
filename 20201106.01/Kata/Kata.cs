using System;
using System.Collections.Generic;

namespace Kata
{
  public class TopWords
  {
    public static List<string> Top3(string s)
    {
      Dictionary<string, int> WordToOcurrences = new Dictionary<string, int>();
      string[] words = s.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?', '_', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);

      foreach (string word in words)
      {
        string LowerCaseWord = word.Trim().ToLower();
        LowerCaseWord = RemovePunction(LowerCaseWord);
        if (!(LowerCaseWord == string.Empty))
        {
          if (WordToOcurrences.ContainsKey(LowerCaseWord))
          {
            WordToOcurrences[LowerCaseWord]++;
          }
          else
          {
            WordToOcurrences.Add(LowerCaseWord, 1);
          }
        }
      };

      if (WordToOcurrences.Count > 0)
      {
        bool done = false;
        List<string> TopThree = new List<string>();
        while (!done)
        {
          int max = 0;
          string MaxWord = "";

          foreach (string word in WordToOcurrences.Keys)
          {
            if (WordToOcurrences[word] > max)
            {
              max = WordToOcurrences[word];
              MaxWord = word;
            }
          }

          WordToOcurrences.Remove(MaxWord);
          TopThree.Add(MaxWord);

          done = TopThree.Count == 3 || WordToOcurrences.Count <= 0;
        }

        return TopThree;
      }
      else
      {
        return new List<string>();
      }

    }

    private static string[] PunctionToRemove = new string[]
    {
      ",",
      ".",
      "?",
      "/",
      "\\",
      "!",
      ";",
      ":",
      "-",
      "_"
    };

    private static string RemovePunction(string input)
    {
      string output = input;
      foreach (string character in PunctionToRemove)
      {
        output = output.Replace(character, string.Empty);
      }

      bool OnlyApostraphes = true;
      foreach (char c in output)
      {
        if (c != '\'')
        {
          OnlyApostraphes = false;
        }
      }

      return OnlyApostraphes ? string.Empty : output;
    }
  }
}
