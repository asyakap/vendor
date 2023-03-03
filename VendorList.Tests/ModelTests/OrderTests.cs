using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using List.Models;

namespace Orders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    
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

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_String()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "test";
      string description = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, date, price);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }


  }
}