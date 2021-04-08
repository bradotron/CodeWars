using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
  public class Kata
  {
    public static long ListPosition(string value)
    {
      if (value.Length > 25)
      {
        throw new Exception("Input is longer than 25 letters.");
      }
      // the index of any permutation is the sum of the number of anagrams that occur for any prefix that precedes it alphabetically
      // so I need to find all prefixes that precede this

      long position = 1;
      string RemainingValue = value;

      Console.WriteLine("{0} | {1}", int.MaxValue, long.MaxValue);

      while (RemainingValue.Length > 0)
      {
        string CurrentLetter = RemainingValue.Substring(0, 1);
        List<string> SortedLetters = RemainingValue.Select(letter => letter.ToString()).OrderBy(letter => letter).ToList();
        List<string> SortedDistinctLetters = SortedLetters.Distinct().ToList();
        int SortedDistinctIndex = SortedDistinctLetters.IndexOf(CurrentLetter);

        Console.WriteLine("Sorted: {0} | Letter: {1} | Index: {2} | Word: {3}",
          String.Join(string.Empty, SortedDistinctLetters),
          CurrentLetter,
          SortedDistinctIndex,
          RemainingValue);

        for (int i = 0; i < SortedDistinctIndex; i++)
        {
          List<string> TempSortedLetters = SortedLetters.Select(letter => letter).ToList();
          Console.WriteLine("SortedLetters: {0} | SortedDistinctLetters: {1} | Letter: {2}", String.Join(string.Empty, TempSortedLetters),String.Join(string.Empty, SortedDistinctLetters), SortedDistinctLetters[i]);
          TempSortedLetters.Remove(SortedDistinctLetters[i]);
          Console.WriteLine("SortedLetters: {0}", String.Join(string.Empty, TempSortedLetters));
          position += CountOfPermutations(String.Join(string.Empty, TempSortedLetters));
          Console.WriteLine();
        }

        RemainingValue = RemainingValue.Substring(1);
      }

      return position;
    }


    public static long CountOfPermutations(string value)
    {
      Dictionary<string, int> LetterToFrequency = new Dictionary<string, int>();
      for (int i = 0; i < value.Length; i++)
      {
        string CurrentLetter = value.Substring(i, 1);
        if (LetterToFrequency.ContainsKey(CurrentLetter))
        {
          LetterToFrequency[CurrentLetter]++;
        }
        else
        {
          LetterToFrequency.Add(CurrentLetter, 1);
        }
      }

      long numerator = Factorial(value.Length);
      long denomonator = 1;
      foreach (KeyValuePair<string, int> pair in LetterToFrequency)
      {
        if (pair.Value > 1)
        {
          denomonator = denomonator * Factorial(pair.Value);
        }
      }

      return numerator / denomonator;
    }

    public static long Factorial(int value)
    {
      long cumulator = 1;
      for (int i = 2; i <= value; i++)
      {
        cumulator = cumulator * i;
      }
      return cumulator;
    }
  }
}
