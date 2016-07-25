using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class LoginService
  {
    internal static void LoginParse(string username, string password)
    {
      int finalPassword;
      finalPassword = password.GetHashCode();
      using (var context = new DataContext())
      {
        bool loginSucceeded = false;
        foreach (User user in context.Users)
        {
          if (username == user.Username)
            if (finalPassword == user.Password)
            {
              //call a service that sets the ID for session + will call notif to display success
              Session.SetSession(user.Id);
              loginSucceeded = true;
            }
        }
        if (loginSucceeded == false)
          Notifications.InvalidUser();
        //var Repo = new Repository<User>(context);
        //var user = new User() { Username = username, Password = finalPassword };
        //Repo.Add(user);
        ////context.Users.Add(new User() { Username = username, Password = finalPassword}); old method, keep just in case :v
        //context.SaveChanges();
      }

    }
  }
}
