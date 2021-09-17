using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We sell delicious bread and pastries!");
      Console.WriteLine("Our prices vary due to the current deals that we provide.");
      Console.WriteLine("The cost of bread is 5$ with the deal of buy 2 get 1 free.");
      Console.WriteLine("The cost of pastries are 2$ and every 3 is 5$");

      Console.WriteLine("How many Loaves of bread would you like?");
      string bread = Console.ReadLine();
      int breadCost = int.Parse(bread);
      Bread breadOrder = new Bread(breadCost);
      breadOrder.CalculatePrice();

      Console.WriteLine("How many pastries would you like?");
      string pastry = Console.ReadLine();
      int pastryCost = int.Parse(pastry);
      Pastry pastryOrder = new Pastry(pastryCost);
      pastryOrder.CalculatePrice();

      int totalCost = breadOrder.Price + pastryOrder.Price;
      Console.WriteLine("The total cost for the items you have chosen is" + "" + totalCost + "" + "dollars");
      Console.WriteLine("Would you like to Change or continue your order? enter y or n");
      string response = Console.Readline();
      if(response = y) 
      {
        Main();
      } else 
      {
        Console.WriteLine("it seems there was a problem completing your order. Sorry for the inconvienece but come back another day");
        Main();
      }
     
    }
  }
}