using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We sell delicious bread and pastries!!!");
      Console.WriteLine("Our prices vary but the deals we are currently advertising are Buy 2, get 1 free. A single loaf costs $5, two loaves costs $10. Pastries deals are Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.");
      Console.WriteLine("How many Loaves of bread would you like?");
      string breadOrder = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      string pastryOrder = Console.ReadLine();
    }
  }
}