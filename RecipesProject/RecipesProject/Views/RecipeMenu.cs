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
      string ingredientName="";
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
          recipe.Name = name;
          do
          {

            Console.WriteLine("Enter the ingredients (press ENTER when you're finsihed): ");
            ingredientName = Console.ReadLine();
            var ingredient = new Product() { Name = ingredientName };
            RecipeMaker.AddRecipe(recipe,ingredient);

          }while(ingredientName!="");
          var Repo = new Repository<Recipe>(context);
          Repo.Add(recipe);
          Notifications.ActionSuccessfull();
          
        }
        else
          Notifications.NeedLogin();
      }
    }
  }
}
