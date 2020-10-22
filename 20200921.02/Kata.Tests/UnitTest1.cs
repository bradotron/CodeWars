using NUnit.Framework;
using Kata;

namespace Kata.Tests
{
  [TestFixture]
  public class Tests
  {

    [Test]
    public void Test1()
    {
      Assert.AreEqual(1, DigPow.digPow(89, 1));
    }
    [Test]
    public void Test2()
    {
      Assert.AreEqual(-1, DigPow.digPow(92, 1));
    }
    [Test]
    public void Test3()
    {
      Assert.AreEqual(51, DigPow.digPow(46288, 3));
    }
    [Test]
    public void Test4()
    {
      Assert.AreEqual(-1, DigPow.digPow(3456789, 1));
    }
    [Test]
    public void Test5()
    {
      Assert.AreEqual(-1, DigPow.digPow(46288, 5));
    }
  }
}