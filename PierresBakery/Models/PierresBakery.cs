using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set;}

    public Bread(int breadCost)
    {
      BreadCost = breadCost;
    }

    public int price(int BreadCost)
    {
      int breadPay = BreadCost % 3;
      if(breadPay == 0)
      {
        int remainder0 = (BreadCost/3)*10;
        return remainder0;
      } else {
        return BreadCost = 5;
      }
    }
  }
  // public class Pastry
  // {

  // }
}