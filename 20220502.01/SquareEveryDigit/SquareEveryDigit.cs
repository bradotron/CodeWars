namespace SquareEveryDigit;

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
