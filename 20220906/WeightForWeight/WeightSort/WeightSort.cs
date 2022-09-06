using System;

public class WeightSort
{
  public static string orderWeight(string strng)
  {
    string[] strings = strng.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    List<Weight> weights = new List<Weight>();

    foreach (string s in strings)
    {
      weights.Add(new Weight(s));
    }

    weights.Sort((a, b) =>
    {
      if (a.weight - b.weight == 0)
      {
        return a.value.CompareTo(b.value);
      }

      return a.weight - b.weight;
    });

    return String.Join(' ', weights);
  }
}

public class Weight
{
  public string value { get; private set; }
  public int weight { get; private set; }

  public Weight(string value)
  {
    this.value = value;
    this.weight = CalculateWeight(value);
  }

  public static int CalculateWeight(string s)
  {
    int weight = 0;
    foreach (char c in s)
    {
      weight += Int32.Parse(c.ToString());
    }
    return weight;
  }

  public override string ToString()
  {
    return value.ToString();
  }
}