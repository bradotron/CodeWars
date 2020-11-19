using System;
using System.Collections.Generic;

namespace Kata
{
  public class PyramidSlideDown
  {
    public static int LongestSlideDown(int[][] pyramid)
    {
      if (pyramid.Length < 1)
      {
        return 0;
      }
      else
      {
        for (int i = pyramid.Length - 2; i >= 0; i--)
        {
          for (int j = 0; j < pyramid[i].Length; j++)
          {
            int left = pyramid[i + 1][j];
            int right = pyramid[i + 1][j + 1];
            pyramid[i][j] += Math.Max(left, right);
          }
        }

        return pyramid[0][0];
      }
    }

    // this recursion method works...but is exponentially complex
    // public static int FindMaxPath(int i, int j, int[][] tree)
    // {
    //   if (i == tree.Length - 1)
    //   {
    //     return tree[i][j];
    //   }
    //   else
    //   {
    //     int left = FindMaxPath(i + 1, j, tree);
    //     int right = FindMaxPath(i + 1, j + 1, tree);

    //     return (left > right ? left : right) + tree[i][j];
    //   }
    // }
  }
}
