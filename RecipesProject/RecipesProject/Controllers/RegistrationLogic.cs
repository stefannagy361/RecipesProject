using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class RegistrationLogic
  {
    internal static void ParseRegister(string username, string password)
    {
      int finalPassword;
      finalPassword = password.GetHashCode();
      using (var context = new DataContext())
      {
        context.Users.Add(new User() { Username = username, Password = finalPassword});
        context.SaveChanges();
      }
    }
  }
}
