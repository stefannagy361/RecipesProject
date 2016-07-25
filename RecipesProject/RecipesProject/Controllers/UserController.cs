using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using RecipesProject.Views;

namespace RecipesProject.Controllers
{
	public class UserController
	{
		private static RecipesContext _context = new RecipesContext();
		internal static User foundUser;

		internal static void CreateUser()
		{
			string name;
			Console.Write("Username: ");
			name = Console.ReadLine();

			int password;
			Console.Write("Password: ");
			password = Console.ReadLine().GetHashCode();

			foundUser = _context.Users.FirstOrDefault(u => u.Name == name);
			if (foundUser == null)
			{
				_context.Users.Add(new User
				{
					Name = name,
					Password = password
				});

				Messages.Show("User added");
				_context.SaveChanges();
			}
			else
				Messages.Show("Username already taken");
		}

		internal static void Login(List<string> menuList)
		{
			string username;
			Console.Write("Username: ");
			username = Console.ReadLine();

			int password;
			Console.Write("Password: ");
			password = Console.ReadLine().GetHashCode();

			foundUser = _context.Users.FirstOrDefault(u => u.Name == username);

			if (foundUser == null || foundUser.Password != password)
			{
				Messages.Show("Invalid username or password");
				MenuController.LoginMenu(menuList);
			}
			else
			{
				Messages.Show("Succesfully logged in");
				ItemController.Owner = foundUser;
				MenuController.ItemMenu(new List<string>(){
					"Add item to fridge",
					"Remove item from fridge",
					"View items from fridge",
					"View possible recipes",
					"Logout",
					"Exit"
				});
			}
		}
	}
}
