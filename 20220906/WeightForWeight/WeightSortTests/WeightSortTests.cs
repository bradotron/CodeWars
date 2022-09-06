using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
  [TestClass()]
  public class WeightSortTests
  {
    [TestMethod()]
    public void orderWeightTest()
    {
      Assert.AreEqual("", WeightSort.orderWeight(""));
      Assert.AreEqual("2000 103 123 4444 99", WeightSort.orderWeight("103 123 4444 99 2000"));
      Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
    }

    [TestMethod()]
    public void CalculateWeightTest()
    {
      Assert.AreEqual(1, Weight.CalculateWeight("1"));
      Assert.AreEqual(3, Weight.CalculateWeight("12"));
      Assert.AreEqual(16, Weight.CalculateWeight("4444"));
      Assert.AreEqual(1, Weight.CalculateWeight("100"));
      Assert.AreEqual(18, Weight.CalculateWeight("99"));
    }
  }
}