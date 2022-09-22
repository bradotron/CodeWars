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
    public void NextBiggerNumberTest()
    {
      Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
    }
  }
}