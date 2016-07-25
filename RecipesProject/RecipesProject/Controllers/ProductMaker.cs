using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class ProductMaker
  {
    internal static void ParseProduct(string name)
    {
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          int fridgeId = -1;
          var Repo = new Repository<Product>(context);
          foreach (Fridge fridge in context.Fridges)
          {
            if (fridge.User_ID == Session.Session_ID)
            {
              fridgeId = fridge.ID;
            }
          }
          var product = new Product() { Fridge_ID = fridgeId, Name = name };
          context.SaveChanges();
          Notifications.ActionSuccessfull();
        }
        else
          Notifications.NeedLogin();
      }
    }
  }
}
