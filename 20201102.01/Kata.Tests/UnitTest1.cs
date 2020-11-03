using NUnit.Framework;
using System;
using Kata;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void StripComments()
    {
      Assert.AreEqual(
            "apples, pears\ngrapes\nbananas", 
            StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" })
          );

      Assert.AreEqual(
        "a\nc\nd", 
        StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" })
        );
    }

    // [Test]
    // public void Test1()
    // {
    //   Assert.AreEqual("a\nb\nc\nf u", StripCommentsSolution.StripComments("a\nb # d \nc\nf u ! ck", new string[] {"#", "!"}));
    // }
  }
}