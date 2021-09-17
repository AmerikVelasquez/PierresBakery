using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set;}
    public int Price {get; set;}

    public Bread(int breadCost, int price = 0)
    {
      BreadCost = breadCost;
      Price = price;
    }

    public int CalculatePrice()
    {
      int breadPay = BreadCost % 3;
      if(breadPay == 0)
      {
        int remainder0 = (BreadCost/3)*10;
        return Price = remainder0;
      } 
      else if(breadPay == 1)
      {
        int remainder1 = (((BreadCost - 1)/3)*10)+5;
        return Price = remainder1; 
      }
       else
      {
        int remainder2 = ((BreadCost+1)/3)*10;
        return Price = remainder2;
      } 
    }
  }
}