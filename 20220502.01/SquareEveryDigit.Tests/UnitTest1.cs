using NUnit.Framework;

namespace SquareEveryDigit.Tests;

public class Tests
{
  [Test]
  public void SquareDigitsTest()
  {
    Assert.AreEqual(811181, Kata.SquareDigits(9119));
    Assert.AreEqual(0, Kata.SquareDigits(0));
  }
}