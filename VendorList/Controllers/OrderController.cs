using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using List.Models;
using System;

namespace VendorList.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, string date, string price)
    {
      Order myOrder = new Order(title, description, price, date);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }

    [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }


    [HttpPost("/vendor/{vendorId}/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpPost("/vendor/{vendorId}/orders/{orderId}/delete")]
    public ActionResult DeleteOne(int orderId)
    {
      Order order = Order.Find(orderId);
      Order.ClearOne(orderId);
      return View();
    }
  }
}