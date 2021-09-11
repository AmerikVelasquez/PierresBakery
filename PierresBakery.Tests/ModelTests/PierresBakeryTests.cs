using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void Bread_ReturnsPrice_true()
    {
      Bread testCost = new Bread(1);
      Assert.AreEqual(5, testCost.price(1));
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo0_true()
    {
      Bread testCost = new Bread(3);
      Assert.AreEqual(10, testCost.price(3));
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo1_true()
    {
      Bread testCost = new Bread(4);
      Assert.AreEqual(15, testCost.price(4));
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo2_true()
    {
      Bread testCost = new Bread(8);
      Assert.AreEqual(30, testCost.price(8));
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void 
  }
}

