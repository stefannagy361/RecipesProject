using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using RecipesProject.Views;
using RecipesProject.Controllers;

namespace RecipesProject
{
	class Program
	{
		static void Main(string[] args)
		{
			MenuController.LoginMenu(new List<string>(){
				"Register",
				"Login",
				"Exit"});
		}
	}
}
