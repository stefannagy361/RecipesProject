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

    internal static void NeedLogin()
    {
      Console.WriteLine("[!]You must be logged in to perform this action!");
    }

    internal static void ActionSuccessfull()
    {
      Console.WriteLine("The specified action was successfull. Returning to the main menu.");
    }
  }
}
