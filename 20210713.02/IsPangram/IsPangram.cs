using System;
using System.Linq;

namespace IsPangram
{
  public static class Kata
  {
    public static bool IsPangram(string str)
    {
      char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    
      char[] condensedInput = str.ToLower().Distinct().OrderBy(c => c).ToArray();

      return alphabet.All(letter => condensedInput.Contains(letter));
    }
  }
}
