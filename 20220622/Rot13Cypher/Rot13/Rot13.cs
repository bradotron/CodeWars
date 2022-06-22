namespace Rot13;
public static class Kata
{
  public static string Rot13(string message)
  {
    char[] letters = new char[] {
      'a',
      'b',
      'c',
      'd',
      'e',
      'f',
      'g',
      'h',
      'i',
      'j',
      'k',
      'l',
      'm',
      'n',
      'o',
      'p',
      'q',
      'r',
      's',
      't',
      'u',
      'v',
      'w',
      'x',
      'y',
      'z',
    };

    string output = "";

    foreach (char c in message)
    {
      if (Char.IsLetter(c))
      {
        bool isUpper = Char.IsUpper(c);
        int index = (Array.IndexOf(letters, Char.ToLower(c)) + 13) % letters.Length;
        output += isUpper ? Char.ToUpper(letters[index]).ToString() : letters[index].ToString();
      }
      else
      {
        output += c.ToString();
      }
    }

    return output;
  }
}
