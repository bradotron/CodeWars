using System;

namespace Kata
{
  public class Kata
  {
    public static string SpinWords(string sentence)
    {
      string result = "";
      string[] words = sentence.Split(' ');

      foreach (string word in words)
      {
        if (word.Length > 4)
        {
          char[] chars = word.ToCharArray();
          Array.Reverse(chars);
          result += new string(chars);
        }
        else
        {
          result += word;
        }
        result += " ";
      }

      return result.Trim();
    }
  }
}
