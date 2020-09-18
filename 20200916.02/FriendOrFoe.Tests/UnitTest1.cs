using NUnit.Framework;
using FriendOrFoe;

namespace FriendOrFoe.Tests
{
  [TestFixture]
  public class Tests
  {
    private Kata _kata;

    [SetUp]
    public void Setup()
    {
      _kata = new Kata();
    }

    [Test]
    public void Test1()
    {
      string[] expected = { "Ryan", "Mark" };
      string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
      CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
    }
  }
}