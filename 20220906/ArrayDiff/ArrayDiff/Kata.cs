using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    Console.WriteLine(ArrayToString(a) + " - " + ArrayToString(b));
    HashSet<int> hashB = new HashSet<int>(b);
    List<int> diff = new List<int>();

    foreach (int i in a)
    {
      if (!hashB.Contains(i))
      {
        diff.Add(i);
      }
    }
    Console.WriteLine(ArrayToString(diff.ToArray()));
    return diff.ToArray();
  }

  public static string ArrayToString(int[] array)
  {
    return "[ " + String.Join(", ", array) + " ]";
  }
}