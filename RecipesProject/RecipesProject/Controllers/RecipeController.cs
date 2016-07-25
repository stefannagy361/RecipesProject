using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using RecipesProject.Views;

namespace RecipesProject.Controllers
{
	public class RecipeController
	{
		private static RecipesContext _context = new RecipesContext();
		static List<Recipe> recipeList = new List<Recipe>();

		internal static void FindRecipes()
		{
			AddRecipes();

			IEnumerable<string> items = _context.Items
				.Where(i => i.Owner_Id == ItemController.Owner.Id)
				.Select(i => i.Name);

			int k = 0;
			Messages.Show("With your current ingredients you can make: ");
			foreach (Recipe recipe in recipeList)
				if (items.Intersect(recipe.Ingredients).ToList().Count == recipe.Ingredients.Count)
				{
					Messages.Show("\t", recipe.Name);
					k++;
				}
			if (k == 0)
				Messages.Show("\t", "Nothing");
		}

		private static void AddRecipes()
		{
			recipeList.Add(new Recipe()
			{
				Name = "Bacon and eggs",
				Ingredients = new List<string>(){
					"bacon",
					"egg"
				}
			});

			recipeList.Add(new Recipe()
			{
				Name = "Salad",
				Ingredients = new List<string>()
				{
					"tomatoe",
					"cabbage",
					"cucumber"
				}
			});
		}
	}
}
