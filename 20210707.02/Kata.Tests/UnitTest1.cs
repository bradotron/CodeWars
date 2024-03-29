using NUnit.Framework;

namespace DuplicateEncode.Tests
{
  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
      Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
      Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
      Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
    }
  }
}
