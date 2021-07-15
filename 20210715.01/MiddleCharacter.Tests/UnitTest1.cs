using NUnit.Framework;

namespace MiddleCharacter.Tests
{
  public class Tests
  {
    [Test]
    public void GenericTests()
    {
      Assert.AreEqual("es", Kata.GetMiddle("test"));
      Assert.AreEqual("t", Kata.GetMiddle("testing"));
      Assert.AreEqual("dd", Kata.GetMiddle("middle"));
      Assert.AreEqual("A", Kata.GetMiddle("A"));
    }
  }
}