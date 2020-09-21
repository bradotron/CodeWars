using System;

namespace Kata
{
  public class BouncingBall
  {
    public static int bouncingBall(double h, double bounce, double window)
    {
      if (h > 0 && bounce > 0 && bounce < 1 && window < h)
      {
        int count = 0;
        while (h > window)
        {
          count++;
          h = h * bounce;
          if (h > window)
          {
            count++;
          }
        }
        return count;
      }
      else
      {
        return -1;
      }
    }
  }
}
