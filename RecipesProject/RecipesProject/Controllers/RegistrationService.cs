using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class RegistrationService
  {
    internal static void ParseRegister(string username, string password)
    {
      int finalPassword;
      finalPassword = password.GetHashCode();
      using (var context = new DataContext())
      {
        var Repo = new Repository<User>(context);
        var user = new User() { Username = username, Password = finalPassword };
        Repo.Add(user);
        //context.Users.Add(new User() { Username = username, Password = finalPassword}); old method, keep just in case :v
        context.SaveChanges();
      }
    }
  }
}
