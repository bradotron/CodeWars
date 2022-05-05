using NUnit.Framework;

namespace Tests;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Test()
  {
    Assert.AreEqual(23, Class1.Solution(10));
  }
}