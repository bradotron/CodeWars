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
    public void Rot13Test()
    {
      Assert.AreEqual("grfg", Kata.Rot13("test"));
    }
  }
}