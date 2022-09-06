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
    public void Test1()
    {
      CollectionAssert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
    }

    [TestMethod()]
    public void Test2()
    {
      CollectionAssert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
    }

    [TestMethod()]
    public void Test3()
    {
      CollectionAssert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
    }

    [TestMethod()]
    public void Test4()
    {
      CollectionAssert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
    }

    [TestMethod()]
    public void Test5()
    {
      CollectionAssert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
    }

    [TestMethod()]
    public void Test6()
    {
      CollectionAssert.AreEqual(new int[] { 3 }, Kata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
    }
  }
}