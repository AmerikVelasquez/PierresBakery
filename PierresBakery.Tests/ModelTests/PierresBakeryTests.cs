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
    public void Pastry_ReturnPrice_true()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(2, testPastry.price(1));
    }
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo0_true()
    {
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(5, testPastry.price(3));
    }
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo1_true()
    {
      Pastry testPastry = new Pastry(7);
      Assert.AreEqual(12, testPastry.price(7));
    }
    [TestMethod]
    public void Pastry_ReturnPriceFor2_true()
    {
      Pastry testPastry = new Pastry(2);
      Assert.AreEqual(4, testPastry.price(2));
    }  
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo2_true()
    {
      Pastry testPastry = new Pastry(11);
      Assert.AreEqual(19, testPastry.price(11));
    }
  }
}

