using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Whole Foods", "Local grocery store.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_List()
    {
      Vendor newVendor1 = new Vendor("Whole Foods", "Local grocery store.");
      Vendor newVendor2 = new Vendor("Stump Town", "Local coffee shop.");
      List<Vendor> testList = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(testList, Vendor.GetAll());
    }
  }
}