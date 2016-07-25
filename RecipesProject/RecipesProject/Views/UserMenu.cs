using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
						Console.Write("Enter username: ");
						string _username = Console.ReadLine();
						Console.Write("Enter password: ");
						int _password = Console.ReadLine().GetHashCode();

						//call a function to register user

						break;
					}
				case 2:
					{
						Console.Write("Enter username: ");
						string _username = Console.ReadLine();
						Console.Write("Enter password: ");
						int _password = Console.ReadLine().GetHashCode();

						//call a function to login user

						break;
					}
				case 3:
					{
						Console.Write("APLICATION IS CLOSING: ");
						break;
					}
					
			}
		}
		
	}
}
