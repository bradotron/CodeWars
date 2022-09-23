public class Kata
{
  public static string Rot13(string message)
  {
    string cypher = String.Empty;

    string letters = "abcdefghijklmnopqrstuvwxyz";
    Dictionary<char, char> rot13 = new Dictionary<char, char>();
    for (int i = 0; i < letters.Length; i++)
    {
      rot13.Add(letters[i], letters[(i + 13) % letters.Length]);
      rot13.Add(Char.ToUpper(letters[i]), Char.ToUpper(letters[(i + 13) % letters.Length]));
    }

    foreach (char c in message)
    {
      if (rot13.ContainsKey(c))
      {
        cypher += rot13[c].ToString();
      }
      else
      {
        cypher += c.ToString();
      }
    }

    return cypher;
  }
}