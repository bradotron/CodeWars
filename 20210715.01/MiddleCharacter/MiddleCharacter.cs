using System;

namespace MiddleCharacter
{
  public class Kata
  {
    public static string GetMiddle(string s)
    {
      int middle = s.Length % 2 == 0 ? (s.Length / 2) - 1 : s.Length / 2;

      return s.Substring(middle, s.Length % 2 == 0 ? 2 : 1);
    }
  }
}
