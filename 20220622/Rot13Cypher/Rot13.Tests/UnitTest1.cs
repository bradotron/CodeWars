using NUnit.Framework;

namespace Rot13.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      Assert.That(Rot13.Kata.Rot13("test"), Is.EqualTo("grfg"));
    }
}