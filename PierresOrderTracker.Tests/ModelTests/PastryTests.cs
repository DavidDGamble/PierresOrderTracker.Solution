using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryTotal_ReturnsPastryTotal_Int()
    {
      int expected = 5;
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(expected, testPastry.PastryTotal);
    }

    [TestMethod]
    public void GetTotalCost_ReturnsTotalCost_Int()
    {
      int expected = 0;
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf1Pastry_Int()
    {
      int expected = 2;
      Pastry testPastry = new Pastry(1);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf3Pastiries_Int()
    {
      int expected = 5;
      Pastry testPastry = new Pastry(3);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf5Pastiries_Int()
    {
      int expected = 9;
      Pastry testPastry = new Pastry(5);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf6Pastiries_Int()
    {
      int expected = 10;
      Pastry testPastry = new Pastry(6);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }
  }
}