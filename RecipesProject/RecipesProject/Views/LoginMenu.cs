using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class LoginMenu
  {
    internal static void Login()
    {
      string username, password;
      Console.WriteLine("-----------------");
      Console.WriteLine("===== Login =====");
      Console.WriteLine("-----------------");
      Console.WriteLine("Username: ");
      username = Console.ReadLine();
      Console.WriteLine("Password: ");
      password = Console.ReadLine();
      LoginService.LoginParse(username, password);
    }
  }
}
