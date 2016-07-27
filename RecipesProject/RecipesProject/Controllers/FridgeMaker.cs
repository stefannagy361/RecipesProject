using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class FridgeMaker
  {
    public static void AddFridge()
    {
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          var Repo = new Repository<Fridge>(context);
          var fridge = new Fridge() { User_ID = Session.Session_ID };
          Repo.Add(fridge);
          context.SaveChanges();
          Notifications.ActionSuccessfull();
        }
        else
          Notifications.NeedLogin();
      }
    }
  }
}
