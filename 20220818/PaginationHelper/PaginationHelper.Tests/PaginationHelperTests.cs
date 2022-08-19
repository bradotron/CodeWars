using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaginationHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationHelper.Tests
{
  [TestClass()]
  public class PaginationHelperTests
  {
    [TestMethod()]
    public void ConstructorTest()
    {
      List<string> list = new List<string>();
      int itemsPerPage = 10;
      Assert.IsNotNull(new PaginationHelper<string>(list, itemsPerPage));
    }

    [TestMethod()]
    public void ItemCount()
    {
      PaginationHelper<char> paginationHelper = new PaginationHelper<char>(new[] { 'a', 'b', 'c' }, 3);
      Assert.AreEqual(3, paginationHelper.ItemCount);
    }

    [TestMethod()]
    public void PageCount()
    {
      List<int> collection = new List<int>();
      for (int i = 1; i < 21; i++)
      {
        collection.Add(i);
      }
      PaginationHelper<int> fourPages = new PaginationHelper<int>(collection, 5);
      PaginationHelper<int> threePages = new PaginationHelper<int>(collection, 8);
      PaginationHelper<int> zeroPages = new PaginationHelper<int>(new List<int>(), 5);

      Assert.AreEqual(4, fourPages.PageCount);
      Assert.AreEqual(3, threePages.PageCount);
      Assert.AreEqual(0, zeroPages.PageCount);
    }

    [TestMethod()]
    public void PageItemCount_ValidPages()
    {
      List<int> collection = new List<int>();
      for (int i = 1; i < 21; i++)
      {
        collection.Add(i);
      }
      PaginationHelper<int> fourPages = new PaginationHelper<int>(collection, 5);
      PaginationHelper<int> threePages = new PaginationHelper<int>(collection, 8);

      Assert.AreEqual(8, threePages.PageItemCount(0));
      Assert.AreEqual(8, threePages.PageItemCount(1));
      Assert.AreEqual(4, threePages.PageItemCount(2));
    }

    [TestMethod()]
    public void PageItemCount_InvalidPages()
    {
      List<int> collection = new List<int>();
      for (int i = 1; i < 21; i++)
      {
        collection.Add(i);
      }
      PaginationHelper<int> fourPages = new PaginationHelper<int>(collection, 5);
      PaginationHelper<int> threePages = new PaginationHelper<int>(collection, 8);

      Assert.AreEqual(-1, fourPages.PageItemCount(-1));
      Assert.AreEqual(-1, fourPages.PageItemCount(5));
    }

    [TestMethod()]
    public void PageIndex_ValidIndexes()
    {
      List<int> collection = new List<int>();
      for (int i = 1; i < 21; i++)
      {
        collection.Add(i);
      }
      PaginationHelper<int> fourPages = new PaginationHelper<int>(collection, 5);

      //           1
      // 01234567890123456789
      // 00000111112222233333
      Assert.AreEqual(0, fourPages.PageIndex(0));
      Assert.AreEqual(0, fourPages.PageIndex(1));
      Assert.AreEqual(0, fourPages.PageIndex(2));
      Assert.AreEqual(0, fourPages.PageIndex(3));
      Assert.AreEqual(0, fourPages.PageIndex(4));
      Assert.AreEqual(1, fourPages.PageIndex(5));
      Assert.AreEqual(2, fourPages.PageIndex(10));
      Assert.AreEqual(2, fourPages.PageIndex(14));
      Assert.AreEqual(3, fourPages.PageIndex(19));
    }

    [TestMethod()]
    public void PageIndex_InvalidIndexes()
    {
      List<int> collection = new List<int>();
      for (int i = 1; i < 21; i++)
      {
        collection.Add(i);
      }
      PaginationHelper<int> fourPages = new PaginationHelper<int>(collection, 5);

      Assert.AreEqual(-1, fourPages.PageIndex(-1));
      Assert.AreEqual(-1, fourPages.PageIndex(21));
    }
  }
}