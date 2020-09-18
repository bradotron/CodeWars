using System;
using System.Collections.Generic;

namespace Kata
{
  public class Kata
  {
    public static int[] ArrayDiff(int[] a, int[] b)
    {
      List<int> result = new List<int>();

      foreach (int i in a)
      {
        if (!b.Contains(i))
        {
          result.Add(i);
        }
      }

      return result.ToArray();
    }
  }
}
