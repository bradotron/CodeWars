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
    int[] exampleTest1 = { 2, 6, 8, -10, 3 };
    Assert.AreEqual(3, Kata.Find(exampleTest1));
  }
}