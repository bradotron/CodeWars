using System;

namespace Kata
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      Random random = new Random();
      for (int i = 0; i < 10; i++)
      {
        int rand1 = random.Next(10, 14);
        int rand2 = random.Next(2, 8);
        PerfectPower.IsPerfectPower((int)Math.Pow(rand1, rand2));
      }
    }
  }
  public class PerfectPower
  {
    public static (int, int)? IsPerfectPower(int n)
    {
      if (n <= 3)
      {
        return null;
      }
      else
      {
        int mMax = (int)Math.Sqrt(n);
        for (int m = mMax; m >= 2; m--)
        {
          bool done = false;
          int k = 2;

          while (!done)
          {
            int power = (int)Math.Pow(m, k);

            if (power == n)
            {
              return (m, k);
            }
            else if (power > n || power < 0) // when the int value overflows it defaults to -2,147,483,648
            {
              done = true;
            }
            else
            {
              k++;
            }
          }
        }

        return null;
      }
    }
  }
}
