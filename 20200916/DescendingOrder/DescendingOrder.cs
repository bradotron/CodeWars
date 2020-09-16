using System;
using System.Collections.Generic;

namespace DescendingOrder
{
  public class DescendingOrder
  {
    public static int PutIntoDescendingOrder(int num)
    {
      string result = "";
      string numberString = num.ToString();
      List<int> digits = new List<int>();
      foreach(char c in numberString) {
          digits.Add((int)Char.GetNumericValue(c));
      }
      digits.Sort(delegate (int x, int y)
      {
        return y > x ? 1 : -1;
      });
      foreach (int digit in digits)
      {
        result += digit;
      }
      return int.Parse(result);
    }
  }
}
