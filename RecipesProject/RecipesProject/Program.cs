using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using RecipesProject.Views;
namespace RecipesProject
{
	class Program
	{
		static void Main(string[] args)
		{
			
			UserMenu.ShowUserMenu();

			//UserServices.ViewAll();
			//Console.WriteLine(AutentificatorService._Session);
			
			Console.ReadKey();
		
		}
	}
}
