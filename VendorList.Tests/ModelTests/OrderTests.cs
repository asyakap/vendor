using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using List.Models;

namespace Orders.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfConstructor_Order()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }




  }
}