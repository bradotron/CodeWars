using System;
using System.Text;

namespace Kata
{
  public class StripCommentsSolution
  {
    public static string StripComments(string text, string[] commentSymbols)
    {
      string[] lines = text.Split('\n');
      string output = "";

      Console.WriteLine(lines.Length);
      for (int i = 0; i < lines.Length; i++)
      {
        string line = lines[i];

        int commentIndex = line.Length;
        foreach (string symbol in commentSymbols)
        {
          int foundIndex = line.IndexOf(symbol);
          if (foundIndex >= 0)
          {
            commentIndex = foundIndex < commentIndex ? foundIndex : commentIndex;
          }
        }

        if (commentIndex < line.Length)
        {
          output += line.Remove(commentIndex).TrimEnd();
        }
        else
        {
          output += line.TrimEnd();
        }

        if (i < lines.Length - 1)
        {
          output += "\n";
        }
      }

      return output;
    }
  }
}
