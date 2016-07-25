using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
	class Program
	{
		static void Main(string[] args)
		{

			UserMenu.ShowUserMenu();
			var context = new RecipesProjectContext();

			Console.WriteLine("Add a new product");
			Console.Write("Name = ");
			string _pname = Console.ReadLine();
			Console.Write("Password = ");
			string _pass = Console.ReadLine();

			context.Users.Add(new User() { Name = _pname , Password = _pass.GetHashCode()});

			context.SaveChanges();
			

			foreach (var user in context.Users)
			{ Console.WriteLine(user.Name);
			
			}
			Console.ReadKey();
		
		}
	}
}
