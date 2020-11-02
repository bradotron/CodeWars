using NUnit.Framework;
using System;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void Test1()
    {
      long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
      Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
    }

    [Test]
    public void Test2()
    {
      //(69,130)(87,1310)(3,4)
      // Expected: "(18078,34060)(2262,34060)(25545,34060)"
      // But was:  "(90390,170300)(11310,170300)(127725,170300)"

      long[,] lst = new long[,] { { 69, 130 }, { 87, 1310 }, { 3, 4 } };
      Assert.AreEqual("(18078,34060)(2262,34060)(25545,34060)", Fracts.convertFrac(lst));
    }

    [Test]
    public void LCM_Test()
    {
      Assert.AreEqual(420, Kata.Fracts.lcm(new long[] {1, 2, 3, 4, 5, 10, 20, 35}));
    }
  }
}