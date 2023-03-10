using Microsoft.AspNetCore.Mvc;
using System;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order foundOrder = Order.Find(orderId);
      Vendor foundVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);
      return View(model);
    }
  }
}