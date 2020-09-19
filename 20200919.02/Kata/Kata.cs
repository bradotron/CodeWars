using System;

namespace Kata
{
  public class Kata
  {
    public static String Accum(string s)
    {
      char[] chars = s.ToLower().ToCharArray();
      string result = "";
      for (int i = 0; i < chars.Length; i++)
      {
        result += chars[i].ToString().ToUpper();

        int j = 0;
        while (j < i)
        {
          result += chars[i].ToString();
          j++;
        }

        result += "-";
      }
      return result.Trim('-');
    }
  }
}
