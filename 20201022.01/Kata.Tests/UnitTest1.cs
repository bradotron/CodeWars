using NUnit.Framework;

namespace Kata.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void IntToHexTests()
    {
      Assert.AreEqual("468", Kata.IntToHex(1128));
      Assert.AreEqual("BC", Kata.IntToHex(188));
      Assert.AreEqual("100", Kata.IntToHex(256));
      Assert.AreEqual("399", Kata.IntToHex(921));
      Assert.AreEqual("24E", Kata.IntToHex(590));
    }

    [Test]
    public void FixedTests()
    {
      Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
      Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
      Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
      Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
      Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
      Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
      Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
    }
  }
}