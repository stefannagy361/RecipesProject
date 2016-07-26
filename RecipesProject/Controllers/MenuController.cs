using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Views;

namespace RecipesProject.Controllers
{
	public class MenuController
	{

		public static void LoginMenu(List<string> menuList)
		{
			int index = MenuView.ShowMenu(menuList);
			switch (index)
			{
				case 1:
					{
						UserController.CreateUser();
						LoginMenu(menuList);
						break;
					}
				case 2:
					{
						UserController.Login(menuList);
						break;
					}
				case 3:
					break;
				default:
					break;
			}
		}

		public static void ItemMenu(List<string> menuList)
		{
			int index = MenuView.ShowMenu(menuList);

			switch (index)
			{
				case 1:
					{
						ItemController.AddItem();
						ItemMenu(menuList);
						break;
					}
				case 2:
					{
						ItemController.Remove();
						ItemMenu(menuList);
						break;
					}
				case 3:
					{
						ItemController.ViewAll();
						ItemMenu(menuList);
						break;
					}
				case 4:
					{
						RecipeController.FindRecipes();
						ItemMenu(menuList);
						break;
					}
				case 5:
					{
						ItemController.Owner = null;
						MenuController.LoginMenu(new List<string>(){
						"Register",
						"Login",
						"Exit"});
						break;
					}
				case 6:
					break;
				default:
					break;
			}
		}
	}
}
