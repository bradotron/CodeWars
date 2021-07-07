using NUnit.Framework;

namespace Kata.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void World()
    {
      Assert.AreEqual("dlrow", Kata.Solution("world"));
    }
  }
}
