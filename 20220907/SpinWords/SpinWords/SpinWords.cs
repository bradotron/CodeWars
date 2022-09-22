public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Length > 4)
      {
        char[] chars = words[i].ToCharArray();
        Array.Reverse(chars);
        words[i] = new string(chars);
      }
    }
    return String.Join(' ', words);
  }
}