using Microsoft.VisualStudio.TestTools.UnitTesting;
using List.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}