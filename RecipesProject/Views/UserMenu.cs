using System;
using System.Collections.Generic;
using RecipesProject.Controlers;

namespace RecipesProject.Views
{
	public class UserMenu
	{
		public static void ShowUserMenu()
		{
			
			var _userChoice = MenuView.DisplayMenu(new List<string> 
			{
				"Register",
				"Login",
				"Exit" 
			});
			if (_userChoice == 1)
			{
				RegisterUser();
				LoginUser();
			}

			if (_userChoice == 2)
			{
				Console.Clear();
				LoginUser();
			}

			if (_userChoice == 3)
			{
				Environment.Exit(0);
			}
		}
			
		private static void RegisterUser()
		{		
			Console.Clear();
			Console.WriteLine("----Register-------");

			Console.Write("Enter username: ");
			string _username = Console.ReadLine();
			Console.Write("Enter password: ");
			string _password = Console.ReadLine();
			if (!AutentificatorService.CheckforUser(_username))
			{
				UserServices.AddUser(_username, _password);
			}
			else
			{
			Console.WriteLine("Name already in database! Chose another name");
			}
		}

		private static void LoginUser()
		{

			Console.WriteLine("-------Login------");
			Console.Write("Enter username: ");
			string _username = Console.ReadLine();
			Console.Write("Enter password: ");
			string _password = Console.ReadLine();

			var _userId = UserServices.FindUserId(_username, _password);
			if (_userId != -1)
			{
				AutentificatorService._Session = _userId;
				LoggedUserMenu.ShowLoggedMenu();
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid name or password!");
				LoginUser();
			}
		}
	
	}
}
