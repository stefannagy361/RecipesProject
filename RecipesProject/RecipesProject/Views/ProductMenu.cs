using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class ProductMenu
  {
    internal static void AddProduct()
    {
      string name;
      Console.Clear();
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          Console.WriteLine("----------------");
          Console.WriteLine("=== Add item ===");
          Console.WriteLine("----------------");
          Console.WriteLine("Please type the name of the product: ");
          name = Console.ReadLine();
          ProductMaker.ParseProduct(name);
        }
        else
          Notifications.NeedLogin();
      }
    }
  }
}
