using NUnit.Framework;

namespace Kata.Tests
{
  public class Tests
  {
    [TestCase("A", 1)]
    [TestCase("AA", 1)]
    [TestCase("AB", 1)]
    [TestCase("ABAB", 2)]
    [TestCase("AAAB", 1)]
    [TestCase("BAAA", 4)]
    [TestCase("BABA", 5)]
    [TestCase("QUESTION", 24572)]
    [TestCase("BOOKKEEPER", 10743)]
    [TestCase("MUCHOCOMBINATIONS", 1938852339039)]
    [TestCase("ERDPNAXTRQZQMEN", 18075211137)]
    public void TestNumberToOrdinal(string value, long expected)
    {
      Assert.AreEqual(expected, Kata.ListPosition(value), string.Format("Input {0}", value));
    }


    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 24)]
    [TestCase(10, 3628800)]
    public void TestFactorial(int value, long expected)
    {
      Assert.AreEqual(expected, Kata.Factorial(value));
    }

    [TestCase("A", 1)]
    [TestCase("AA", 1)]
    [TestCase("AB", 2)]
    [TestCase("ABAB", 6)]
    [TestCase("AAAB", 4)]
    [TestCase("BAAA", 4)]
    [TestCase("QUESTION", 40320)]
    [TestCase("BOOKKEEPER", 151200)]
    public void TestCountPermutations(string value, long expected)
    {
      Assert.AreEqual(expected, Kata.CountOfPermutations(value), string.Format("Input {0}", value));
    }
  }
}