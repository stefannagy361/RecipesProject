using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class RegisterMenu
  {
    internal static void Register()
    {
      Console.Clear();
      Console.WriteLine("----------------");
      Console.WriteLine("=== Register ===");
      Console.WriteLine("----------------");
      string username;
      string password;
      Console.Clear();
      Console.WriteLine("Username: ");
      username = Console.ReadLine();
      Console.WriteLine("Password: ");
      password = Console.ReadLine();
      RegistrationService.ParseRegister(username, password);
    }
  }
}
