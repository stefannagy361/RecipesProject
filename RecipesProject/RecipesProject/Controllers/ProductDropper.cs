using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class ProductDropper
  {
    internal static void RemoveProduct(string name)
    {
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          int itemId = -1;
          bool success = false;
          var Repo = new Repository<Product>(context);
          foreach (Product product in context.Products)
          {
            if (name == product.Name)
            {
              itemId = product.ID;
              var itemToRemove = context.Products.SingleOrDefault(x => x.ID == itemId);
              context.Products.Remove(itemToRemove);
              success = true;
            }
          }
          context.SaveChanges();
          if (success)
            Notifications.ActionSuccessfull();
          else
            Notifications.ProductNotFound();
        }
        else
          Notifications.NeedLogin();
      }
    }
  }
}
