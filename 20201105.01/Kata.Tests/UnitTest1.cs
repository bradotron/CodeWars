using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void Test1()
    {
      List<string> result = new List<string>() { "5", "7", "8", "9", "0" };
      CollectionAssert.AreEquivalent(result, Kata.GetPINs("8"));
    }

    [Test]
    public void Test2()
    {
      List<string> result = new List<string>() { "11", "22", "44", "12", "21", "14", "41", "24", "42" };
      CollectionAssert.AreEquivalent(result, Kata.GetPINs("11"));
    }

    [Test]
    public void Test3()
    {
      List<string> result = new List<string>() { "339", "366", "399", "658", "636", "258", "268", "669", "668", "266", "369", "398", "256", "296", "259", "368", "638", "396", "238", "356", "659", "639", "666", "359", "336", "299", "338", "696", "269", "358", "656", "698", "699", "298", "236", "239" };
      CollectionAssert.AreEquivalent(result, Kata.GetPINs("369"));
    }
  }
}