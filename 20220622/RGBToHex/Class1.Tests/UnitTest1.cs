using NUnit.Framework;

namespace Class1.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      Assert.That(RGBToHex.IntToHex(0), Is.EqualTo("0"));
      Assert.That(RGBToHex.IntToHex(1), Is.EqualTo("1"));
      Assert.That(RGBToHex.IntToHex(11), Is.EqualTo("B"));
      Assert.That(RGBToHex.IntToHex(12), Is.EqualTo("C"));
      Assert.That(RGBToHex.IntToHex(255), Is.EqualTo("FF"));
      Assert.That(RGBToHex.IntToHex(148), Is.EqualTo("94"));
      Assert.That(RGBToHex.IntToHex(211), Is.EqualTo("D3"));
    }

    [Test]
    public void Test2()
    {
      Assert.That(RGBToHex.Rgb(0, 0, 0), Is.EqualTo("000000"));
      Assert.That(RGBToHex.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
      Assert.That(RGBToHex.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
      Assert.That(RGBToHex.Rgb(212, 53, 12), Is.EqualTo("D4350C"));
    }
}