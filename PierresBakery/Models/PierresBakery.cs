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
      } 
      else if(breadPay == 1)
      {
        int remainder1 = (((BreadCost - 1)/3)*10)+5;
        return remainder1; 
      }
       else
      {
        int remainder2 = ((BreadCost+1)/3)*10;
        return remainder2;
      } 
    }
  }
  // public class Pastry
  // {

  // }
}