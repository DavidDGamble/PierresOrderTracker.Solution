using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresOrderTracker.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Weekly Order", "This order will be dilvered once a week", 100, "12/16/22");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}