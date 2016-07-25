using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class MainMenu
  {
    internal static int Menu(MenuOptions options)
    {
      int output=-1;
      bool success;
      Console.WriteLine("-----------------");
      Console.WriteLine("=== Main Menu ===");
      Console.WriteLine("-----------------");
      foreach (string s in options.MenuEntries)
      {
        Console.WriteLine(s);
      }
      Console.WriteLine("Please select an option: ");
      success = Int32.TryParse(Console.ReadLine(), out output);
      if (success == false || output<0 || output > options.MenuEntries.Count)
      {
        Console.WriteLine("\nInvalid selection. Please try again...\n");
        output = Menu(options);
      }
      return output;
    }
  }
}
