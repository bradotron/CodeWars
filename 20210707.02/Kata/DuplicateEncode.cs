using System;
using System.Linq;

namespace DuplicateEncode
{
  public class Kata
  {
    public static string DuplicateEncode(string word)
    {
      word = word.ToLower();

      string result = string.Empty;

      for (int i = 0; i < word.Length; i++)
      {
        result += word.Count(c => c == word[i]) > 1 ? ")" : "(";
      }

      return result;
    }

  }
}
