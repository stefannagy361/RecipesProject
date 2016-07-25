using System;
using System.Collections.Generic;
using System.Data.Entity;
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
      }
    }

    internal static bool LoggedIn(DataContext context)
    {
      bool logged = false;
      foreach(User user in context.Users)
      {
        if (Session.Session_ID == user.Id)
          logged = true;
      }
      return logged;
    }
  }
}
