using Microsoft.AspNetCore.Mvc;
using List.Models;
using System.Collections.Generic;

namespace VendorList.Controllers
{
    public class SearchController : Controller
    {

      [HttpGet("/search")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/search/vendororders")]
      public ActionResult Show(string vendorName)
      {
        List<Vendor> vendorList = new List<Vendor> { };
        vendorList = Vendor.FindByVendorName(vendorName);
        return View(vendorList);
      }

    }
}
