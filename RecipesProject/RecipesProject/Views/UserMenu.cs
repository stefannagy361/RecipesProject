﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.Data.Entity;

namespace RecipesProject
{
	class UserMenu
	{
		public static void ShowUserMenu()
		{
			var _userChoice =  MenuView.DisplayMenu(new List<string> { "Register", "Login", "Exit" });
			switch(_userChoice)
			{
				case 1:
					{
						Console.WriteLine("----Register-------");
						Console.Write("Enter username: ");
						string _username = Console.ReadLine();
						Console.Write("Enter password: ");
						string  _password = Console.ReadLine();
						UserServices.AddUser(_username, _password);

						Logincall();
						break;
					}
				case 2:
					{	
						Logincall();
						break;
					}
				case 3:
					{
						Console.Write("APLICATION IS CLOSING: ");
						break;
					}
			}
		}

		public static void Logincall()
		{
			Console.Clear();
			Console.WriteLine("-------Login------");
			Console.Write("Enter username: ");
			string _username = Console.ReadLine();
			Console.Write("Enter password: ");
			string _password = Console.ReadLine();

			var _userId = UserServices.FindUserId(_username, _password);
			if (_userId != -1)
			{
				AutentificatorService._Session= _userId;
				LoggedUserMenu.ShowLoggedMenu();
		}
			else
				Console.WriteLine("Invalid name or password!");
		}
	
	}
}
