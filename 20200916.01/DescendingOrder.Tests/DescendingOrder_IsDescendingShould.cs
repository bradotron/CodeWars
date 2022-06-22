using System;
using NUnit.Framework;
using DescendingOrder;

namespace DescendingOrder.Tests
{
    [TestFixture]
    public class Tests
    {
        private DescendingOrder _descendingOrder;

        [SetUp]
        public void Setup()
        {
            _descendingOrder = new DescendingOrder();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, DescendingOrder.PutIntoDescendingOrder(0));   
            Assert.AreEqual(54421, DescendingOrder.PutIntoDescendingOrder(42145));
            Assert.AreEqual(654321, DescendingOrder.PutIntoDescendingOrder(145263));
            Assert.AreEqual(987654321, DescendingOrder.PutIntoDescendingOrder(123456789));
        }
    }
}