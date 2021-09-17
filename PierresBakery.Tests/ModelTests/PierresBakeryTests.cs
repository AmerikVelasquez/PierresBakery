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
      testCost.CalculatePrice();
      Assert.AreEqual(5, testCost.Price);
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo0_true()
    {
      Bread testCost = new Bread(3);
      testCost.CalculatePrice();
      Assert.AreEqual(10, testCost.Price);
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo1_true()
    {
      Bread testCost = new Bread(4);
      testCost.CalculatePrice();
      Assert.AreEqual(15, testCost.Price);
    }

    [TestMethod]
    public void Bread_ReturnPriceIfModulo2_true()
    {
      Bread testCost = new Bread(8);
      testCost.CalculatePrice();
      Assert.AreEqual(30, testCost.Price);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_ReturnPrice_true()
    {
      Pastry testPastry = new Pastry(1);
      testPastry.CalculatePrice();
      Assert.AreEqual(2, testPastry.Price);
    }
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo0_true()
    {
      Pastry testPastry = new Pastry(3);
      testPastry.CalculatePrice();
      Assert.AreEqual(5, testPastry.Price);
    }
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo1_true()
    {
      Pastry testPastry = new Pastry(7);
      testPastry.CalculatePrice();
      Assert.AreEqual(12, testPastry.Price);
    }
    [TestMethod]
    public void Pastry_ReturnPriceFor2_true()
    {
      Pastry testPastry = new Pastry(2);
      testPastry.CalculatePrice();
      Assert.AreEqual(4, testPastry.Price);
    }  
    [TestMethod]
    public void Pastry_ReturnPriceIfModulo2_true()
    {
      Pastry testPastry = new Pastry(11);
      testPastry.CalculatePrice();
      Assert.AreEqual(19, testPastry.Price);
    }
  }
}

