using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; set;}
    public int Price {get; set;}

    public Pastry(int pastryCost, int price = 0)
    {
      PastryCost = pastryCost;
      Price = price;
    }

    public int CalculatePrice()
    {
      int pastryPay = PastryCost % 3;
      if(PastryCost == 1)
      {
        return Price = 2;
      }
      else if(PastryCost == 2)
      {
        return Price = 4;
      }
      else if(pastryPay == 0)
      {
        int remainder0 = (PastryCost/3)* 5;
        return Price = remainder0;
      }
      else if(pastryPay == 1)
      {
        int remainder1 = (((PastryCost +2)/3)*5)-3;
        return Price = remainder1;
      }
      else if (pastryPay == 2)
      {
        int remainder2 = (((PastryCost +1)/3)*5)-1;
        return Price = remainder2;
      }
      return Price = 0;
    }
  }
}