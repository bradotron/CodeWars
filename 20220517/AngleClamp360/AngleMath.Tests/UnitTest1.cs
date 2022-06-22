using NUnit.Framework;

namespace AngleMath.Tests;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Test1()
  {
    Assert.AreEqual(145f, AngleMath.AngleClamp360(145f));
    Assert.AreEqual(30f, AngleMath.AngleClamp360(390f));
    Assert.AreEqual(330f, AngleMath.AngleClamp360(-30f));
  }

  [Test]
  public void LargePositiveNumbers()
  {
    Assert.AreEqual(45f, AngleMath.AngleClamp360(360f + 360f + 45f));
    Assert.AreEqual(45f, AngleMath.AngleClamp360((10f * 360f) + 45f));
    Assert.AreEqual(69f, AngleMath.AngleClamp360(360f + 360f + 69f));
  }

  [Test]
  public void LargeNegativeNumbers()
  {
    Assert.AreEqual(360f - 45f, AngleMath.AngleClamp360(-360f - 360f - 45f));
  }
}