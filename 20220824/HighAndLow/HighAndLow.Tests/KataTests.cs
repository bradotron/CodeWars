using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighAndLow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.Tests
{
  [TestClass()]
  public class KataTests
  {
    [TestMethod()]
    public void HighAndLowTest()
    {
      Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }
  }
}