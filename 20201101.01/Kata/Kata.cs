using System;
using System.Collections.Generic;

namespace Kata
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");

      //Console.WriteLine("Answer = {0}", Fracts.lcm(new int[] { 1, 2, 3, 4, 5, 10, 20, 35 }));
      long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
      Console.WriteLine(String.Format("{0} => {1}", Fracts.Print2DArray(lst), Fracts.convertFrac(lst)));

      lst = new long[,] { { 69, 130 }, { 87, 1310 }, { 3, 4 } };
      Console.WriteLine(String.Format("{0} => {1}", Fracts.Print2DArray(lst), Fracts.convertFrac(lst)));
    }
  }

  public class Fracts
  {
    public static string convertFrac(long[,] lst)
    {
      if (lst.GetLength(0) <= 0)
      {
        return string.Empty;
      }

      long[] denominators = new long[lst.GetLength(0)];
      for (int i = 0; i < denominators.Length; i++)
      {
        denominators[i] = lst[i, 1];
      }

      long lcm = Fracts.lcm(denominators);

      long[,] answer = new long[lst.GetLength(0), 2];
      for (int i = 0; i < lst.GetLength(0); i++)
      {
        long multiplier = lcm / lst[i, 1];
        answer[i, 0] = lst[i, 0] * multiplier;
        answer[i, 1] = lst[i, 1] * multiplier;
      }

      return Fracts.Print2DArray(answer);
    }

    public static long lcm(long[] input)
    {
      // copy numbers to new []
      long[] numbers = new long[input.Length];
      for (int i = 0; i < input.Length; i++)
      {
        numbers[i] = input[i];
      }

      // find the max
      long max = numbers[0];
      for (int i = 0; i < numbers.Length; i++)
      {
        max = numbers[i] > max ? numbers[i] : max;
      }

      // initialize the result
      long result = 1;

      // find all factors present in two or more elements
      long x = 2; // current factor
      while (x <= max)
      {
        List<int> indexes = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
          if (numbers[i] % x == 0)
          {
            indexes.Add(i);
          }
        }

        if (indexes.Count >= 2)
        {
          foreach (int index in indexes)
          {
            numbers[index] = numbers[index] / x;
          }

          result = result * x;
        }
        else
        {
          x++;
        }
      }

      // multiply all reduced array elements to get LCM
      for (int i = 0; i < numbers.Length; i++)
      {
        result = result * numbers[i];
      }
      return result;
    }

    public static string Print1DArray(int[] array)
    {
      string output = "{ ";
      for (int i = 0; i < array.Length; i++)
      {
        output += String.Format("{0},", array[i]);
      }
      output = output.Trim(',');
      output = output + " }";
      return output;
    }

    public static string Print1DArray(long[] array)
    {
      string output = "{ ";
      for (int i = 0; i < array.Length; i++)
      {
        output += String.Format("{0},", array[i]);
      }
      output = output.Trim(',');
      output = output + " }";
      return output;
    }

    public static string Print2DArray(long[,] array)
    {
      string output = "";
      for (int i = 0; i < array.GetLength(0); i++)
      {
        output += String.Format("({0},{1})", array[i, 0], array[i, 1]);
      }
      return output;
    }
  }
}
