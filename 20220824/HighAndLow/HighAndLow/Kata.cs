namespace HighAndLow
{
  public class Kata
  {
    public static string HighAndLow(string numbers)
    {
      int low = Int32.MaxValue;
      int high = Int32.MinValue;

      foreach (string s in numbers.Split(' '))
      {
        int n = Int32.Parse(s);
        if (n < low) { low = n; }
        if (n > high) { high = n; }
      }

      return $"{high} {low}";
    }
  }
}