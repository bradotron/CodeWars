using NUnit.Framework;
using Kata;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(new int[][] { new[] { -2, -1 }, new[] { 3, 4 } }, Matrix.Minor(new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } }, 0, 0));
      Assert.AreEqual(new int[][] { new[] { 1, -1 }, new[] { 1, 4 } }, Matrix.Minor(new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } }, 0, 1));
      Assert.AreEqual(new int[][] { new[] { 1, -2 }, new[] { 1, 3 } }, Matrix.Minor(new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } }, 0, 2));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual(1, Matrix.Determinant(new int[][] { new int[] { 1 } }));
      Assert.AreEqual(-1, Matrix.Determinant(new int[][] { new[] { 1, 3 }, new[] { 2, 5 } }));
      Assert.AreEqual(-20, Matrix.Determinant(new int[][] { new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 } }));
    }
  }
}