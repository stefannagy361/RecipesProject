using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class RecipeMenu
  {
    internal static void ShowRecipeMenu()
    {
      string name;
      string ingredients="";
      Console.Clear();
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          Console.WriteLine("--------------------");
          Console.WriteLine("===  Add recipe  ===");
          Console.WriteLine("--------------------");
          Console.WriteLine("Please enter a name for the recipe: ");
          name = Console.ReadLine();
          var recipe = new Recipe();
          Console.WriteLine("Enter the ingredients (separated ONLY by a comma): ");
          ingredients = Console.ReadLine();
          RecipeService.AddRecipe(recipe,name,ingredients);
          Notifications.ActionSuccessfull();
          
        }
        else
          Notifications.NeedLogin();
      }
    }

    internal static void GetRecipe()
    {
      using (var context = new DataContext())
      {
        if (LoginService.LoggedIn(context))
        {
          Console.Clear();
          Console.WriteLine("--------------------------");
          Console.WriteLine("===  Possible recipes  ===");
          Console.WriteLine("--------------------------");
          Console.WriteLine("Here is a list of possible recipes with the items you currently have in the fridge");
          Console.WriteLine("__________________________________________________________________________________");
          var recipes = RecipeService.GetParameters();
          if (recipes.Count == 0)
            Notifications.NoRecipesToShow();
          else
          {
            foreach (Recipe recipe in recipes)
            {
              Console.WriteLine("{0}",recipe.Name);
            }
          }
        }
        else
          Notifications.NeedLogin();
      }

    }
  }
}
