using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				
				Console.WriteLine("-------Logged user menu--------");
				 _userChoice = MenuView.DisplayMenu(new List<string> { "Add item to fridge", "View items in Fridge","Add Recipe", "Get Recipe", "Logout", });
				switch (_userChoice)
				{
					case 1:
						{
							Console.Clear();
							Console.Write("Enter Ingredient name: ");
							string _name = Console.ReadLine();
							IngredientServices.AddItem(AutentificatorService._Session, _name);
							break;
						}
					case 2:
						{
							Console.Clear();
							Console.WriteLine("\n------Ingridients in the fridge -----");
							var _ingList = FridgeService.OpenFridge(AutentificatorService._Session);
							foreach (var _ingred in _ingList)
							{
								Console.WriteLine(_ingred.Name);
							
							}
							Console.ReadLine();
							break;
						}
					case 3:
						{
							Console.Clear();
							Console.Write("Recipe name: ");
							string _recpeName = Console.ReadLine();
							Console.Write("Enter Ingredients separated by comas: ");
							string _ingridients = Console.ReadLine();
							RecipeService.AddRecipe(_recpeName, _ingridients);
							break;
						}
					case 4:
						{
							Console.Clear();
							var _goodRecipes = RecipeService.CheckForRecipes();
							foreach(Recipe rec in _goodRecipes)
							{
								Console.WriteLine("\t"+rec.Name.ToUpper());
								Console.WriteLine("Ingridients:"+rec.Ingredients + "\n");
							}
							break;
						}
					case 5:
						{
							Console.Clear();
							AutentificatorService.LogOut();
							UserMenu.ShowUserMenu();
							break;
						}
				}
			}
		}
	}
}
