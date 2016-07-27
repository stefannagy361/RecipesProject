using System;
using System.Collections.Generic;
using RecipesProject.Models;
using RecipesProject.Controlers;

namespace RecipesProject.Views
{
	class LoggedUserMenu
	{
		public static void ShowLoggedMenu()
		{
			
			var _userChoice = -1;
			while (_userChoice != 5)
			{
				Console.Clear();
				Console.WriteLine("-------Logged user menu--------");
				 _userChoice = MenuView.DisplayMenu(new List<string> 
				 {
					 "Add item to fridge",
					 "View items in Fridge",
					 "Add Recipe",
					 "Get Recipe",
					 "Logout",
				 });
				
					if(_userChoice == 1)
					{
						AddIngridient();
					}
				if(_userChoice == 2)
					{
						ShowItemsInFridge();
					}
				if(_userChoice == 3)
					{
						AddRecipe();
					}
				if(_userChoice ==4)
					{
						GetAvailableRecipes();
					}
				if(_userChoice == 5)
					{
					Console.Clear();
					AutentificatorService.LogOut();
					UserMenu.ShowUserMenu();
					}
			}
		}

		private static void GetAvailableRecipes()
		{
			Console.Clear();
			Console.WriteLine("     -----Usable Recipes-----");
			var _goodRecipes = RecipeService.CheckForRecipes();
			foreach(Recipe rec in _goodRecipes)
			{
				Console.WriteLine("\t"+rec.Name.ToUpper());
				Console.WriteLine("Ingridients:"+rec.Ingredients + "\n");
				Console.WriteLine("Instructions:" + rec.Instructions + "\n");
			}
			Console.ReadLine();
		}

		private static void AddRecipe()
		{
			Console.Clear();
			Console.WriteLine("     -----Add Recipe-----");
			Console.Write("Recipe name: ");
			string _recpeName = Console.ReadLine();
			Console.Write("Enter Ingredients separated by comas: ");
			string _ingridients = Console.ReadLine();
			Console.Write("Enter Instructions : ");
			string _instructions = Console.ReadLine();
			RecipeService.AddRecipe(_recpeName, _ingridients, _instructions);
		}

		private static void ShowItemsInFridge()
		{
			Console.Clear();
			Console.WriteLine("\n------Ingridients in the fridge -----");
			var _ingList = FridgeService.OpenFridge(AutentificatorService._Session);
			foreach (var _ingred in _ingList)
			{
				Console.WriteLine(_ingred.Name);
			}
			Console.ReadLine();
		}
		private static void AddIngridient()
		{
			Console.Clear();
			Console.WriteLine("     -----Add item to the fridge-----");
			Console.Write("Enter Ingredient name: ");
			string _name = Console.ReadLine();
			IngredientServices.AddItem(AutentificatorService._Session, _name);
		}
	}
}
