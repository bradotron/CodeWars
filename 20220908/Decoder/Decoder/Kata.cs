// https://www.codewars.com/kata/55983863da40caa2c900004e/train/csharp

using System.Text;

public class Kata
{
  public static long NextBiggerNumber(long n)
  {
    long nextBiggest = -1;

    Console.WriteLine("Input: " + n.ToString());
    string front = String.Empty;
    string back = String.Empty;

    // convert to string
    string s = n.ToString();

    // iterate until next digit is greater than previous
    for (int i = 1; i < s.Length; i++)
    {
      int previousDigit = int.Parse(s.Substring(i - 1, 1));
      int nextDigit = int.Parse(s.Substring(i, 1));
      if (nextDigit > previousDigit)
      {
        Console.WriteLine("found the split at: " + previousDigit + " and " + nextDigit);
        front = s.Substring(0, i);
        back = s.Substring(i);
        Console.WriteLine(front + " " + back);
        int lowestLargerNumber = nextDigit;
        int swapIndexBack = 0;

        for (int j = 1; j < back.Length; j++)
        {
          if (int.Parse(back.Substring(j, 1)) > lowestLargerNumber)
          {
            lowestLargerNumber = int.Parse(back.Substring(j, 1));
            swapIndexBack = j;
          }
        }

        // swap digits
        StringBuilder sb = new StringBuilder(front);
        sb.Append(back.Substring(swapIndexBack, 1));
        back = back.Remove(swapIndexBack, 1);

        // sort the remaining digits in the second sequence into increasing order
        sb.Append(String.Join("", back.ToArray().OrderBy(c => c)));

        // combine and convert back to long
        nextBiggest = int.Parse(sb.ToString());

        break;
      }
    }

    return nextBiggest;
  }
}