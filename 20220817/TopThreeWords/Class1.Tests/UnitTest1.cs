using NUnit.Framework;
using System.Collections.Generic;

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
    Assert.AreEqual(new List<string> { "e", "d", "a" }, TopWords.Top3("a a a  b  c c  d d d d  e e e e e"));
  }

  [Test]
  public void Test2()
  {
    Assert.AreEqual(new List<string> { "won't", "wont" }, TopWords.Top3("  //wont won't won't "));
  }

  [Test]
  public void Test3()
  {
    Assert.AreEqual(new List<string> { "e", "ddd", "aa" }, TopWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
  }

  [Test]
  public void Test4()
  {
    Assert.AreEqual(new List<string> { "e" }, TopWords.Top3("  , e   .. "));
  }

  [Test]
  public void Test5()
  {
    Assert.AreEqual(new List<string> { }, TopWords.Top3("  '  "));
    Assert.AreEqual(new List<string> { }, TopWords.Top3("  '''  "));
  }
}