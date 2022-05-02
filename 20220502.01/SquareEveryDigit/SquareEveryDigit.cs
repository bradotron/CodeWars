namespace SquareEveryDigit;
public class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
    Console.WriteLine($"2 squared: {Kata.SquareDigits(2)}");
  }
}

public class Kata
{
  public static int SquareDigits(int n)
  {
    string sNumber = n.ToString();
    string sResult = "";
    foreach (char letter in sNumber)
    {
      int digit = Int32.Parse(letter.ToString());
      sResult += (digit * digit).ToString();
    }
    return Int32.Parse(sResult);
  }
}
