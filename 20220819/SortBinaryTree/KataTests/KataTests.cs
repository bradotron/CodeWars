using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
  [TestClass()]
  public class KataTests
  {
    [TestMethod()]
    public void TreeByLevelsTest()
    {
      //           1
      //       2        3
      //        4      5 6       
      CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5, 6 }, Kata.TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)));
    }
  }
}