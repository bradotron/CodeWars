using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    string result = "";

    foreach (string subString in phrase.Split(' '))
    {
      result += char.ToUpper(subString[0]) + subString.Substring(1);
    }

    return result.Trim();
  }
}