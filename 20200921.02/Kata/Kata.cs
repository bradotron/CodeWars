using System;

namespace Kata
{
  public class DigPow
  {
    public static long digPow(int n, int p)
    {
      char[] chars = n.ToString().ToCharArray();
      double bigNum = 0;

      foreach (char c in chars)
      {
        double cParsed = double.Parse(c.ToString());
        bigNum += (int)Math.Pow(cParsed, p);
        p++;
      }
      
      double k = bigNum / (double)n;

      if (k < 1)
      {
        return -1;
      }
      else
      {
        return k % 1.0 == 0 ? (long)k : -1;
      }
    }
  }
}
