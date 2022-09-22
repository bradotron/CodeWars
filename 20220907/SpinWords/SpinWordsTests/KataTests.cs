using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
  [TestClass()]
  public class KataTests
  {
    [TestMethod()]
    public void SpinWordsTest()
    {
      Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
      //Assert.AreEqual(1, Kata.SpinWords("Welcome"));

      Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
      //Assert.AreEqual(3, Kata.SpinWords("Hey fellow warriors"));

      Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
      //Assert.AreEqual(4, Kata.SpinWords("This is a test"));
    }
  }
}