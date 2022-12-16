using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresOrderTracker.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Weekly Order", "This order will be dilvered once a week", 100, "12/16/22");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_List()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_List()
    {
      Order newOrder1 = new Order("Weekly Order", "This order will be dilvered once a week", 100, "12/16/22");
      Order newOrder2 = new Order("Monthly Order", "This order will be dilvered once a month", 1000, "12/16/22");
      List<Order> testList = new List<Order> { newOrder1, newOrder2 };
      CollectionAssert.AreEqual(testList, Order.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsOrderCorrespondingToId_Order()
    {
      Order newOrder1 = new Order("Weekly Order", "This order will be dilvered once a week", 100, "12/16/22");
      Order newOrder2 = new Order("Monthly Order", "This order will be dilvered once a month", 1000, "12/16/22");
      Assert.AreEqual(newOrder1, Order.Find(1));
    }
  }
}