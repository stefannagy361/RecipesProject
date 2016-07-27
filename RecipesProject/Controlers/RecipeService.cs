using System.Collections.Generic;
using System.Linq;
using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class RecipeService
	{
		public static void AddRecipe(string _recName, string _ingreds, string _instruct)
		{
				var _recipe = new Recipe() 
				{	Name = _recName,
					Ingredients = _ingreds,
					Instructions = _instruct,
					PublisherId = AutentificatorService._Session 
				};
				new DataAcces().Add<Recipe>(_recipe);
			
		}
			public static List<Recipe> CheckForRecipes()
		{
			List<Recipe> _Output = new List<Recipe>();
			List<string> _myingridients = new List<string>();
			foreach (Ingredient mying in FridgeService.OpenFridge(AutentificatorService._Session))
			{
				_myingridients.Add(mying.Name.ToUpper());
			}
				var _allRecipes = new List<Recipe>();

			_allRecipes = new DataAcces().GetAll<Recipe>().ToList<Recipe>();
				foreach(Recipe recipe in _allRecipes)
				{	List<string> RecipeIngs = new List<string>();
					var splitted =	recipe.Ingredients.Split(',');

					foreach (string ingrid in splitted)
					{
						RecipeIngs.Add(ingrid.ToUpper());
					}

					if(RecipeIngs.Intersect(_myingridients).Count()==RecipeIngs.Count())
					{ _Output.Add(GetRecipe(recipe.Id)); }

				}
				return _Output;
		}
		public static Recipe GetRecipe(int _recipeId)
		{
				return new DataAcces().Get<Recipe>(_recipeId);
		}	
	}
}
