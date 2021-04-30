using System;

namespace Kata
{
  public class ProperFractionsSolution
  {
    public static long ProperFractions(long n)
    {
      if (n <= 1)
      {
        return 0;
      }

      // Euler's Totient Function
      long counter = n;
      for (int i = 2; i <= Math.Sqrt(n); i++)
      {
        if ((double)n % (double)i == 0)
        {
          n = LowestDivisibleQuotient(n, i);

          counter = counter - (counter / i);
        }
      }

      if (n > 1)
      {
        counter = counter - (counter / n);
      }

      return counter;
    }

    public static long LowestDivisibleQuotient(long n, long d)
    {
      if ((double)n % (double)d == 0)
      {
        return LowestDivisibleQuotient(n / d, d);
      }
      return n;
    }

    public static long GCD(long n, long d)
    {
      if (d == 0)
      {
        return n;
      }
      else
      {
        return GCD(d, n % d);
      }
    }
  }
}
