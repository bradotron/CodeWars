using System;
using System.Collections.Generic;

namespace Kata
{
  public class Balanced
  {
    public static List<string> BalancedParens(int n)
    {
      List<string> result = new List<string>();

      // result will always have n^2 strings
      // all the strings will be 2 * n length
      // at each open paren, recursively go down the path of potential solutions (every spot can either be open or closed paren)

      GetValidParensString(n, n, "", result);

      return result;
    }

    private static void GetValidParensString(int OpenParens, int CloseParens, string input, List<string> results)
    {
      if (OpenParens == 0 && CloseParens == 0)
      {
        results.Add(input);
      }

      if (OpenParens > CloseParens)
      {
        return;
      }

      if (OpenParens > 0)
      {
        GetValidParensString(OpenParens - 1, CloseParens, input + "(", results);
      }

      if (CloseParens > 0)
      {
        GetValidParensString(OpenParens, CloseParens - 1, input + ")", results);
      }
    }
  }
}
