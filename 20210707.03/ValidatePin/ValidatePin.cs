using System;
using System.Text.RegularExpressions;

namespace ValidatePin
{
  public class Kata
  {
    public static bool ValidatePin(string pin)
    {
      Regex onlyNumbers = new Regex(@"^[0-9]*$");

      if (pin.Contains("\n"))
      {
        return false;
      }

      if ((pin.Length == 4 || pin.Length == 6) && onlyNumbers.IsMatch(pin))
      {
        return true;
      }

      return false;
    }
  }
}
