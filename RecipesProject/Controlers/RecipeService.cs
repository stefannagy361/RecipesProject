using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class RecipeService
	{
		public static void AddRecipe(string _recName, string _ingreds, string _instruct)
		{
				using (var _context = new RecipesProjectContext())
			{
				var _recipe = new Recipe() { Name = _recName, Ingredients = _ingreds, Instructions = _instruct, PublisherId = AutentificatorService._Session };
				DataAcces.Add<Recipe>(_recipe, _context, _context.Recipes);
			};
		}
			public static List<Recipe> CheckForRecipes()
		{
			List<Recipe> _Output = new List<Recipe>();
			List<string> _myingridients = new List<string>();
			foreach (Ingredient mying in FridgeService.OpenFridge(AutentificatorService._Session))
				_myingridients.Add(mying.Name.ToUpper());
			
				var _allRecipes = new List<Recipe>();
					using (var _context = new RecipesProjectContext())
			{
			_allRecipes = DataAcces.GetAll<Recipe>(_context,_context.Recipes);
					}
				foreach(Recipe recipe in _allRecipes)
				{	List<string> RecipeIngs = new List<string>();
					var splitted =	recipe.Ingredients.Split(',');
					foreach (string ingrid in splitted)
						RecipeIngs.Add(ingrid.ToUpper());

					if(RecipeIngs.Intersect(_myingridients).Count()==RecipeIngs.Count())
					{ _Output.Add(GetRecipe(recipe.Id)); }

				}
				return _Output;
		}
		public static Recipe GetRecipe(int _recipeId)
		{
			using (var _context = new RecipesProjectContext())
			{
				return DataAcces.Get<Recipe>(_recipeId,_context,_context.Recipes);
					}
		}	
	}
}
