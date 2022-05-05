namespace Class1;
public class Kata
{
  public static int Find(int[] integers)
  {
    if (integers.Length < 3)
    {
      return -1;
    }

    int evenCount = 0;
    int oddCount = 0;

    for (int i = 0; i < 3; i++)
    {
      if (integers[i] % 2 == 0)
      {
        evenCount++;
      }
      else
      {
        oddCount++;
      }
    }

    bool outlierIsEven = true;

    if (evenCount > oddCount)
    {
      outlierIsEven = false;
    }

    for (int i = 0; i < integers.Length; i++)
    {
      if (outlierIsEven)
      {
        if (integers[i] % 2 == 0)
        {
          return integers[i];
        }
      }
      else
      {
        if (integers[i] % 2 != 0)
        {
          return integers[i];
        }
      }
    }

    return -1;
  }

  public static bool IsEven(int i)
  {
    return i % 2 == 0;
  }
}
