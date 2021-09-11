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
        return  breadFinal = remainder0;
      } 
      else if(breadPay == 1)
      {
        int remainder1 = (((BreadCost - 1)/3)*10)+5;
        return  breadFinal = remainder1; 
      }
       else
      {
        int remainder2 = ((BreadCost+1)/3)*10;
        return  breadFinal = remainder2;
      } 
    }
  }
  public class Pastry
  {
    public int PastryCost { get; set;}

    public Pastry(int pastryCost)
    {
      PastryCost = pastryCost;
    }

    public int price(int PastryCost)
    {
      int pastryPay = PastryCost % 3;
      if(PastryCost == 1)
      {
        return  pastryFinal = 2;
      }
      else if(PastryCost == 2)
      {
        return  pastryFinal = 4;
      }
      else if(pastryPay == 0)
      {
        int remainder0 = (PastryCost/3)* 5;
        return pastryFinal = remainder0;
      }
      else if(pastryPay == 1)
      {
        int remainder1 = (((PastryCost +2)/3)*5)-3;
        return  pastryFinal = remainder1;
      }
      else if (pastryPay == 2)
      {
        int remainder2 = (((PastryCost +1)/3)*5)-1;
        return  pastryFinal = remainder2;
      }
      return  pastryFinal = 0;
    }
  }
}