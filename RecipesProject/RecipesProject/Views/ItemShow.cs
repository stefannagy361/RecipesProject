using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class ItemShow
  {
    internal static void ShowItems()
    {
      Console.WriteLine("-----------------");
      Console.WriteLine("=== Item list ===");
      Console.WriteLine("-----------------");
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          Console.WriteLine("\nID\tName\t\tFridge");
          Console.WriteLine("--------------------------------------");
          int currentFridge=-1;
          foreach(Fridge fridge in context.Fridges)
          {
            if (fridge.User_ID == Session.Session_ID)
            {
              currentFridge = fridge.ID;
              foreach (Product product in context.Products)
              {
                if (product.FridgeId == currentFridge)
                  Console.WriteLine("{0}\t{1}\t{2}", product.ID, product.Name, product.FridgeId);
              }
            }
          }
          
        }
        Console.WriteLine("\n");
      }
    }
  }
}
