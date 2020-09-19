using System;

namespace IsSquare
{
  public class Kata
  {
    public static bool IsSquare(int n)
    {
        //return Math.Sqrt(n) % 1 == 0;
      if (n < 0)
      {
        return false;
      }
      else
      {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
      }
    }
  }
}
