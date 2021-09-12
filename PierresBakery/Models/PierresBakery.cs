using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set;}
    public int BreadFinal {get; set;}
    public Bread(int breadCost, int breadFinal)
    {
      BreadCost = breadCost;
      BreadFinal = breadFinal;
    }

    public int price(int BreadCost)
    {
      int breadPay = BreadCost % 3;
      if(breadPay == 0)
      {
        int remainder0 = (BreadCost/3)*10;
        return  BreadFinal = remainder0;
      } 
      else if(breadPay == 1)
      {
        int remainder1 = (((BreadCost - 1)/3)*10)+5;
        return  BreadFinal = remainder1; 
      }
       else
      {
        int remainder2 = ((BreadCost+1)/3)*10;
        return  BreadFinal = remainder2;
      } 
    }
  }
  public class Pastry
  {
    public int PastryCost { get; set;}
    public int PastryFinal {get; set;}
    public Pastry(int pastryCost, int pastryFinal)
    {
      PastryCost = pastryCost;
      PastryFinal = pastryFinal;
    }

    public int price(int PastryCost)
    {
      int pastryPay = PastryCost % 3;
      if(PastryCost == 1)
      {
        return  PastryFinal = 2;
      }
      else if(PastryCost == 2)
      {
        return  PastryFinal = 4;
      }
      else if(pastryPay == 0)
      {
        int remainder0 = (PastryCost/3)* 5;
        return PastryFinal = remainder0;
      }
      else if(pastryPay == 1)
      {
        int remainder1 = (((PastryCost +2)/3)*5)-3;
        return  PastryFinal = remainder1;
      }
      else if (pastryPay == 2)
      {
        int remainder2 = (((PastryCost +1)/3)*5)-1;
        return  PastryFinal = remainder2;
      }
      return  PastryFinal = 0;
    }
  }
}