using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using List.Models;
using System;

namespace VendorList.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> orders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, string date, string price)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, date, price);
      foundVendor.AddOrder(newOrder);
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("orders", VendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpPost("/vendor/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }


  }
}