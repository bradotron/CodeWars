using System;
using System.Collections.Generic;
using System.Linq;

namespace Class1;
public class TopWords
{
	public static List<string> Top3(string s)
	{
		Console.WriteLine(s);

		Dictionary<string, int> wordCounts = new Dictionary<string, int>();
		string tempWord = String.Empty;

		for (int i = 0; i < s.Length; i++)
		{
			if (Char.IsLetter(s[i]) || s[i] == '\'')
			{
				tempWord += s[i].ToString();
			}
			else
			{
				if (tempWord != string.Empty && tempWord.Any(c => Char.IsLetter(c)))
				{
					tempWord = tempWord.ToLower();

					if (wordCounts.ContainsKey(tempWord))
					{
						wordCounts[tempWord]++;
					}
					else
					{
						wordCounts.Add(tempWord, 1);
					}
				}
				tempWord = string.Empty;
			}
		}

		// don't forget the last word
		if (tempWord != string.Empty)
		{
			if (wordCounts.ContainsKey(tempWord))
			{
				wordCounts[tempWord]++;
			}
			else
			{
				wordCounts.Add(tempWord, 1);
			}
		}

		List<WordCount> lWordCounts = wordCounts.Select(kvp => new WordCount() { Word = kvp.Key, Count = kvp.Value }).ToList();
		lWordCounts.Sort((wc1, wc2) => -wc1.Count.CompareTo(wc2.Count));

		List<string> result = new List<string>();

		for (int i = 0; i < 3; i++)
		{
			if (i > lWordCounts.Count - 1) { break; }
			result.Add(lWordCounts[i].Word);
		}

		return result;
	}

	public class WordCount
	{
		public int Count { get; set; }
		public string Word { get; set; }
	}
}