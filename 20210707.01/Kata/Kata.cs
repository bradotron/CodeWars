using System;

namespace Kata
{
  public static class Kata
  {
    public static string Solution(string str)
    {
      string result = string.Empty;

      for (int i = str.Length - 1; i >= 0; i--)
      {
        result += str[i];
      }

      return result;
    }
  }
}
