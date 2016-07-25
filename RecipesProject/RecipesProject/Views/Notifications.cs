using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  static class Notifications
  {
    internal static void InvalidPassword()
    {
      Console.WriteLine("\n[!]Invalid password!");
    }

    internal static void InvalidUser()
    {
      Console.WriteLine("\n[!]Invalid username and/or password!\n");
    }

    internal static void LoginSuccessful()
    {
      Console.WriteLine("\nLogin succesfull\n");
    }
  }
}
